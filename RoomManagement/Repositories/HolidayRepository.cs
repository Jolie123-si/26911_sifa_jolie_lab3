using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using RoomManagement.Data;
using RoomManagement.Models;

namespace RoomManagement.Repositories
{
    // All SQL for the Holidays table
    public class HolidayRepository
    {
        public List<Holiday> GetAll()
        {
            List<Holiday> holidays = new List<Holiday>();

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT * FROM Holidays ORDER BY HolidayDate", conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    holidays.Add(ReadHoliday(reader));
                }
            }
            return holidays;
        }

        public List<Holiday> GetByYear(int year)
        {
            List<Holiday> holidays = new List<Holiday>();

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT * FROM Holidays WHERE strftime('%Y', HolidayDate) = @Year ORDER BY HolidayDate", conn);
                cmd.Parameters.AddWithValue("@Year", year.ToString());
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    holidays.Add(ReadHoliday(reader));
                }
            }
            return holidays;
        }

        // Returns the holiday on this date, or null
        public Holiday GetByDate(DateTime date)
        {
            Holiday holiday = null;

            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT * FROM Holidays WHERE HolidayDate = @Date", conn);
                cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                SqliteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    holiday = ReadHoliday(reader);
                }
            }
            return holiday;
        }

        // True if another holiday is already on this date (the holiday with id "excludeId" is ignored)
        public bool DateExists(DateTime date, int excludeId)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("SELECT COUNT(*) FROM Holidays WHERE HolidayDate = @Date AND Id <> @Id", conn);
                cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Id", excludeId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void Add(Holiday holiday)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("INSERT INTO Holidays (HolidayDate, Name) VALUES (@Date, @Name)", conn);
                cmd.Parameters.AddWithValue("@Date", holiday.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Name", holiday.Name);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Holiday holiday)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("UPDATE Holidays SET HolidayDate = @Date, Name = @Name WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Date", holiday.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Name", holiday.Name);
                cmd.Parameters.AddWithValue("@Id", holiday.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqliteConnection conn = DbConnection.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("DELETE FROM Holidays WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Converts the current row of the reader into a Holiday object
        private Holiday ReadHoliday(SqliteDataReader reader)
        {
            Holiday holiday = new Holiday();
            holiday.Id = Convert.ToInt32(reader["Id"]);
            holiday.Date = Convert.ToDateTime(reader["HolidayDate"]);
            holiday.Name = reader["Name"].ToString();
            return holiday;
        }
    }
}
