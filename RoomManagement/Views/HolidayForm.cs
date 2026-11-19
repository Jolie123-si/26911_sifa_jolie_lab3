using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    public partial class HolidayForm : Form
    {
        private HolidayController holidayController = new HolidayController();
        private int selectedHolidayId = 0;   // 0 means no holiday is selected

        public HolidayForm()
        {
            InitializeComponent();
        }

        private void HolidayForm_Load(object sender, EventArgs e)
        {
            dgvHolidays.AutoGenerateColumns = false;   // use only the columns made in the Designer

            // FR-9.2: the year is locked to the current year, so the calendar only shows this year
            dtpDate.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
            dtpDate.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
            lblDate.Text = "Day and month * (year " + DateTime.Today.Year + ", locked)";

            // Year filter: "All years", last year, this year and the next 2 years
            cmbYear.Items.Add("All years");
            int thisYear = DateTime.Today.Year;
            for (int year = thisYear - 1; year <= thisYear + 2; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }
            cmbYear.SelectedItem = thisYear.ToString();   // this also loads the holidays

            ClearForm();
        }

        private void LoadHolidays()
        {
            try
            {
                int year = 0;   // 0 = all years
                if (cmbYear.SelectedItem.ToString() != "All years")
                {
                    year = int.Parse(cmbYear.SelectedItem.ToString());
                }

                List<Holiday> holidays = holidayController.GetHolidays(year);
                dgvHolidays.DataSource = holidays;
                lblCount.Text = holidays.Count + " holiday(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedHolidayId = 0;
            dtpDate.Value = DateTime.Today;
            txtName.Clear();
            dgvHolidays.ClearSelection();
        }

        private void dgvHolidays_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvHolidays.ClearSelection();
        }

        private void dgvHolidays_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHolidays.SelectedRows.Count == 0)
            {
                return;
            }

            Holiday holiday = (Holiday)dgvHolidays.SelectedRows[0].DataBoundItem;
            selectedHolidayId = holiday.Id;
            txtName.Text = holiday.Name;

            // The calendar only accepts dates of this year
            if (holiday.Date.Year == DateTime.Today.Year)
            {
                dtpDate.Value = holiday.Date;
            }
        }

        // Shows the day name (Monday, Tuesday...) in the "Day" column
        private void dgvHolidays_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colDay.Index && e.Value != null)
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.DayOfWeek.ToString();
                e.FormattingApplied = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                holidayController.AddHoliday(dtpDate.Value, txtName.Text);
                MessageBox.Show("Holiday added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHolidays();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedHolidayId == 0)
            {
                MessageBox.Show("Please select a holiday in the list first.", "Select a holiday", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Holidays of other years can be deleted, but not edited (the year is locked)
            Holiday selected = (Holiday)dgvHolidays.SelectedRows[0].DataBoundItem;
            if (selected.Date.Year != DateTime.Today.Year)
            {
                MessageBox.Show("Only holidays of " + DateTime.Today.Year + " can be edited.", "Year locked",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                holidayController.UpdateHoliday(selectedHolidayId, dtpDate.Value, txtName.Text);
                MessageBox.Show("Holiday updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHolidays();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedHolidayId == 0)
            {
                MessageBox.Show("Please select a holiday in the list first.", "Select a holiday", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show("Delete holiday \"" + txtName.Text + "\"?", "Delete holiday",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                holidayController.DeleteHoliday(selectedHolidayId);
                LoadHolidays();
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

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHolidays();
        }
    }
}
