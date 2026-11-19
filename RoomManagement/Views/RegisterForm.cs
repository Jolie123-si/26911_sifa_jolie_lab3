using System;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;

namespace RoomManagement.Views
{
    // Sign Up: full name, email, and the role (User or Administrator).
    // The account gets the default password and must choose a new one at first sign in.
    public partial class RegisterForm : Form
    {
        private AuthController authController = new AuthController();

        // The login form reads this to fill the email box
        public string RegisteredEmail = "";

        public RegisterForm()
        {
            InitializeComponent();
            lblInfo.Text = "Your default password is: " + AuthController.GetDefaultPassword() + "\r\n" +
                           "You will choose your own password when you first sign in.";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // The person must say if they are a User or an Administrator
            UserRole role;
            if (rdoUser.Checked)
            {
                role = UserRole.USER;
            }
            else if (rdoAdmin.Checked)
            {
                role = UserRole.ADMIN;
            }
            else
            {
                MessageBox.Show("Please choose if you register as a User or as an Administrator.", "Register as",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user;
            try
            {
                user = authController.Register(txtFullName.Text, txtEmail.Text, role);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisteredEmail = user.Email;
            string roleText;
            if (role == UserRole.ADMIN)
            {
                roleText = "Administrator";
            }
            else
            {
                roleText = "User";
            }

            // Send the default password by email when email is switched on in App.config
            string emailText = "";
            if (authController.IsEmailEnabled())
            {
                try
                {
                    authController.SendDefaultPasswordEmail(user);
                    emailText = "\n\nThe default password was also sent to " + user.Email + ".";
                }
                catch (Exception ex)
                {
                    emailText = "\n\n(" + ex.Message + ")";
                }
            }

            MessageBox.Show("Account created as " + roleText + "!\n\n" +
                "Sign in with your email and the default password: " + AuthController.GetDefaultPassword() + emailText,
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
