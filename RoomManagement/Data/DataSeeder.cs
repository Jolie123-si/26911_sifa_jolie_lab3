using System;
using RoomManagement.Models;
using RoomManagement.Repositories;

namespace RoomManagement.Data
{
    // Inserts the default admin and the Rwanda public holidays the first time the app runs
    public class DataSeeder
    {
        public static void Seed()
        {
            SeedAdmin();
            SeedHolidays();
        }

        private static void SeedAdmin()
        {
            UserRepository userRepository = new UserRepository();

            // Only create the admin if it does not exist yet
            if (userRepository.GetByEmail("admin@rra.gov.rw") == null)
            {
                User admin = new User();
                admin.FullName = "RRA Administrator";
                admin.Email = "admin@rra.gov.rw";
                admin.PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@1234");
                admin.Role = UserRole.ADMIN;
                admin.PasswordChanged = true;
                userRepository.Add(admin);
            }
        }

        private static void SeedHolidays()
        {
            // 2025
            AddHoliday(2025, 1, 1, "New Year's Day");
            AddHoliday(2025, 1, 2, "Day after New Year's Day");
            AddHoliday(2025, 2, 1, "National Heroes' Day");
            AddHoliday(2025, 3, 31, "Eid al-Fitr");
            AddHoliday(2025, 4, 7, "Genocide perpetrated against the Tutsi Memorial Day");
            AddHoliday(2025, 4, 18, "Good Friday");
            AddHoliday(2025, 4, 21, "Easter Monday");
            AddHoliday(2025, 5, 1, "Labour Day");
            AddHoliday(2025, 6, 7, "Eid al-Adha");
            AddHoliday(2025, 7, 1, "Independence Day");
            AddHoliday(2025, 7, 4, "Liberation Day");
            AddHoliday(2025, 8, 1, "Umuganura Day");
            AddHoliday(2025, 8, 15, "Assumption Day");
            AddHoliday(2025, 12, 25, "Christmas Day");
            AddHoliday(2025, 12, 26, "Boxing Day");

            // 2026
            AddHoliday(2026, 1, 1, "New Year's Day");
            AddHoliday(2026, 1, 2, "Day after New Year's Day");
            AddHoliday(2026, 2, 1, "National Heroes' Day");
            AddHoliday(2026, 3, 20, "Eid al-Fitr");
            AddHoliday(2026, 4, 3, "Good Friday");
            AddHoliday(2026, 4, 6, "Easter Monday");
            AddHoliday(2026, 4, 7, "Genocide perpetrated against the Tutsi Memorial Day");
            AddHoliday(2026, 5, 1, "Labour Day");
            AddHoliday(2026, 5, 27, "Eid al-Adha");
            AddHoliday(2026, 7, 1, "Independence Day");
            AddHoliday(2026, 7, 4, "Liberation Day");
            AddHoliday(2026, 8, 7, "Umuganura Day");
            AddHoliday(2026, 8, 15, "Assumption Day");
            AddHoliday(2026, 12, 25, "Christmas Day");
            AddHoliday(2026, 12, 26, "Boxing Day");

            // 2027
            AddHoliday(2027, 1, 1, "New Year's Day");
            AddHoliday(2027, 1, 2, "Day after New Year's Day");
            AddHoliday(2027, 2, 1, "National Heroes' Day");
            AddHoliday(2027, 3, 10, "Eid al-Fitr");
            AddHoliday(2027, 3, 26, "Good Friday");
            AddHoliday(2027, 3, 29, "Easter Monday");
            AddHoliday(2027, 4, 7, "Genocide perpetrated against the Tutsi Memorial Day");
            AddHoliday(2027, 5, 1, "Labour Day");
            AddHoliday(2027, 5, 16, "Eid al-Adha");
            AddHoliday(2027, 7, 1, "Independence Day");
            AddHoliday(2027, 7, 4, "Liberation Day");
            AddHoliday(2027, 8, 6, "Umuganura Day");
            AddHoliday(2027, 8, 15, "Assumption Day");
            AddHoliday(2027, 12, 25, "Christmas Day");
            AddHoliday(2027, 12, 26, "Boxing Day");
        }

        // Adds one holiday if that date is not already in the table
        private static void AddHoliday(int year, int month, int day, string name)
        {
            HolidayRepository holidayRepository = new HolidayRepository();
            DateTime date = new DateTime(year, month, day);

            if (holidayRepository.GetByDate(date) == null)
            {
                Holiday holiday = new Holiday();
                holiday.Date = date;
                holiday.Name = name;
                holidayRepository.Add(holiday);
            }
        }
    }
}
