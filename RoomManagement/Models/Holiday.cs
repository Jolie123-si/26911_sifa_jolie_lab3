using System;

namespace RoomManagement.Models
{
    // Represents one row of the Holidays table
    public class Holiday
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
    }
}
