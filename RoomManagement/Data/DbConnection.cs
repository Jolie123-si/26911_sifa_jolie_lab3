using System;
using System.Configuration;
using System.IO;
using Microsoft.Data.Sqlite;

namespace RoomManagement.Data
{
    // This class holds the database connection.
    // Every repository calls DbConnection.GetConnection() to talk to the database.
    //
    // The database is a SQLite file: <project folder>\Data\Database\RoomManagement.db
    // SQLite needs no server and no installation, so the project runs on any computer.
    public class DbConnection
    {
        // Returns the folder where the database file is kept: <project folder>\Data\Database
        public static string GetDatabaseFolder()
        {
            // The program runs from bin\Debug\..., so go up until we find the project file
            DirectoryInfo folder = new DirectoryInfo(AppContext.BaseDirectory);
            while (folder != null)
            {
                if (File.Exists(Path.Combine(folder.FullName, "RoomManagement.csproj")))
                {
                    return Path.Combine(folder.FullName, "Data", "Database");
                }
                folder = folder.Parent;
            }

            // Project file not found (for example when the .exe is copied somewhere else)
            return Path.Combine(AppContext.BaseDirectory, "Data", "Database");
        }

        // Full path of the database file
        public static string GetDatabasePath()
        {
            string fileName = ConfigurationManager.AppSettings["DatabaseFileName"];
            if (fileName == null || fileName == "")
            {
                fileName = "RoomManagement.db";
            }
            return Path.Combine(GetDatabaseFolder(), fileName);
        }

        public static string GetConnectionString()
        {
            return "Data Source=" + GetDatabasePath();
        }

        // Opens and returns a new connection to the database.
        // Use it inside "using" so the connection is closed automatically:
        //     using (SqliteConnection conn = DbConnection.GetConnection()) { ... }
        public static SqliteConnection GetConnection()
        {
            SqliteConnection conn = new SqliteConnection(GetConnectionString());
            conn.Open();

            // SQLite checks foreign keys only when this is switched on
            SqliteCommand cmd = new SqliteCommand("PRAGMA foreign_keys = ON;", conn);
            cmd.ExecuteNonQuery();

            return conn;
        }
    }
}
