using System;
using RoomManagement.Models;
using RoomManagement.Services;

namespace RoomManagement.Controllers
{
    // Controller for sign in, sign up and passwords.
    // The forms call this controller; the controller passes the request to AuthService.
    public class AuthController
    {
        private AuthService authService = new AuthService();

        public static string GetDefaultPassword()
        {
            return AuthService.GetDefaultPassword();
        }

        public User Login(string email, string password)
        {
            return authService.Login(email, password);
        }

        public void Logout()
        {
            authService.Logout();
        }

        public User GetCurrentUser()
        {
            return authService.GetCurrentUser();
        }

        public bool IsAdmin()
        {
            return authService.IsAdmin();
        }

        public bool IsEmailEnabled()
        {
            return authService.IsEmailEnabled();
        }

        public User Register(string fullName, string email, UserRole role)
        {
            return authService.Register(fullName, email, role);
        }

        public void SendDefaultPasswordEmail(User user)
        {
            authService.SendDefaultPasswordEmail(user);
        }

        public void ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            authService.ChangePassword(currentPassword, newPassword, confirmPassword);
        }

        public string ForgotPassword(string email)
        {
            return authService.ForgotPassword(email);
        }

        public void ResetPassword(string email, string code, string newPassword, string confirmPassword)
        {
            authService.ResetPassword(email, code, newPassword, confirmPassword);
        }
    }
}
