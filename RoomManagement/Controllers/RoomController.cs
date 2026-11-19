using System;
using System.Collections.Generic;
using RoomManagement.Models;
using RoomManagement.Services;

namespace RoomManagement.Controllers
{
    // Controller for rooms.
    // The forms call this controller; the controller passes the request to RoomService.
    public class RoomController
    {
        private RoomService roomService = new RoomService();

        public List<Room> GetRooms(string keyword)
        {
            return roomService.GetRooms(keyword);
        }

        public void AddRoom(string roomName, string capacityText, string location, string description, RoomStatus status)
        {
            roomService.AddRoom(roomName, capacityText, location, description, status);
        }

        public void UpdateRoom(int id, string roomName, string capacityText, string location, string description, RoomStatus status)
        {
            roomService.UpdateRoom(id, roomName, capacityText, location, description, status);
        }

        public void DeleteRoom(int id)
        {
            roomService.DeleteRoom(id);
        }
    }
}
