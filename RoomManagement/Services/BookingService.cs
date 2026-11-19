using System;
using System.Collections.Generic;
using RoomManagement.Repositories;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Services
{
    // Booking rules:
    //  - A new booking is PENDING. The admin APPROVES or REJECTS it.
    //  - A user can cancel a PENDING booking directly (CANCELLED).
    //  - Cancelling an APPROVED booking becomes CANCEL_REQUESTED, and the admin decides.
    //  - No bookings on weekends, public holidays or in the past.
    //  - Two active bookings of the same room cannot overlap.
    public class BookingService
    {
        private BookingRepository bookingRepository = new BookingRepository();
        private RoomRepository roomRepository = new RoomRepository();
        private HolidayRepository holidayRepository = new HolidayRepository();

        // For the admin. "ALL" shows every booking.
        public List<Booking> GetBookings(string statusFilter)
        {
            Session.CheckAdmin();

            if (statusFilter == "ALL")
            {
                return bookingRepository.GetAll();
            }

            BookingStatus status = (BookingStatus)Enum.Parse(typeof(BookingStatus), statusFilter);
            return bookingRepository.GetByStatus(status);
        }

        // For the admin "All Booking Status" list:
        // filter by status, search by text, and sort newest or oldest first.
        public List<Booking> GetBookings(string statusFilter, string search, bool newestFirst)
        {
            List<Booking> bookings = GetBookings(statusFilter);   // newest first
            List<Booking> result = new List<Booking>();
            search = search.Trim().ToLower();

            foreach (Booking booking in bookings)
            {
                bool matches = search == ""
                    || booking.UserFullName.ToLower().Contains(search)
                    || booking.RoomName.ToLower().Contains(search)
                    || booking.Purpose.ToLower().Contains(search)
                    || booking.Status.ToString().ToLower().Contains(search);

                if (matches)
                {
                    if (newestFirst)
                    {
                        result.Add(booking);         // add at the end
                    }
                    else
                    {
                        result.Insert(0, booking);   // add at the start, so the oldest ends up first
                    }
                }
            }
            return result;
        }

        // Bookings where the user asked to cancel an approved booking (the admin must answer them)
        public List<Booking> GetCancelRequests()
        {
            Session.CheckAdmin();
            return bookingRepository.GetByStatus(BookingStatus.CANCEL_REQUESTED);
        }

        // True if the meeting starts before 08:00 or ends after 17:00 (the booking window shows a warning)
        public static bool IsOutsideWorkingHours(TimeSpan startTime, TimeSpan endTime)
        {
            if (startTime.Hours < 8 || startTime.Hours >= 17)
            {
                return true;
            }
            if (endTime.Hours < 8 || endTime > new TimeSpan(17, 0, 0))
            {
                return true;
            }
            return false;
        }

        // Bookings of the logged-in user
        public List<Booking> GetMyBookings()
        {
            Session.CheckLoggedIn();
            return bookingRepository.GetByUser(Session.CurrentUser.Id);
        }

        public void CreateBooking(int roomId, string purpose, DateTime startDate, DateTime endDate, TimeSpan startTime, TimeSpan endTime)
        {
            Session.CheckLoggedIn();

            // Rules from the functional requirements
            if (purpose.Trim().Length < 3 || !Validator.HasLetter(purpose))
            {
                throw new Exception("Purpose must be text, at least 3 characters.");
            }
            if (Validator.CountWords(purpose) > 10)
            {
                throw new Exception("Purpose must be 10 words or less.");
            }

            CheckTimeSlot(startDate, endDate, startTime, endTime);

            Room room = roomRepository.GetById(roomId);
            if (room == null)
            {
                throw new Exception("Room not found.");
            }
            if (room.Status != RoomStatus.AVAILABLE)
            {
                throw new Exception("This room is under maintenance.");
            }
            if (IsRoomBusy(roomId, startDate.Date + startTime, endDate.Date + endTime, 0))
            {
                throw new Exception("This room is already booked for the selected date and hours.");
            }

            Booking booking = new Booking();
            booking.UserId = Session.CurrentUser.Id;
            booking.RoomId = roomId;
            booking.Purpose = purpose.Trim();
            booking.StartDate = startDate.Date;
            booking.EndDate = endDate.Date;
            booking.StartTime = startTime;
            booking.EndTime = endTime;
            booking.Status = BookingStatus.PENDING;
            bookingRepository.Add(booking);
        }

        public void ApproveBooking(int id)
        {
            Session.CheckAdmin();
            Booking booking = FindBooking(id);

            if (booking.Status != BookingStatus.PENDING)
            {
                throw new Exception("Only pending bookings can be approved.");
            }
            if (IsRoomBusy(booking.RoomId, booking.GetStartDateTime(), booking.GetEndDateTime(), booking.Id))
            {
                throw new Exception("This room is already booked for the selected date and hours.");
            }

            bookingRepository.UpdateStatusByAdmin(id, BookingStatus.APPROVED, Session.CurrentUser.Id);
        }

        public void RejectBooking(int id)
        {
            Session.CheckAdmin();
            Booking booking = FindBooking(id);

            if (booking.Status != BookingStatus.PENDING)
            {
                throw new Exception("Only pending bookings can be rejected.");
            }

            bookingRepository.UpdateStatusByAdmin(id, BookingStatus.REJECTED, Session.CurrentUser.Id);
        }

        // Called by the user who made the booking
        public void CancelBooking(int id, string reason)
        {
            Session.CheckLoggedIn();
            Booking booking = FindBooking(id);

            if (booking.UserId != Session.CurrentUser.Id)
            {
                throw new Exception("You can only cancel your own bookings.");
            }

            // Rules from the functional requirements
            if (reason.Trim() == "")
            {
                throw new Exception("Please provide a reason for cancellation.");
            }
            if (Validator.CountWords(reason) > 10)
            {
                throw new Exception("Reason must be 10 words or less.");
            }

            if (booking.Status == BookingStatus.PENDING)
            {
                bookingRepository.UpdateStatusWithReason(id, BookingStatus.CANCELLED, reason.Trim());
            }
            else if (booking.Status == BookingStatus.APPROVED)
            {
                bookingRepository.UpdateStatusWithReason(id, BookingStatus.CANCEL_REQUESTED, reason.Trim());
            }
            else
            {
                throw new Exception("This booking cannot be cancelled.");
            }
        }

        public void ApproveCancel(int id)
        {
            Session.CheckAdmin();
            Booking booking = FindBooking(id);

            if (booking.Status != BookingStatus.CANCEL_REQUESTED)
            {
                throw new Exception("Only cancel requests can be approved.");
            }

            bookingRepository.UpdateStatusByAdmin(id, BookingStatus.CANCELLED, Session.CurrentUser.Id);
        }

        public void RejectCancel(int id)
        {
            Session.CheckAdmin();
            Booking booking = FindBooking(id);

            if (booking.Status != BookingStatus.CANCEL_REQUESTED)
            {
                throw new Exception("Only cancel requests can be rejected.");
            }

            // The booking goes back to APPROVED
            bookingRepository.UpdateStatusByAdmin(id, BookingStatus.APPROVED, Session.CurrentUser.Id);
        }

        public void DeleteBooking(int id)
        {
            Session.CheckAdmin();
            FindBooking(id);
            bookingRepository.Delete(id);
        }

        // Checks dates and times. Throws an Exception if something is wrong.
        private void CheckTimeSlot(DateTime startDate, DateTime endDate, TimeSpan startTime, TimeSpan endTime)
        {
            startDate = startDate.Date;
            endDate = endDate.Date;

            if (startDate > endDate)
            {
                throw new Exception("Start date cannot be after end date.");
            }

            DateTime start = startDate + startTime;
            DateTime end = endDate + endTime;

            if (start >= end)
            {
                throw new Exception("Start time must be before end time.");
            }
            if (start < DateTime.Now)
            {
                throw new Exception("You cannot book a time in the past.");
            }

            // Check every day between start date and end date
            DateTime day = startDate;
            while (day <= endDate)
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    throw new Exception("Weekend bookings are not allowed.");
                }

                Holiday holiday = holidayRepository.GetByDate(day);
                if (holiday != null)
                {
                    throw new Exception("Bookings on public holidays are not allowed (" + holiday.Name + ", " + day.ToString("dd MMM yyyy") + ").");
                }

                day = day.AddDays(1);
            }
        }

        // True if the room has another active booking that overlaps the time from "start" to "end".
        // The booking with id "ignoreBookingId" is not counted (used when approving).
        private bool IsRoomBusy(int roomId, DateTime start, DateTime end, int ignoreBookingId)
        {
            List<Booking> bookings = bookingRepository.GetActiveBetween(start.Date, end.Date);

            foreach (Booking other in bookings)
            {
                if (other.RoomId != roomId || other.Id == ignoreBookingId)
                {
                    continue;
                }

                // When approving, other PENDING requests do not block
                if (ignoreBookingId != 0 && other.Status == BookingStatus.PENDING)
                {
                    continue;
                }

                // Two time ranges overlap when each one starts before the other one ends
                if (other.GetStartDateTime() < end && other.GetEndDateTime() > start)
                {
                    return true;
                }
            }
            return false;
        }

        private Booking FindBooking(int id)
        {
            Booking booking = bookingRepository.GetById(id);
            if (booking == null)
            {
                throw new Exception("Booking not found.");
            }
            return booking;
        }
    }
}
