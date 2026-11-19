using System;
using System.Collections.Generic;
using RoomManagement.Repositories;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Services
{
    // Numbers and today's meetings for the admin dashboard
    public class DashboardService
    {
        private RoomRepository roomRepository = new RoomRepository();
        private BookingRepository bookingRepository = new BookingRepository();

        public DashboardStats GetStats()
        {
            Session.CheckAdmin();
            DateTime today = DateTime.Today;

            // Count how many different rooms have an approved booking today
            List<Booking> todayBookings = bookingRepository.GetApprovedOnDate(today);
            List<int> bookedRoomIds = new List<int>();
            foreach (Booking booking in todayBookings)
            {
                if (!bookedRoomIds.Contains(booking.RoomId))
                {
                    bookedRoomIds.Add(booking.RoomId);
                }
            }

            DashboardStats stats = new DashboardStats();
            stats.TotalRooms = roomRepository.Count();
            stats.AvailableRooms = stats.TotalRooms - bookedRoomIds.Count;
            stats.PendingBookings = bookingRepository.CountByStatus(BookingStatus.PENDING);
            stats.ApprovedBookings = bookingRepository.CountByStatus(BookingStatus.APPROVED);
            stats.RejectedBookings = bookingRepository.CountByStatus(BookingStatus.REJECTED);
            stats.CancelRequestedBookings = bookingRepository.CountByStatus(BookingStatus.CANCEL_REQUESTED);
            stats.TodayBookings = bookingRepository.CountStartingOn(today);
            stats.UpcomingBookings = bookingRepository.CountStartingAfter(today);
            return stats;
        }

        // The 5 most recent booking requests (cancel requests first).
        // If "search" is not empty, only bookings containing that text are returned.
        public List<Booking> GetRecentBookings(string search)
        {
            Session.CheckAdmin();
            List<Booking> allBookings = bookingRepository.GetAll();   // newest first
            List<Booking> result = new List<Booking>();

            // First the cancel requests, because the admin must answer them
            foreach (Booking booking in allBookings)
            {
                if (booking.Status == BookingStatus.CANCEL_REQUESTED && MatchesSearch(booking, search))
                {
                    result.Add(booking);
                }
            }

            // Then all the other bookings
            foreach (Booking booking in allBookings)
            {
                if (booking.Status != BookingStatus.CANCEL_REQUESTED && MatchesSearch(booking, search))
                {
                    result.Add(booking);
                }
            }

            // Keep only the first 5
            while (result.Count > 5)
            {
                result.RemoveAt(result.Count - 1);
            }
            return result;
        }

        // True if the user name, room, purpose or status contains the search text
        private bool MatchesSearch(Booking booking, string search)
        {
            search = search.Trim().ToLower();
            if (search == "")
            {
                return true;
            }

            if (booking.UserFullName.ToLower().Contains(search)) return true;
            if (booking.RoomName.ToLower().Contains(search)) return true;
            if (booking.Purpose.ToLower().Contains(search)) return true;
            if (booking.Status.ToString().ToLower().Contains(search)) return true;
            return false;
        }
    }
}
