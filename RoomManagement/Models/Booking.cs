using System;

namespace RoomManagement.Models
{
    // Represents one row of the Bookings table
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string Purpose { get; set; }
        public string CancelReason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ApprovedById { get; set; }        // 0 when nobody handled it yet
        public DateTime? ApprovedAt { get; set; }

        // Extra fields filled from other tables (for display in the grid)
        public string UserFullName { get; set; }
        public string RoomName { get; set; }
        public string ApprovedByName { get; set; }

        // Text shown in the "Date & Time" column.
        // One day:   "17 Nov 2026, 09:00 - 10:00"
        // Many days: "17 Nov 2026 to 19 Nov 2026, 09:00 - 10:00"
        public string DateAndTime
        {
            get
            {
                string times = StartTime.ToString(@"hh\:mm") + " - " + EndTime.ToString(@"hh\:mm");
                if (StartDate.Date == EndDate.Date)
                {
                    return StartDate.ToString("dd MMM yyyy") + ", " + times;
                }
                return StartDate.ToString("dd MMM yyyy") + " to " + EndDate.ToString("dd MMM yyyy") + ", " + times;
            }
        }

        // Text shown in the "Info" column of My Bookings
        public string StatusMessage
        {
            get
            {
                if (Status == BookingStatus.PENDING) return "Waiting for admin approval";
                if (Status == BookingStatus.APPROVED) return "Booking confirmed";
                if (Status == BookingStatus.REJECTED) return "Booking was rejected";
                if (Status == BookingStatus.CANCELLED) return "Booking cancelled";
                return "Waiting for admin to approve cancel";
            }
        }

        // Start date + start time together
        public DateTime GetStartDateTime()
        {
            return StartDate.Date + StartTime;
        }

        // End date + end time together
        public DateTime GetEndDateTime()
        {
            return EndDate.Date + EndTime;
        }
    }
}
