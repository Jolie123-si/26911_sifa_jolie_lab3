using System;
using System.Windows.Forms;
using RoomManagement.Controllers;
using RoomManagement.Models;
using RoomManagement.Utils;

namespace RoomManagement.Views
{
    public partial class LoginForm : Form
    {
        private AuthController authController = new AuthController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user;
            try
            {
                user = authController.Login(txtEmail.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            // Accounts created by an admin must set their own password at first login
            if (user.PasswordChanged == false)
            {
                MessageBox.Show("This is your first login. Please set your own password.", "Change password",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChangePasswordForm changeForm = new ChangePasswordForm();
                changeForm.SetFirstLoginMode();
                DialogResult result = changeForm.ShowDialog();
                if (result != DialogResult.OK)
                {
                    authController.Logout();
                    return;
                }
            }

            // Open the main window and hide the login window
            txtPassword.Clear();
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();

            // We come back here when the main window is closed
            authController.Logout();
            if (menuForm.LoggedOut)
            {
                this.Show();
                txtEmail.Focus();
            }
            else
            {
                // The user closed the main window with X, so exit the program
                this.Close();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            forgotForm.SetEmail(txtEmail.Text);
            if (forgotForm.ShowDialog() == DialogResult.OK)
            {
                txtEmail.Text = forgotForm.ResetEmail;
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                txtEmail.Text = registerForm.RegisteredEmail;
                txtPassword.Focus();
            }
        }
    }
}
