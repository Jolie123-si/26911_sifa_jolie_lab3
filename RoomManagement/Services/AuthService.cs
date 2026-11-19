using System;
using System.Configuration;
using RoomManagement.Repositories;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Services
{
    // Login, logout, register, change password, forgot password and reset password
    public class AuthService
    {
        private UserRepository userRepository = new UserRepository();

        public User Login(string email, string password)
        {
            if (email.Trim() == "" || password == "")
            {
                throw new Exception("Please enter your email and password.");
            }

            User user = userRepository.GetByEmail(email.Trim());

            // BCrypt.Verify compares the typed password with the saved hash
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                throw new Exception("Invalid email or password.");
            }

            Session.CurrentUser = user;
            return user;
        }

        public void Logout()
        {
            Session.CurrentUser = null;
        }

        // The user who is signed in now (the views ask the controller, not the Session directly)
        public User GetCurrentUser()
        {
            Session.CheckLoggedIn();
            return Session.CurrentUser;
        }

        // True if the signed-in user is an administrator
        public bool IsAdmin()
        {
            return Session.IsAdmin();
        }

        // True if App.config says emails can be sent
        public bool IsEmailEnabled()
        {
            return EmailService.IsEnabled();
        }

        // Password given to new accounts (from App.config)
        public static string GetDefaultPassword()
        {
            return ConfigurationManager.AppSettings["DefaultPassword"];
        }

        // FR-1.1: the person gives a full name and an email address,
        // and chooses the role: USER (books rooms) or ADMIN (manages rooms, bookings and holidays).
        // The account gets the default password (RRA@2024) and must set a new password at first sign in.
        public User Register(string fullName, string email, UserRole role)
        {
            fullName = fullName.Trim();
            email = email.Trim().ToLower();

            Validator.CheckFullName(fullName);
            Validator.CheckEmail(email);

            if (userRepository.GetByEmail(email) != null)
            {
                throw new Exception("Email already registered.");
            }

            User user = new User();
            user.FullName = fullName;
            user.Email = email;
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(GetDefaultPassword());
            user.Role = role;
            user.PasswordChanged = false;
            userRepository.Add(user);
            return user;
        }

        // FR-1.2: sends the default password to the new user's email
        // (only when email is switched on in App.config)
        public void SendDefaultPasswordEmail(User user)
        {
            string body = "Hello " + user.FullName + ",\n\n" +
                          "Your account for RRA Meeting Room Management was created.\n" +
                          "Email: " + user.Email + "\n" +
                          "Default password: " + GetDefaultPassword() + "\n\n" +
                          "You will choose your own password when you first sign in.\n" +
                          "You can also use \"Forgot password?\" to reset it.\n\n" +
                          "Rwanda Revenue Authority";
            EmailService.SendEmail(user.Email, "RRA Room Management - Your Account", body);
        }

        public void ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            Session.CheckLoggedIn();
            User user = Session.CurrentUser;

            if (!BCrypt.Net.BCrypt.Verify(currentPassword, user.PasswordHash))
            {
                throw new Exception("Current password is incorrect.");
            }

            Validator.CheckPassword(newPassword, confirmPassword);

            if (currentPassword == newPassword)
            {
                throw new Exception("New password must be different from the current password.");
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            user.PasswordChanged = true;
            userRepository.Update(user);
        }

        // Step 1 of "Forgot password?": creates a 6-digit reset code that is valid for 1 hour
        // and sends it by email.
        // Returns the code only when email is switched off in App.config, so it can be shown on screen.
        public string ForgotPassword(string email)
        {
            email = email.Trim();
            Validator.CheckEmail(email);

            User user = userRepository.GetByEmail(email);
            if (user == null)
            {
                throw new Exception("No account found with that email.");
            }

            Random random = new Random();
            string code = random.Next(100000, 1000000).ToString();
            userRepository.SaveResetToken(user.Id, code, DateTime.Now.AddHours(1));

            if (EmailService.IsEnabled())
            {
                string body = "Hello " + user.FullName + ",\n\n" +
                              "Your password reset code is: " + code + "\n" +
                              "It is valid for 1 hour.\n\n" +
                              "If you did not request this, ignore this email.\n\n" +
                              "Rwanda Revenue Authority";
                EmailService.SendEmail(user.Email, "RRA Room Management - Password Reset", body);
                return "";
            }

            return code;
        }

        // Step 2 of "Forgot password?": checks the code and saves the new password
        public void ResetPassword(string email, string code, string newPassword, string confirmPassword)
        {
            User user = userRepository.GetByEmail(email.Trim());
            if (user == null)
            {
                throw new Exception("No account found with that email.");
            }

            if (code.Trim() == "" || user.PasswordResetToken != code.Trim())
            {
                throw new Exception("Invalid or expired reset code.");
            }
            if (user.ResetTokenExpiry == null || user.ResetTokenExpiry < DateTime.Now)
            {
                throw new Exception("Reset code has expired. Please ask for a new one.");
            }

            Validator.CheckPassword(newPassword, confirmPassword);

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            user.PasswordChanged = true;
            userRepository.Update(user);
            userRepository.ClearResetToken(user.Id);
        }
    }
}
