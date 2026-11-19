using System;
using RoomManagement.Models;

namespace RoomManagement.Utils
{
    // Remembers who is logged in
    public class Session
    {
        public static User CurrentUser = null;

        public static bool IsAdmin()
        {
            return CurrentUser != null && CurrentUser.Role == UserRole.ADMIN;
        }

        // Stops the action if nobody is logged in
        public static void CheckLoggedIn()
        {
            if (CurrentUser == null)
            {
                throw new Exception("You must be logged in.");
            }
        }

        // Stops the action if the user is not an admin
        public static void CheckAdmin()
        {
            if (!IsAdmin())
            {
                throw new Exception("Only administrators can do this.");
            }
        }
    }
}
