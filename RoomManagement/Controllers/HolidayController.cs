using System;
using System.Collections.Generic;
using RoomManagement.Models;
using RoomManagement.Services;

namespace RoomManagement.Controllers
{
    // Controller for public holidays.
    // The forms call this controller; the controller passes the request to HolidayService.
    public class HolidayController
    {
        private HolidayService holidayService = new HolidayService();

        public List<Holiday> GetHolidays(int year)
        {
            return holidayService.GetHolidays(year);
        }

        public void AddHoliday(DateTime date, string name)
        {
            holidayService.AddHoliday(date, name);
        }

        public void UpdateHoliday(int id, DateTime date, string name)
        {
            holidayService.UpdateHoliday(id, date, name);
        }

        public void DeleteHoliday(int id)
        {
            holidayService.DeleteHoliday(id);
        }
    }
}
