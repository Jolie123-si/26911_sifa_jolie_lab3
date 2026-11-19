using System;
using System.Collections.Generic;
using RoomManagement.Models;
using RoomManagement.Services;

namespace RoomManagement.Controllers
{
    // Controller for the admin dashboard.
    // The forms call this controller; the controller passes the request to DashboardService.
    public class DashboardController
    {
        private DashboardService dashboardService = new DashboardService();

        public DashboardStats GetStats()
        {
            return dashboardService.GetStats();
        }

        public List<Booking> GetRecentBookings(string search)
        {
            return dashboardService.GetRecentBookings(search);
        }
    }
}
