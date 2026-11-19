using System;
using System.Drawing;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    public partial class DashboardForm : Form
    {
        private DashboardController dashboardController = new DashboardController();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            dgvRecent.AutoGenerateColumns = false;   // use only the columns made in the Designer
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DashboardStats stats = dashboardController.GetStats();

                // Put the numbers in the cards made in the Designer
                lblTotalRooms.Text = stats.TotalRooms.ToString();
                lblAvailableRooms.Text = stats.AvailableRooms.ToString();
                lblPending.Text = stats.PendingBookings.ToString();
                lblApproved.Text = stats.ApprovedBookings.ToString();
                lblRejected.Text = stats.RejectedBookings.ToString();
                lblCancelRequests.Text = stats.CancelRequestedBookings.ToString();
                lblStartingToday.Text = stats.TodayBookings.ToString();
                lblUpcoming.Text = stats.UpcomingBookings.ToString();

                LoadRecentBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentBookings()
        {
            dgvRecent.DataSource = dashboardController.GetRecentBookings(txtSearch.Text);
        }

        // Do not select the first row automatically after loading
        private void dgvRecent_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRecent.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // "View All" opens the Booking Requests page
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = (MenuForm)this.ParentForm;
            menuForm.OpenBookingRequests("ALL");
        }

        // Clicking the "Cancel Requests" card opens Booking Requests showing only cancel requests
        private void cardCancelRequests_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = (MenuForm)this.ParentForm;
            menuForm.OpenBookingRequests("CANCEL_REQUESTED");
        }

        // Search while typing
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadRecentBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Shows the status as colored, friendly text (for example "Cancel Requested")
        private void dgvRecent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
