using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using RoomManagement.Data;
using RoomManagement.Models;

namespace RoomManagement.Repositories
{
    // All SQL for the Bookings table
    public class BookingRepository
    {
        // Every query joins Users and Rooms so we also get the user name and room name
        private string selectSql =
            "SELECT b.*, u.FullName AS UserFullName, r.RoomName, a.FullName AS ApprovedByName " +
            "FROM Bookings b " +
            "JOIN Users u ON u.Id = b.UserId " +
            "JOIN Rooms r ON r.Id = b.RoomId " +
            "LEFT JOIN Users a ON a.Id = b.ApprovedBy ";

        public List<Booking> GetAll()
        {
            SqliteCommand cmd = new SqliteCommand(selectSql + "ORDER BY b.CreatedAt DESC, b.Id DESC");
            return GetList(cmd);
        }

        public List<Booking> GetByStatus(BookingStatus status)
        {
            SqliteCommand cmd = new SqliteCommand(selectSql + "WHERE b.Status = @Status ORDER BY b.CreatedAt DESC, b.Id DESC");
            cmd.Parameters.AddWithValue("@Status", status.ToString());
            return GetList(cmd);
        }

        public List<Booking> GetByUser(int userId)
        {
            SqliteCommand cmd = new SqliteCommand(selectSql + "WHERE b.UserId = @UserId ORDER BY b.CreatedAt DESC, b.Id DESC");
            cmd.Parameters.AddWithValue("@UserId", userId);
            return GetList(cmd);
        }

        // Returns the booking or null if not found
        public Booking GetById(int id)
        {
            SqliteCommand cmd = new SqliteCommand(selectSql + "WHERE b.Id = @Id");
            cmd.Parameters.AddWithValue("@Id", id);
            List<Booking> list = GetList(cmd);
            if (list.Count == 0)
            {
                return null;
            }
            return list[0];
        }

        // Active bookings (PENDING, APPROVED, CANCEL_REQUESTED) that touch the given dates.
        // These bookings keep the room busy.
        public List<Booking> GetActiveBetween(DateTime startDate, DateTime endDate)
        {
            string sql = selectSql +
                "WHERE b.Status IN ('PENDING', 'APPROVED', 'CANCEL_REQUESTED') " +
                "AND b.StartDate <= @EndDate AND b.EndDate >= @StartDate";
            SqliteCommand cmd = new SqliteCommand(sql);
            cmd.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd"));
            return GetList(cmd);
        }

        // Approved bookings that include the given day
        public List<Booking> GetApprovedOnDate(DateTime date)
        {
            string sql = selectSql +
                "WHERE b.Status = 'APPROVED' AND b.StartDate <= @Date AND b.EndDate >= @Date " +
                "ORDER BY b.StartTime";
            SqliteCommand cmd = new SqliteCommand(sql);
            cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
            return GetList(cmd);
        }

        // Number of bookings with a given status
        public int CountByStatus(BookingStatus status)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT COUNT(*) FROM Bookings WHERE Status = @Status", conn);
                cmd.Parameters.AddWithValue("@Status", status.ToString());
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Number of bookings that start on the given day
        public int CountStartingOn(DateTime date)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT COUNT(*) FROM Bookings WHERE StartDate = @Date", conn);
                cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Number of bookings that start after the given day
        public int CountStartingAfter(DateTime date)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT COUNT(*) FROM Bookings WHERE StartDate > @Date", conn);
                cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Add(Booking booking)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "INSERT INTO Bookings (UserId, RoomId, Purpose, StartDate, EndDate, StartTime, EndTime, Status) " +
                             "VALUES (@UserId, @RoomId, @Purpose, @StartDate, @EndDate, @StartTime, @EndTime, @Status)";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserId", booking.UserId);
                cmd.Parameters.AddWithValue("@RoomId", booking.RoomId);
                cmd.Parameters.AddWithValue("@Purpose", booking.Purpose);
                cmd.Parameters.AddWithValue("@StartDate", booking.StartDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@EndDate", booking.EndDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@StartTime", booking.StartTime.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@EndTime", booking.EndTime.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@Status", booking.Status.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        // Used when an admin approves / rejects. Saves who did it and when.
        public void UpdateStatusByAdmin(int bookingId, BookingStatus status, int adminId)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "UPDATE Bookings SET Status = @Status, ApprovedBy = @AdminId, ApprovedAt = datetime('now','localtime') WHERE Id = @Id";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", status.ToString());
                cmd.Parameters.AddWithValue("@AdminId", adminId);
                cmd.Parameters.AddWithValue("@Id", bookingId);
                cmd.ExecuteNonQuery();
            }
        }

        // Used when a user cancels. Saves the reason.
        public void UpdateStatusWithReason(int bookingId, BookingStatus status, string reason)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                string sql = "UPDATE Bookings SET Status = @Status, CancelReason = @Reason WHERE Id = @Id";
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", status.ToString());
                cmd.Parameters.AddWithValue("@Reason", reason);
                cmd.Parameters.AddWithValue("@Id", bookingId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("DELETE FROM Bookings WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Runs a SELECT command and returns the bookings
        private List<Booking> GetList(SqliteCommand cmd)
        {
            List<Booking> bookings = new List<Booking>();

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                cmd.Connection = conn;
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookings.Add(ReadBooking(reader));
                }
            }
            return bookings;
        }

        // Converts the current row of the reader into a Booking object
        private Booking ReadBooking(SqliteDataReader reader)
        {
            Booking booking = new Booking();
            booking.Id = Convert.ToInt32(reader["Id"]);
            booking.UserId = Convert.ToInt32(reader["UserId"]);
            booking.RoomId = Convert.ToInt32(reader["RoomId"]);
            booking.Purpose = reader["Purpose"].ToString();
            booking.CancelReason = reader["CancelReason"].ToString();
            booking.StartDate = Convert.ToDateTime(reader["StartDate"]);
            booking.EndDate = Convert.ToDateTime(reader["EndDate"]);
            booking.StartTime = TimeSpan.Parse(reader["StartTime"].ToString());
            booking.EndTime = TimeSpan.Parse(reader["EndTime"].ToString());
            booking.Status = (BookingStatus)Enum.Parse(typeof(BookingStatus), reader["Status"].ToString());
            booking.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
            booking.UserFullName = reader["UserFullName"].ToString();
            booking.RoomName = reader["RoomName"].ToString();
            booking.ApprovedByName = reader["ApprovedByName"].ToString();

            // These two columns can be NULL in the database
            if (reader["ApprovedBy"] != DBNull.Value)
            {
                booking.ApprovedById = Convert.ToInt32(reader["ApprovedBy"]);
            }
            if (reader["ApprovedAt"] != DBNull.Value)
            {
                booking.ApprovedAt = Convert.ToDateTime(reader["ApprovedAt"]);
            }
            return booking;
        }
    }
}
