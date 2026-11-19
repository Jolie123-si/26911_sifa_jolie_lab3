using System;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    // The "Cancel Booking" / "Request Cancellation" window.
    // A pending booking is cancelled at once; an approved booking needs the admin to confirm.
    public partial class CancelReasonForm : Form
    {
        private BookingController bookingController = new BookingController();
        private Booking booking;

        public CancelReasonForm()
        {
            InitializeComponent();
        }

        // The booking that will be cancelled
        public void SetBooking(Booking bookingToCancel)
        {
            booking = bookingToCancel;
            lblInfo.Text = "Room: " + booking.RoomName + "\r\n" +
                           "Purpose: " + booking.Purpose + "\r\n" +
                           "When: " + booking.DateAndTime;

            if (booking.Status == BookingStatus.APPROVED)
            {
                lblTitle.Text = "Request Cancellation";
                this.Text = "Request Cancellation";
                btnConfirm.Text = "Send Request";
                lblNote.Visible = true;
            }
            else
            {
                lblTitle.Text = "Cancel Booking";
                this.Text = "Cancel Booking";
                btnConfirm.Text = "Cancel Booking";
                lblNote.Visible = false;
            }
        }

        // Shows how many words are left (the reason can have at most 10 words)
        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            int wordsLeft = 10 - BookingController.CountWords(txtReason.Text);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bookingController.CancelBooking(booking.Id, txtReason.Text);

                if (booking.Status == BookingStatus.APPROVED)
                {
                    MessageBox.Show("Cancellation requested. Waiting for admin to approve.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Booking cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
