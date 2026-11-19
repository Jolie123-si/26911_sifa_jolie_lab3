using System;
using System.Windows.Forms;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    // The "Room Details" window.
    // "Book This Room" closes the window with DialogResult.Yes.
    public partial class RoomDetailsForm : Form
    {
        public RoomDetailsForm()
        {
            InitializeComponent();
        }

        public void SetRoom(Room room)
        {
            lblName.Text = room.RoomName;
            lblCapacity.Text = room.Capacity + " people";
            lblLocation.Text = room.Location;
            lblAvailability.Text = room.Availability;

            if (room.Description == "")
            {
                lblDescription.Text = "-";
            }
            else
            {
                lblDescription.Text = room.Description;
            }

            if (room.Availability == "Booked")
            {
                lblAvailability.ForeColor = UiTheme.Red;
            }
            else if (room.Availability == "Available")
            {
                lblAvailability.ForeColor = UiTheme.Green;
            }
            else
            {
                lblAvailability.ForeColor = UiTheme.Orange;
            }
        }
    }
}
