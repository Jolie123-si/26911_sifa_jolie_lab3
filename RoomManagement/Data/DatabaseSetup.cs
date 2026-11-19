using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace RoomManagement.Data
{
    // Creates the database file, the tables and the first data.
    // (The connection itself is in DbConnection.cs)
    public class DatabaseSetup
    {
        // Called once when the program starts
        public static void Initialize()
        {
            // Make sure the Data\Database folder exists. SQLite creates the .db file by itself.
            Directory.CreateDirectory(DbConnection.GetDatabaseFolder());

            CreateTables();
            DataSeeder.Seed();
        }

        // Creates the 4 tables if they do not exist
        private static void CreateTables()
        {
            // Dates are saved as text "yyyy-MM-dd" and times as "HH:mm:ss"
            string usersTable =
                "CREATE TABLE IF NOT EXISTS Users (" +
                "  Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "  FullName TEXT NOT NULL," +
                "  Email TEXT NOT NULL UNIQUE," +
                "  PasswordHash TEXT NOT NULL," +
                "  Role TEXT NOT NULL CHECK (Role IN ('ADMIN','USER'))," +
                "  PasswordChanged INTEGER NOT NULL DEFAULT 0," +
                "  PasswordResetToken TEXT NULL," +
                "  ResetTokenExpiry TEXT NULL," +
                "  CreatedAt TEXT NOT NULL DEFAULT (datetime('now','localtime'))" +
                ")";

            string roomsTable =
                "CREATE TABLE IF NOT EXISTS Rooms (" +
                "  Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "  RoomName TEXT NOT NULL UNIQUE," +
                "  Capacity INTEGER NOT NULL CHECK (Capacity > 0)," +
                "  Location TEXT NOT NULL," +
                "  Description TEXT NULL," +
                "  Status TEXT NOT NULL DEFAULT 'AVAILABLE' CHECK (Status IN ('AVAILABLE','MAINTENANCE'))" +
                ")";

            string holidaysTable =
                "CREATE TABLE IF NOT EXISTS Holidays (" +
                "  Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "  HolidayDate TEXT NOT NULL UNIQUE," +
                "  Name TEXT NOT NULL" +
                ")";

            // When a room is deleted, its bookings are deleted too (ON DELETE CASCADE)
            string bookingsTable =
                "CREATE TABLE IF NOT EXISTS Bookings (" +
                "  Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "  UserId INTEGER NOT NULL REFERENCES Users(Id)," +
                "  RoomId INTEGER NOT NULL REFERENCES Rooms(Id) ON DELETE CASCADE," +
                "  Purpose TEXT NOT NULL," +
                "  CancelReason TEXT NULL," +
                "  StartDate TEXT NOT NULL," +
                "  EndDate TEXT NOT NULL," +
                "  StartTime TEXT NOT NULL," +
                "  EndTime TEXT NOT NULL," +
                "  Status TEXT NOT NULL DEFAULT 'PENDING' CHECK (Status IN ('PENDING','APPROVED','REJECTED','CANCELLED','CANCEL_REQUESTED'))," +
                "  CreatedAt TEXT NOT NULL DEFAULT (datetime('now','localtime'))," +
                "  ApprovedBy INTEGER NULL REFERENCES Users(Id)," +
                "  ApprovedAt TEXT NULL" +
                ")";

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand(usersTable, conn);
                cmd.ExecuteNonQuery();

                cmd = new SqliteCommand(roomsTable, conn);
                cmd.ExecuteNonQuery();

                cmd = new SqliteCommand(holidaysTable, conn);
                cmd.ExecuteNonQuery();

                cmd = new SqliteCommand(bookingsTable, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
