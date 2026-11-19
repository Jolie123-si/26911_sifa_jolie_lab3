using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    // List of all rooms with a "Book" and a "View Details" button on each row
    public partial class AvailableRoomForm : Form
    {
        private RoomController roomController = new RoomController();

        public AvailableRoomForm()
        {
            InitializeComponent();
        }

        private void AvailableRoomForm_Load(object sender, EventArgs e)
        {
            dgvRooms.AutoGenerateColumns = false;   // use only the columns made in the Designer
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                List<Room> rooms = roomController.GetRooms("");
                dgvRooms.DataSource = rooms;
                lblTitle.Text = "Available Rooms (" + rooms.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Do not select the first row automatically after loading
        private void dgvRooms_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRooms.ClearSelection();
        }

        // A "Book" or "View Details" button in the table was clicked
        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;   // the header was clicked
            }

            Room room = (Room)dgvRooms.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == colBook.Index)
            {
                OpenBooking(room);
            }
            else if (e.ColumnIndex == colDetails.Index)
            {
                RoomDetailsForm detailsForm = new RoomDetailsForm();
                detailsForm.SetRoom(room);
                // "Book This Room" in the details window returns Yes
                if (detailsForm.ShowDialog() == DialogResult.Yes)
                {
                    OpenBooking(room);
                }
            }
        }

        // Opens the booking window for one room
        private void OpenBooking(Room room)
        {
            if (room.Status == RoomStatus.MAINTENANCE)
            {
                MessageBox.Show("This room is under maintenance and cannot be booked.", "Book Room",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BookRoomForm bookForm = new BookRoomForm();
            bookForm.SetRoom(room);
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                LoadRooms();
            }
        }

        // Availability column: red "Booked", green "Available", orange "Maintenance"
        private void dgvRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colAvailability.Index && e.Value != null)
            {
                string text = e.Value.ToString();
                if (text == "Booked")
                {
                    e.CellStyle.ForeColor = UiTheme.Red;
                }
                else if (text == "Available")
                {
                    e.CellStyle.ForeColor = UiTheme.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = UiTheme.Orange;
                }
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                e.CellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            }
        }
    }
}
