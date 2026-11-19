using System;

namespace RoomManagement.Models
{
    // Represents one row of the Rooms table
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public RoomStatus Status { get; set; }

        // These two are not saved in the database.
        // They are calculated to show if the room is booked today.
        public bool CurrentlyBooked { get; set; }
        public DateTime? BookedUntil { get; set; }

        // Text shown in the "Availability" column
        public string Availability
        {
            get
            {
                if (Status == RoomStatus.MAINTENANCE)
                {
                    return "Maintenance";
                }
                if (CurrentlyBooked)
                {
                    return "Booked";
                }
                return "Available";
            }
        }
    }
}
