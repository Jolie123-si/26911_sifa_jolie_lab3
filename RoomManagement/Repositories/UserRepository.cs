using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using RoomManagement.Data;
using RoomManagement.Models;

namespace RoomManagement.Repositories
{
    // All SQL for the Users table
    public class UserRepository
    {
        // Returns the user or null if not found (the email is not case sensitive)
        public User GetByEmail(string email)
        {
            User user = null;

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT * FROM Users WHERE lower(Email) = lower(@Email)", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                SqliteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = ReadUser(reader);
                }
            }
            return user;
        }

        public void Add(User user)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "INSERT INTO Users (FullName, Email, PasswordHash, Role, PasswordChanged) " +
                             "VALUES (@FullName, @Email, @PasswordHash, @Role, @PasswordChanged)";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@Role", user.Role.ToString());
                cmd.Parameters.AddWithValue("@PasswordChanged", user.PasswordChanged);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(User user)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "UPDATE Users SET FullName = @FullName, Email = @Email, PasswordHash = @PasswordHash, " +
                             "Role = @Role, PasswordChanged = @PasswordChanged WHERE Id = @Id";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@Role", user.Role.ToString());
                cmd.Parameters.AddWithValue("@PasswordChanged", user.PasswordChanged);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Saves the "Forgot password?" code and when it expires
        public void SaveResetToken(int userId, string token, DateTime expiry)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "UPDATE Users SET PasswordResetToken = @Token, ResetTokenExpiry = @Expiry WHERE Id = @Id";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Token", token);
                cmd.Parameters.AddWithValue("@Expiry", expiry.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery();
            }
        }

        // Removes the reset code after it was used
        public void ClearResetToken(int userId)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("UPDATE Users SET PasswordResetToken = NULL, ResetTokenExpiry = NULL WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery();
            }
        }

        // Converts the current row of the reader into a User object
        private User ReadUser(SqliteDataReader reader)
        {
            User user = new User();
            user.Id = Convert.ToInt32(reader["Id"]);
            user.FullName = reader["FullName"].ToString();
            user.Email = reader["Email"].ToString();
            user.PasswordHash = reader["PasswordHash"].ToString();
            user.Role = (UserRole)Enum.Parse(typeof(UserRole), reader["Role"].ToString());
            user.PasswordChanged = Convert.ToBoolean(reader["PasswordChanged"]);
            user.PasswordResetToken = reader["PasswordResetToken"].ToString();   // NULL becomes ""
            user.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);

            if (reader["ResetTokenExpiry"] != DBNull.Value)
            {
                user.ResetTokenExpiry = Convert.ToDateTime(reader["ResetTokenExpiry"]);
            }
            return user;
        }
    }
}
