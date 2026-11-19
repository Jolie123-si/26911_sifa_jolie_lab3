using System;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    public partial class ChangePasswordForm : Form
    {
        private AuthController authController = new AuthController();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        // Changes the labels when the user must set a password at first login
        public void SetFirstLoginMode()
        {
            lblTitle.Text = "Set your password";
            lblCurrent.Text = "Temporary password";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                authController.ChangePassword(txtCurrent.Text, txtNew.Text, txtConfirm.Text);
                MessageBox.Show("Password changed successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
