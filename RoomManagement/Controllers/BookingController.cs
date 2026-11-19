using System;
using System.Collections.Generic;
using RoomManagement.Models;
using RoomManagement.Services;

namespace RoomManagement.Controllers
{
    // Controller for bookings.
    // The forms call this controller; the controller passes the request to BookingService.
    public class BookingController
    {
        private BookingService bookingService = new BookingService();

        public static bool IsOutsideWorkingHours(TimeSpan startTime, TimeSpan endTime)
        {
            return BookingService.IsOutsideWorkingHours(startTime, endTime);
        }

        // Used by the forms to show "x words left"
        public static int CountWords(string text)
        {
            return Validator.CountWords(text);
        }

        public List<Booking> GetBookings(string statusFilter, string search, bool newestFirst)
        {
            return bookingService.GetBookings(statusFilter, search, newestFirst);
        }

        public List<Booking> GetCancelRequests()
        {
            return bookingService.GetCancelRequests();
        }

        public List<Booking> GetMyBookings()
        {
            return bookingService.GetMyBookings();
        }

        public void CreateBooking(int roomId, string purpose, DateTime startDate, DateTime endDate, TimeSpan startTime, TimeSpan endTime)
        {
            bookingService.CreateBooking(roomId, purpose, startDate, endDate, startTime, endTime);
        }

        public void ApproveBooking(int id)
        {
            bookingService.ApproveBooking(id);
        }

        public void RejectBooking(int id)
        {
            bookingService.RejectBooking(id);
        }

        public void CancelBooking(int id, string reason)
        {
            bookingService.CancelBooking(id, reason);
        }

        public void ApproveCancel(int id)
        {
            bookingService.ApproveCancel(id);
        }

        public void RejectCancel(int id)
        {
            bookingService.RejectCancel(id);
        }

        public void DeleteBooking(int id)
        {
            bookingService.DeleteBooking(id);
        }
    }
}
