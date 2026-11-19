using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    // Admin page with two parts:
    //  1. "Cancellation Requests" - users who want to cancel an approved booking
    //  2. "All Booking Status"    - every booking, with filter, search and sort
    public partial class BookingRequestForm : Form
    {
        private BookingController bookingController = new BookingController();

        // The status codes that match the items of cmbFilter (same order)
        private string[] filterCodes = { "ALL", "PENDING", "APPROVED", "REJECTED", "CANCEL_REQUESTED", "CANCELLED" };
        private string startFilter = "ALL";
        private bool loading = true;   // true while the form is filling its boxes

        // FR-10.5: the list shows 10 bookings per page
        private const int PageSize = 10;
        private int currentPage = 1;

        public BookingRequestForm()
        {
            InitializeComponent();
        }

        // Lets the Dashboard open this page already filtered (for example "CANCEL_REQUESTED")
        public void SetFilter(string statusCode)
        {
            startFilter = statusCode;
        }

        private void BookingRequestForm_Load(object sender, EventArgs e)
        {
            dgvCancel.AutoGenerateColumns = false;     // use only the columns made in the Designer
            dgvBookings.AutoGenerateColumns = false;

            cmbFilter.SelectedIndex = Array.IndexOf(filterCodes, startFilter);
            cmbSort.SelectedIndex = 0;   // Newest first
            loading = false;

            LoadAll();
        }

        private void LoadAll()
        {
            LoadCancelRequests();
            LoadBookings();
        }

        private void LoadCancelRequests()
        {
            try
            {
                List<Booking> requests = bookingController.GetCancelRequests();
                dgvCancel.DataSource = requests;
                lblCancelTitle.Text = "Cancellation Requests (" + requests.Count + ")";
                lblNeedsAction.Visible = requests.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookings()
        {
            if (loading)
            {
                return;
            }

            try
            {
                string filter = filterCodes[cmbFilter.SelectedIndex];
                bool newestFirst = cmbSort.SelectedIndex == 0;
                List<Booking> bookings = bookingController.GetBookings(filter, txtSearch.Text, newestFirst);
                lblAllTitle.Text = "All Booking Status (" + bookings.Count + ")";

                // How many pages? (at least 1)
                int pageCount = (bookings.Count + PageSize - 1) / PageSize;
                if (pageCount < 1)
                {
                    pageCount = 1;
                }
                if (currentPage > pageCount)
                {
                    currentPage = pageCount;
                }

                // Take only the 10 bookings of the current page
                List<Booking> pageBookings = new List<Booking>();
                int first = (currentPage - 1) * PageSize;
                for (int i = first; i < first + PageSize && i < bookings.Count; i++)
                {
                    pageBookings.Add(bookings[i]);
                }

                dgvBookings.DataSource = pageBookings;
                lblPage.Text = "Page " + currentPage + " of " + pageCount;
                btnPrevious.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < pageCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Returns the selected booking of a grid, or null
        private Booking GetSelected(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Booking)grid.SelectedRows[0].DataBoundItem;
        }

        // Shows only the buttons that make sense for the selected bookings
        private void UpdateButtons()
        {
            Booking cancelRequest = GetSelected(dgvCancel);
            btnApproveCancel.Visible = cancelRequest != null;
            btnRejectCancel.Visible = cancelRequest != null;

            Booking booking = GetSelected(dgvBookings);
            btnDelete.Visible = booking != null;
            btnApprove.Visible = booking != null && booking.Status == BookingStatus.PENDING;
            btnReject.Visible = booking != null && booking.Status == BookingStatus.PENDING;
        }

        // Asks a Yes/No question
        private bool Confirm(string question)
        {
            DialogResult answer = MessageBox.Show(question, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer == DialogResult.Yes;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelected(dgvBookings);
            if (booking == null)
            {
                return;
            }

            try
            {
                bookingController.ApproveBooking(booking.Id);
                MessageBox.Show("Booking approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelected(dgvBookings);
            if (booking == null || !Confirm("Reject this booking request?"))
            {
                return;
            }

            try
            {
                bookingController.RejectBooking(booking.Id);
                MessageBox.Show("Booking rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnApproveCancel_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelected(dgvCancel);
            if (booking == null || !Confirm("Approve the cancellation? The room will be free again."))
            {
                return;
            }

            try
            {
                bookingController.ApproveCancel(booking.Id);
                MessageBox.Show("Booking cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRejectCancel_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelected(dgvCancel);
            if (booking == null || !Confirm("Reject the cancellation? The booking stays approved."))
            {
                return;
            }

            try
            {
                bookingController.RejectCancel(booking.Id);
                MessageBox.Show("Cancellation request rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelected(dgvBookings);
            if (booking == null || !Confirm("Permanently delete this booking?"))
            {
                return;
            }

            try
            {
                bookingController.DeleteBooking(booking.Id);
                LoadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // A new filter, sort or search starts again at page 1
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadBookings();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadBookings();
        }

        // Search while typing
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadBookings();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadBookings();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;   // LoadBookings stops at the last page
            LoadBookings();
        }

        // Do not select the first row automatically after loading
        private void dgvCancel_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCancel.ClearSelection();
            UpdateButtons();
        }

        private void dgvBookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBookings.ClearSelection();
            UpdateButtons();
        }

        private void dgvCancel_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtons();
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
