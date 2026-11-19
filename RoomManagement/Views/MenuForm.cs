using System;
using System.Drawing;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    // The main window. The left side has the menu buttons.
    // When a button is clicked, the matching form is shown inside pnlContent.
    public partial class MenuForm : Form
    {
        private AuthController authController = new AuthController();
        private Form currentForm = null;
        private Button activeButton = null;

        // True when the user clicked Logout (false when the window was closed with X)
        public bool LoggedOut = false;

        public MenuForm()
        {
            InitializeComponent();

            // The view asks the controller who is signed in
            User user = authController.GetCurrentUser();
            lblUserName.Text = user.FullName;
            lblAvatar.Text = user.FullName.Substring(0, 1).ToUpper();
            lblDate.Text = DateTime.Today.ToString("dddd, dd MMMM yyyy");

            // Show only the buttons allowed for this role
            if (authController.IsAdmin())
            {
                lblUserRole.Text = "Administrator";
                btnAvailableRooms.Visible = false;
                btnMyBookings.Visible = false;
            }
            else
            {
                lblUserRole.Text = "User";
                btnDashboard.Visible = false;
                btnAddRoom.Visible = false;
                btnRooms.Visible = false;
                btnBookingRequests.Visible = false;
                btnHolidays.Visible = false;
            }
        }

        // Opens the first page when the window appears
        private void MenuForm_Shown(object sender, EventArgs e)
        {
            if (authController.IsAdmin())
            {
                OpenForm(new DashboardForm(), btnDashboard);
            }
            else
            {
                OpenForm(new AvailableRoomForm(), btnAvailableRooms);
            }
        }

        // Shows a form inside the content panel
        private void OpenForm(Form form, Button button)
        {
            // Close the form that was open before
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
            currentForm = form;

            lblPageTitle.Text = form.Text;

            // The old menu button goes back to white with grey text
            if (activeButton != null)
            {
                activeButton.BackColor = Color.White;
                activeButton.ForeColor = UiTheme.NavText;
                activeButton.FlatAppearance.MouseOverBackColor = UiTheme.NavHover;
                activeButton.Font = new Font("Segoe UI", 10F);
            }

            // The clicked menu button becomes blue with white text
            button.BackColor = UiTheme.Primary;
            button.ForeColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = UiTheme.Primary;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            activeButton = button;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm(), btnDashboard);
        }

        // "Add New Room" opens Manage Rooms with an empty form, ready to type a new room
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            OpenForm(roomForm, btnAddRoom);
            lblPageTitle.Text = "Add New Room";
            roomForm.StartAddMode();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenForm(new RoomForm(), btnRooms);
        }

        private void btnBookingRequests_Click(object sender, EventArgs e)
        {
            OpenForm(new BookingRequestForm(), btnBookingRequests);
        }

        // Used by the Dashboard ("View All" button and the "Cancel Requests" card)
        public void OpenBookingRequests(string statusFilter)
        {
            BookingRequestForm requestForm = new BookingRequestForm();
            requestForm.SetFilter(statusFilter);
            OpenForm(requestForm, btnBookingRequests);
        }

        private void btnHolidays_Click(object sender, EventArgs e)
        {
            OpenForm(new HolidayForm(), btnHolidays);
        }

        private void btnAvailableRooms_Click(object sender, EventArgs e)
        {
            OpenForm(new AvailableRoomForm(), btnAvailableRooms);
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            OpenForm(new MyBookingForm(), btnMyBookings);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changeForm = new ChangePasswordForm();
            changeForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to log out?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                LoggedOut = true;
                this.Close();
            }
        }
    }
}
