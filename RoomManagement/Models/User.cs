using System;

namespace RoomManagement.Models
{
    // Represents one row of the Users table
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public bool PasswordChanged { get; set; }
        public string PasswordResetToken { get; set; }     // code sent by "Forgot password?" ("" when none)
        public DateTime? ResetTokenExpiry { get; set; }    // the code stops working after this time
        public DateTime CreatedAt { get; set; }

        public bool IsAdmin()
        {
            return Role == UserRole.ADMIN;
        }
    }
}
