using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    public partial class RoomForm : Form
    {
        private RoomController roomController = new RoomController();
        private int selectedRoomId = 0;   // 0 means no room is selected

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            dgvRooms.AutoGenerateColumns = false;   // use only the columns made in the Designer

            cmbStatus.Items.Add(RoomStatus.AVAILABLE);
            cmbStatus.Items.Add(RoomStatus.MAINTENANCE);

            LoadRooms();
            ClearForm();
        }

        private void LoadRooms()
        {
            try
            {
                List<Room> rooms = roomController.GetRooms(txtSearch.Text);
                dgvRooms.DataSource = rooms;
                lblCount.Text = rooms.Count + " room(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedRoomId = 0;
            txtRoomName.Clear();
            txtCapacity.Clear();
            cmbLocation.SelectedIndex = -1;
            txtDescription.Clear();
            cmbStatus.SelectedIndex = 0;
            dgvRooms.ClearSelection();
            lblDetailsTitle.Text = "Add New Room";
        }

        // Do not select the first row automatically after loading
        private void dgvRooms_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRooms.ClearSelection();
        }

        // Shows the room status as colored text: green "Available" or orange "Maintenance"
        private void dgvRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colStatus.Index && e.Value != null)
            {
                RoomStatus status = (RoomStatus)e.Value;
                if (status == RoomStatus.AVAILABLE)
                {
                    e.Value = "Available";
                    e.CellStyle.ForeColor = UiTheme.Green;
                }
                else
                {
                    e.Value = "Maintenance";
                    e.CellStyle.ForeColor = UiTheme.Orange;
                }
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                e.CellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
                e.FormattingApplied = true;
            }

            // "Today" column: red "Booked", green "Available"
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

        // Used by the "Add New Room" menu button: empty form, ready to type a new room
        public void StartAddMode()
        {
            ClearForm();
            txtRoomName.Focus();
        }

        // When a row is clicked, show its values in the text boxes
        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                return;
            }

            Room room = (Room)dgvRooms.SelectedRows[0].DataBoundItem;
            selectedRoomId = room.Id;
            lblDetailsTitle.Text = "Edit Room";
            txtRoomName.Text = room.RoomName;
            txtCapacity.Text = room.Capacity.ToString();
            // Old rooms may have a location that is not in the list: add it so it can be shown
            if (!cmbLocation.Items.Contains(room.Location))
            {
                cmbLocation.Items.Add(room.Location);
            }
            cmbLocation.SelectedItem = room.Location;
            txtDescription.Text = room.Description;
            cmbStatus.SelectedItem = room.Status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RoomStatus status = (RoomStatus)cmbStatus.SelectedItem;
                roomController.AddRoom(txtRoomName.Text, txtCapacity.Text, cmbLocation.Text, txtDescription.Text, status);
                MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == 0)
            {
                MessageBox.Show("Please select a room in the list first.", "Select a room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                RoomStatus status = (RoomStatus)cmbStatus.SelectedItem;
                roomController.UpdateRoom(selectedRoomId, txtRoomName.Text, txtCapacity.Text, cmbLocation.Text, txtDescription.Text, status);
                MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == 0)
            {
                MessageBox.Show("Please select a room in the list first.", "Select a room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Show the room details before deleting
            DialogResult answer = MessageBox.Show(
                "This room will be removed from the list.\n\n" +
                "Room: " + txtRoomName.Text + "\n" +
                "Location: " + cmbLocation.Text + "\n" +
                "Capacity: " + txtCapacity.Text + " people\n\n" +
                "All bookings for this room will also be deleted. Continue?",
                "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                roomController.DeleteRoom(selectedRoomId);
                LoadRooms();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }

        // Pressing Enter in the search box also searches
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadRooms();
            }
        }
    }
}
