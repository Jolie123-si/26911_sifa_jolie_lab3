namespace RoomManagement.Models
{
    // Numbers shown on the admin dashboard
    public class DashboardStats
    {
        public int TotalRooms { get; set; }
        public int AvailableRooms { get; set; }
        public int PendingBookings { get; set; }
        public int ApprovedBookings { get; set; }
        public int RejectedBookings { get; set; }
        public int CancelRequestedBookings { get; set; }
        public int TodayBookings { get; set; }
        public int UpcomingBookings { get; set; }
    }
}
