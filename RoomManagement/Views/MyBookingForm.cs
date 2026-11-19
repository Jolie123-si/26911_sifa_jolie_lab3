using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    public partial class MyBookingForm : Form
    {
        private BookingController bookingController = new BookingController();

        public MyBookingForm()
        {
            InitializeComponent();
        }

        private void MyBookingForm_Load(object sender, EventArgs e)
        {
            dgvBookings.AutoGenerateColumns = false;   // use only the columns made in the Designer
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                List<Booking> bookings = bookingController.GetMyBookings();
                dgvBookings.DataSource = bookings;
                lblTitle.Text = "My Booking History (" + bookings.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateButtons();
        }

        // Returns the selected booking, or null
        private Booking GetSelectedBooking()
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Booking)dgvBookings.SelectedRows[0].DataBoundItem;
        }

        // Only PENDING and APPROVED bookings can be cancelled, so the button is shown only for them
        private void UpdateButtons()
        {
            Booking booking = GetSelectedBooking();
            if (booking != null && (booking.Status == BookingStatus.PENDING || booking.Status == BookingStatus.APPROVED))
            {
                btnCancelBooking.Visible = true;
            }
            else
            {
                btnCancelBooking.Visible = false;
            }
        }

        // Do not select the first row automatically after loading
        private void dgvBookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBookings.ClearSelection();
            UpdateButtons();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelectedBooking();
            if (booking == null)
            {
                return;
            }

            // The cancel window checks the reason and cancels the booking itself
            CancelReasonForm reasonForm = new CancelReasonForm();
            reasonForm.SetBooking(booking);
            if (reasonForm.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        // Shows the status as colored, friendly text (for example "Cancel Requested")
        private void dgvBookings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colStatus.Index && e.Value != null)
            {
                BookingStatus status = (BookingStatus)e.Value;
                e.CellStyle.ForeColor = UiTheme.GetStatusColor(status);
                e.CellStyle.SelectionForeColor = UiTheme.GetStatusColor(status);
                e.CellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
                e.Value = UiTheme.GetStatusText(status);
                e.FormattingApplied = true;
            }
        }
    }
}
