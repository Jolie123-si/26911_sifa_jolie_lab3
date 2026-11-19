using System;
using System.Collections.Generic;
using RoomManagement.Repositories;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Services
{
    // Add, edit, delete and list rooms
    public class RoomService
    {
        private RoomRepository roomRepository = new RoomRepository();
        private BookingRepository bookingRepository = new BookingRepository();

        // The floors a room can be on
        public static string[] GetLocations()
        {
            return new string[] { "Ground", "1st Floor", "2nd Floor", "3rd Floor" };
        }

        // Returns all rooms (or only the ones matching the keyword)
        // and marks the rooms that have an approved booking today.
        public List<Room> GetRooms(string keyword)
        {
            List<Room> rooms;
            if (keyword.Trim() == "")
            {
                rooms = roomRepository.GetAll();
            }
            else
            {
                rooms = roomRepository.Search(keyword.Trim());
            }

            List<Booking> todayBookings = bookingRepository.GetApprovedOnDate(DateTime.Today);

            foreach (Room room in rooms)
            {
                foreach (Booking booking in todayBookings)
                {
                    if (booking.RoomId == room.Id)
                    {
                        room.CurrentlyBooked = true;

                        // Keep the latest end date
                        if (room.BookedUntil == null || booking.EndDate > room.BookedUntil)
                        {
                            room.BookedUntil = booking.EndDate;
                        }
                    }
                }
            }
            return rooms;
        }

        public void AddRoom(string roomName, string capacityText, string location, string description, RoomStatus status)
        {
            Session.CheckAdmin();

            Room room = new Room();
            FillRoom(room, roomName, capacityText, location, description, status);

            if (roomRepository.NameExists(room.RoomName, 0))
            {
                throw new Exception("A room with this name already exists.");
            }

            roomRepository.Add(room);
        }

        public void UpdateRoom(int id, string roomName, string capacityText, string location, string description, RoomStatus status)
        {
            Session.CheckAdmin();

            Room room = roomRepository.GetById(id);
            if (room == null)
            {
                throw new Exception("Room not found.");
            }

            FillRoom(room, roomName, capacityText, location, description, status);

            if (roomRepository.NameExists(room.RoomName, id))
            {
                throw new Exception("A room with this name already exists.");
            }

            roomRepository.Update(room);
        }

        public void DeleteRoom(int id)
        {
            Session.CheckAdmin();

            if (roomRepository.GetById(id) == null)
            {
                throw new Exception("Room not found.");
            }

            roomRepository.Delete(id);
        }

        // Checks the values typed by the user and puts them in the room object
        private void FillRoom(Room room, string roomName, string capacityText, string location, string description, RoomStatus status)
        {
            if (roomName.Trim() == "")
            {
                throw new Exception("Room name is required.");
            }

            // The location must be one of the floors in the list
            bool validLocation = false;
            foreach (string floor in GetLocations())
            {
                if (floor == location)
                {
                    validLocation = true;
                }
            }
            if (!validLocation)
            {
                throw new Exception("Select a location: Ground, 1st Floor, 2nd Floor or 3rd Floor.");
            }

            int capacity;
            if (!int.TryParse(capacityText.Trim(), out capacity) || capacity < 1 || capacity > 1000)
            {
                throw new Exception("Capacity must be a whole number between 1 and 1000.");
            }

            if (!Validator.IsTextOnly(description.Trim()))
            {
                throw new Exception("Description must be text only, with no numbers.");
            }

            room.RoomName = roomName.Trim();
            room.Capacity = capacity;
            room.Location = location;
            room.Description = description.Trim();
            room.Status = status;
        }
    }
}
