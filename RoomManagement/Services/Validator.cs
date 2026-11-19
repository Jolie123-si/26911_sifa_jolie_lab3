using System;

namespace RoomManagement.Services
{
    // Common checks used by several controllers.
    // Each method throws an Exception with a message when the value is not valid.
    public class Validator
    {
        public static void CheckFullName(string fullName)
        {
            if (fullName.Length < 3)
            {
                throw new Exception("Full name must be at least 3 characters.");
            }
        }

        public static void CheckEmail(string email)
        {
            int atPosition = email.IndexOf("@");
            int lastDotPosition = email.LastIndexOf(".");

            // There must be text before "@" and a "." somewhere after it
            if (atPosition < 1 || lastDotPosition < atPosition + 2 || lastDotPosition == email.Length - 1 || email.Contains(" "))
            {
                throw new Exception("Please enter a valid email address.");
            }
        }

        public static void CheckPassword(string password, string confirmPassword)
        {
            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }

            bool hasLetter = false;
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }

            if (!hasLetter || !hasDigit)
            {
                throw new Exception("Password must contain both letters and numbers.");
            }

            if (password != confirmPassword)
            {
                throw new Exception("Passwords do not match.");
            }
        }

        // Counts the words in a text (words are separated by spaces)
        public static int CountWords(string text)
        {
            int count = 0;
            string[] parts = text.Trim().Split(' ');
            foreach (string part in parts)
            {
                if (part != "")
                {
                    count++;
                }
            }
            return count;
        }

        // True if the text has at least one letter
        public static bool HasLetter(string text)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        // True if the text has only letters, spaces and . , ' -  (no numbers)
        public static bool IsTextOnly(string text)
        {
            foreach (char c in text)
            {
                bool allowed = char.IsLetter(c) || c == ' ' || c == '.' || c == ',' || c == '\'' || c == '-';
                if (!allowed)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
