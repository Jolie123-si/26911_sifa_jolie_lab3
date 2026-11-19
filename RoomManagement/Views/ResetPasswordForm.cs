using System;
using System.Windows.Forms;
using RoomManagement.Controllers;

namespace RoomManagement.Views
{
    // Step 2 of resetting a forgotten password: type the reset code and the new password
    public partial class ResetPasswordForm : Form
    {
        private AuthController authController = new AuthController();

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        public void SetEmail(string email)
        {
            txtEmail.Text = email;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                authController.ResetPassword(txtEmail.Text, txtCode.Text, txtNew.Text, txtConfirm.Text);
                MessageBox.Show("Password reset successfully. You can now sign in with your new password.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
