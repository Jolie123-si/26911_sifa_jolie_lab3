using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using RoomManagement.Data;
using RoomManagement.Models;

namespace RoomManagement.Repositories
{
    // All SQL for the Rooms table
    public class RoomRepository
    {
        public List<Room> GetAll()
        {
            List<Room> rooms = new List<Room>();

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT * FROM Rooms ORDER BY RoomName", conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(ReadRoom(reader));
                }
            }
            return rooms;
        }

        // Finds rooms whose name, location or description contains the keyword
        public List<Room> Search(string keyword)
        {
            List<Room> rooms = new List<Room>();

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "SELECT * FROM Rooms " +
                             "WHERE RoomName LIKE @Keyword OR Location LIKE @Keyword OR Description LIKE @Keyword " +
                             "ORDER BY RoomName";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(ReadRoom(reader));
                }
            }
            return rooms;
        }

        // Returns the room or null if not found
        public Room GetById(int id)
        {
            Room room = null;

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT * FROM Rooms WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqliteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    room = ReadRoom(reader);
                }
            }
            return room;
        }

        // True if another room already has this name (the room with id "excludeId" is ignored)
        public bool NameExists(string roomName, int excludeId)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT COUNT(*) FROM Rooms WHERE RoomName = @RoomName AND Id <> @Id", conn);
                cmd.Parameters.AddWithValue("@RoomName", roomName);
                cmd.Parameters.AddWithValue("@Id", excludeId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public int Count()
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT COUNT(*) FROM Rooms", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Add(Room room)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "INSERT INTO Rooms (RoomName, Capacity, Location, Description, Status) " +
                             "VALUES (@RoomName, @Capacity, @Location, @Description, @Status)";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                cmd.Parameters.AddWithValue("@Location", room.Location);
                cmd.Parameters.AddWithValue("@Description", room.Description);
                cmd.Parameters.AddWithValue("@Status", room.Status.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Room room)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "UPDATE Rooms SET RoomName = @RoomName, Capacity = @Capacity, Location = @Location, " +
                             "Description = @Description, Status = @Status WHERE Id = @Id";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                cmd.Parameters.AddWithValue("@Location", room.Location);
                cmd.Parameters.AddWithValue("@Description", room.Description);
                cmd.Parameters.AddWithValue("@Status", room.Status.ToString());
                cmd.Parameters.AddWithValue("@Id", room.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Deletes the room. Its bookings are deleted automatically (ON DELETE CASCADE).
        public void Delete(int id)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("DELETE FROM Rooms WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Converts the current row of the reader into a Room object
        private Room ReadRoom(SqliteDataReader reader)
        {
            Room room = new Room();
            room.Id = Convert.ToInt32(reader["Id"]);
            room.RoomName = reader["RoomName"].ToString();
            room.Capacity = Convert.ToInt32(reader["Capacity"]);
            room.Location = reader["Location"].ToString();
            room.Description = reader["Description"].ToString();   // NULL becomes ""
            room.Status = (RoomStatus)Enum.Parse(typeof(RoomStatus), reader["Status"].ToString());
            return room;
        }
    }
}
