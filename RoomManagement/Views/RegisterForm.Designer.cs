namespace RoomManagement.Views
{
    partial class RegisterForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlDivider = new Panel();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            rdoUser = new RadioButton();
            rdoAdmin = new RadioButton();
            lblInfo = new Label();
            btnRegister = new Button();
            lnkSignIn = new LinkLabel();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(2, 132, 199);
            lblTitle.Location = new Point(0, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SIGN UP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitle
            //
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(0, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(460, 22);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Rwanda Revenue Authority";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlDivider
            //
            pnlDivider.BackColor = Color.FromArgb(229, 231, 235);
            pnlDivider.Location = new Point(36, 90);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(388, 1);
            pnlDivider.TabIndex = 2;
            //
            // lblFullName
            //
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(31, 41, 55);
            lblFullName.Location = new Point(36, 106);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(72, 15);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "FULL NAME";
            //
            // txtFullName
            //
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(36, 128);
            txtFullName.MaxLength = 150;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(388, 27);
            txtFullName.TabIndex = 4;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(36, 170);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "EMAIL ADDRESS";
            //
            // txtEmail
            //
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(36, 192);
            txtEmail.MaxLength = 150;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(388, 27);
            txtEmail.TabIndex = 6;
            //
            // lblRole
            //
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(31, 41, 55);
            lblRole.Location = new Point(36, 234);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(82, 15);
            lblRole.TabIndex = 10;
            lblRole.Text = "REGISTER AS";
            //
            // rdoUser
            //
            rdoUser.AutoSize = true;
            rdoUser.Cursor = Cursors.Hand;
            rdoUser.ForeColor = Color.FromArgb(31, 41, 55);
            rdoUser.Location = new Point(36, 256);
            rdoUser.Name = "rdoUser";
            rdoUser.Size = new Size(226, 23);
            rdoUser.TabIndex = 11;
            rdoUser.TabStop = true;
            rdoUser.Text = "User  (view rooms and request bookings)";
            rdoUser.UseVisualStyleBackColor = true;
            //
            // rdoAdmin
            //
            rdoAdmin.AutoSize = true;
            rdoAdmin.Cursor = Cursors.Hand;
            rdoAdmin.ForeColor = Color.FromArgb(31, 41, 55);
            rdoAdmin.Location = new Point(36, 284);
            rdoAdmin.Name = "rdoAdmin";
            rdoAdmin.Size = new Size(330, 23);
            rdoAdmin.TabIndex = 12;
            rdoAdmin.TabStop = true;
            rdoAdmin.Text = "Administrator  (manage rooms, bookings and holidays)";
            rdoAdmin.UseVisualStyleBackColor = true;
            //
            // lblInfo
            //
            lblInfo.BackColor = Color.FromArgb(224, 242, 254);
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.ForeColor = Color.FromArgb(2, 132, 199);
            lblInfo.Location = new Point(36, 320);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(10, 0, 10, 0);
            lblInfo.Size = new Size(388, 52);
            lblInfo.TabIndex = 7;
            lblInfo.Text = "Your default password is: RRA@2024\r\nYou will choose your own password when you first sign in.";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnRegister
            //
            btnRegister.BackColor = Color.FromArgb(2, 132, 199);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(36, 388);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(388, 46);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "SIGN UP";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            //
            // lnkSignIn
            //
            lnkSignIn.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkSignIn.ForeColor = Color.FromArgb(107, 114, 128);
            lnkSignIn.LinkArea = new LinkArea(25, 7);
            lnkSignIn.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkSignIn.LinkColor = Color.FromArgb(2, 132, 199);
            lnkSignIn.Location = new Point(0, 450);
            lnkSignIn.Name = "lnkSignIn";
            lnkSignIn.Size = new Size(460, 24);
            lnkSignIn.TabIndex = 9;
            lnkSignIn.TabStop = true;
            lnkSignIn.Text = "Already have an account? Sign in";
            lnkSignIn.TextAlign = ContentAlignment.MiddleCenter;
            lnkSignIn.UseCompatibleTextRendering = true;
            lnkSignIn.LinkClicked += lnkSignIn_LinkClicked;
            //
            // RegisterForm
            //
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 496);
            Controls.Add(lnkSignIn);
            Controls.Add(btnRegister);
            Controls.Add(rdoAdmin);
            Controls.Add(rdoUser);
            Controls.Add(lblRole);
            Controls.Add(lblInfo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(pnlDivider);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlDivider;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRole;
        private RadioButton rdoUser;
        private RadioButton rdoAdmin;
        private Label lblInfo;
        private Button btnRegister;
        private LinkLabel lnkSignIn;
    }
}
