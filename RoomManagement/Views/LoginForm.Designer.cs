namespace RoomManagement.Views
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlCard = new Panel();
            lblHint = new Label();
            lnkRegister = new LinkLabel();
            lnkForgot = new LinkLabel();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            pnlDivider = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // pnlCard
            //
            pnlCard.Anchor = AnchorStyles.None;
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblHint);
            pnlCard.Controls.Add(lnkForgot);
            pnlCard.Controls.Add(lnkRegister);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(chkShowPassword);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(pnlDivider);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(picLogo);
            pnlCard.Location = new Point(60, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(440, 540);
            pnlCard.TabIndex = 0;
            //
            // picLogo
            //
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(140, 28);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(160, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(2, 132, 199);
            lblTitle.Location = new Point(0, 116);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ROOM MANAGEMENT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitle
            //
            lblSubtitle.Font = new Font("Segoe UI", 9.75F);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(0, 146);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(440, 22);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Rwanda Revenue Authority";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlDivider
            //
            pnlDivider.BackColor = Color.FromArgb(229, 231, 235);
            pnlDivider.Location = new Point(36, 186);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(368, 1);
            pnlDivider.TabIndex = 3;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(36, 206);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL ADDRESS";
            //
            // txtEmail
            //
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(36, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(368, 27);
            txtEmail.TabIndex = 5;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(31, 41, 55);
            lblPassword.Location = new Point(36, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "PASSWORD";
            //
            // txtPassword
            //
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(36, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(368, 27);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            //
            // chkShowPassword
            //
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.FromArgb(107, 114, 128);
            chkShowPassword.Location = new Point(36, 330);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(124, 23);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            //
            // btnLogin
            //
            btnLogin.BackColor = Color.FromArgb(2, 132, 199);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(36, 368);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(368, 46);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            //
            // lnkRegister
            //
            lnkRegister.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkRegister.Font = new Font("Segoe UI", 9.75F);
            lnkRegister.ForeColor = Color.FromArgb(107, 114, 128);
            lnkRegister.LinkArea = new LinkArea(23, 13);
            lnkRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkRegister.LinkColor = Color.FromArgb(2, 132, 199);
            lnkRegister.Location = new Point(0, 454);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(440, 24);
            lnkRegister.TabIndex = 10;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have an account? Register here";
            lnkRegister.TextAlign = ContentAlignment.MiddleCenter;
            lnkRegister.UseCompatibleTextRendering = true;
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            //
            // lnkForgot
            //
            lnkForgot.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkForgot.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lnkForgot.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkForgot.LinkColor = Color.FromArgb(2, 132, 199);
            lnkForgot.Location = new Point(0, 426);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(440, 24);
            lnkForgot.TabIndex = 12;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot password?";
            lnkForgot.TextAlign = ContentAlignment.MiddleCenter;
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            //
            // lblHint
            //
            lblHint.Font = new Font("Segoe UI", 8.5F);
            lblHint.ForeColor = Color.FromArgb(107, 114, 128);
            lblHint.Location = new Point(0, 500);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(440, 20);
            lblHint.TabIndex = 11;
            lblHint.Text = "Default administrator: admin@rra.gov.rw / Admin@1234";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            //
            // LoginForm
            //
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(560, 600);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Management - Sign In";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlDivider;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private LinkLabel lnkForgot;
        private Label lblHint;
    }
}
