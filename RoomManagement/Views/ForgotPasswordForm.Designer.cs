namespace RoomManagement.Views
{
    partial class ForgotPasswordForm
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
            lblHelp = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSend = new Button();
            lnkBack = new LinkLabel();
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
            lblTitle.Text = "FORGOT PASSWORD";
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
            // lblHelp
            //
            lblHelp.Font = new Font("Segoe UI", 9.75F);
            lblHelp.ForeColor = Color.FromArgb(107, 114, 128);
            lblHelp.Location = new Point(36, 102);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(388, 40);
            lblHelp.TabIndex = 3;
            lblHelp.Text = "Enter the email of your account. We will send you a code to reset your password.";
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(36, 152);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL ADDRESS";
            //
            // txtEmail
            //
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(36, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(388, 27);
            txtEmail.TabIndex = 5;
            //
            // btnSend
            //
            btnSend.BackColor = Color.FromArgb(2, 132, 199);
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(36, 222);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(388, 46);
            btnSend.TabIndex = 6;
            btnSend.Text = "SEND RESET CODE";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            //
            // lnkBack
            //
            lnkBack.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkBack.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkBack.LinkColor = Color.FromArgb(2, 132, 199);
            lnkBack.Location = new Point(0, 284);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(460, 24);
            lnkBack.TabIndex = 7;
            lnkBack.TabStop = true;
            lnkBack.Text = "Back to Sign In";
            lnkBack.TextAlign = ContentAlignment.MiddleCenter;
            lnkBack.LinkClicked += lnkBack_LinkClicked;
            //
            // ForgotPasswordForm
            //
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 330);
            Controls.Add(lnkBack);
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblHelp);
            Controls.Add(pnlDivider);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlDivider;
        private Label lblHelp;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSend;
        private LinkLabel lnkBack;
    }
}
