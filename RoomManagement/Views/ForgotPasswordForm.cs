using System;
using System.Windows.Forms;
using RoomManagement.Controllers;

namespace RoomManagement.Views
{
    // Step 1 of resetting a forgotten password: the user types the email and gets a reset code
    public partial class ForgotPasswordForm : Form
    {
        private AuthController authController = new AuthController();

        // The login form reads this to fill the email box after the password was reset
        public string ResetEmail = "";

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        // Fills the email box (when the user already typed it on the login form)
        public void SetEmail(string email)
        {
            txtEmail.Text = email;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string code;
            try
            {
                code = authController.ForgotPassword(txtEmail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (code == "")
            {
                MessageBox.Show("A reset code was sent to your email. It is valid for 1 hour.", "Check your email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Email is switched off in App.config (EmailEnabled = false), so show the code here
                MessageBox.Show("Email sending is switched off in App.config, so here is your reset code:\n\n" + code +
                    "\n\nIt is valid for 1 hour.", "Reset code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Step 2: type the code and the new password
            ResetPasswordForm resetForm = new ResetPasswordForm();
            resetForm.SetEmail(txtEmail.Text.Trim());
            if (resetForm.ShowDialog() == DialogResult.OK)
            {
                ResetEmail = txtEmail.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
