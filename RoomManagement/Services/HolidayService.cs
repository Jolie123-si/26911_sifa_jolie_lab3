using System;
using System.Collections.Generic;
using RoomManagement.Repositories;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Services
{
    // Add, edit, delete and list public holidays
    public class HolidayService
    {
        private HolidayRepository holidayRepository = new HolidayRepository();

        // year = 0 means all years
        public List<Holiday> GetHolidays(int year)
        {
            if (year == 0)
            {
                return holidayRepository.GetAll();
            }
            return holidayRepository.GetByYear(year);
        }

        public void AddHoliday(DateTime date, string name)
        {
            Session.CheckAdmin();
            CheckName(name);
            CheckYear(date);

            if (holidayRepository.DateExists(date, 0))
            {
                throw new Exception("A holiday already exists for this date.");
            }

            Holiday holiday = new Holiday();
            holiday.Date = date.Date;
            holiday.Name = name.Trim();
            holidayRepository.Add(holiday);
        }

        public void UpdateHoliday(int id, DateTime date, string name)
        {
            Session.CheckAdmin();
            CheckName(name);
            CheckYear(date);

            if (holidayRepository.DateExists(date, id))
            {
                throw new Exception("A holiday already exists for this date.");
            }

            Holiday holiday = new Holiday();
            holiday.Id = id;
            holiday.Date = date.Date;
            holiday.Name = name.Trim();
            holidayRepository.Update(holiday);
        }

        public void DeleteHoliday(int id)
        {
            Session.CheckAdmin();
            holidayRepository.Delete(id);
        }

        private void CheckName(string name)
        {
            if (name.Trim() == "")
            {
                throw new Exception("Holiday name is required.");
            }
        }

        // FR-9.2: the year of a public holiday is locked to the current year
        private void CheckYear(DateTime date)
        {
            if (date.Year != DateTime.Today.Year)
            {
                throw new Exception("A public holiday must be in the current year (" + DateTime.Today.Year + ").");
            }
        }
    }
}
