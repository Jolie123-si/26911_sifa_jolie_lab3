using System;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    // The "Book Room" window
    public partial class BookRoomForm : Form
    {
        private BookingController bookingController = new BookingController();
        private Room room;

        public BookRoomForm()
        {
            InitializeComponent();
        }

        // The room that will be booked
        public void SetRoom(Room roomToBook)
        {
            room = roomToBook;
            lblRoomInfo.Text = "Room: " + room.RoomName + "\r\n" +
                               "Location: " + room.Location + "\r\n" +
                               "Capacity: " + room.Capacity + " people";
        }

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            // Default: the next working day, from 09:00 to 10:00
            DateTime day = DateTime.Today.AddDays(1);
            while (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                day = day.AddDays(1);
            }

            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;
            dtpStartDate.Value = day;
            dtpEndDate.Value = day;
            dtpStartTime.Value = DateTime.Today.AddHours(9);
            dtpEndTime.Value = DateTime.Today.AddHours(10);
        }

        // The end date cannot be before the start date
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                dtpEndDate.Value = dtpStartDate.Value.Date;
            }
        }

        // Shows how many words are left (the purpose can have at most 10 words)
        private void txtPurpose_TextChanged(object sender, EventArgs e)
        {
            int wordsLeft = 10 - BookingController.CountWords(txtPurpose.Text);
            if (wordsLeft >= 0)
            {
                lblWords.Text = wordsLeft + " words left";
                lblWords.ForeColor = UiTheme.Grey;
            }
            else
            {
                lblWords.Text = "Too many words: remove " + (-wordsLeft);
                lblWords.ForeColor = UiTheme.Red;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            // Keep only hours and minutes
            TimeSpan startTime = new TimeSpan(dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
            TimeSpan endTime = new TimeSpan(dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, 0);

            // Warning when the meeting is outside working hours (08:00 - 17:00)
            if (BookingController.IsOutsideWorkingHours(startTime, endTime))
            {
                DialogResult answer = MessageBox.Show(
                    "You are booking outside working hours (before 8:00 AM or after 5:00 PM).\n" +
                    "Bookings are recommended between 08:00 - 17:00.\n\n" +
                    "Do you want to book anyway?",
                    "Outside working hours", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes)
                {
                    return;   // "No" = change the time
                }
            }

            try
            {
                bookingController.CreateBooking(room.Id, txtPurpose.Text, startDate, endDate, startTime, endTime);
                MessageBox.Show("Booking submitted! Waiting for admin approval.\nYou can follow it in \"My Bookings\".",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Booking failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
