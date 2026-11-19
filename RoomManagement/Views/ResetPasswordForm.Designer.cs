namespace RoomManagement.Views
{
    partial class ResetPasswordForm
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCode = new Label();
            txtCode = new TextBox();
            lblNew = new Label();
            txtNew = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            btnReset = new Button();
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
            lblTitle.Text = "RESET PASSWORD";
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
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(36, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "EMAIL ADDRESS";
            //
            // txtEmail
            //
            txtEmail.BackColor = Color.FromArgb(244, 246, 248);
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(36, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(388, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TabStop = false;
            //
            // lblCode
            //
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCode.ForeColor = Color.FromArgb(31, 41, 55);
            lblCode.Location = new Point(36, 170);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(76, 15);
            lblCode.TabIndex = 5;
            lblCode.Text = "RESET CODE";
            //
            // txtCode
            //
            txtCode.Font = new Font("Segoe UI", 11F);
            txtCode.Location = new Point(36, 192);
            txtCode.MaxLength = 6;
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "6-digit code";
            txtCode.Size = new Size(388, 27);
            txtCode.TabIndex = 6;
            //
            // lblNew
            //
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNew.ForeColor = Color.FromArgb(31, 41, 55);
            lblNew.Location = new Point(36, 234);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(98, 15);
            lblNew.TabIndex = 7;
            lblNew.Text = "NEW PASSWORD";
            //
            // txtNew
            //
            txtNew.Font = new Font("Segoe UI", 11F);
            txtNew.Location = new Point(36, 256);
            txtNew.Name = "txtNew";
            txtNew.PlaceholderText = "Enter new password";
            txtNew.Size = new Size(388, 27);
            txtNew.TabIndex = 8;
            txtNew.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.FromArgb(31, 41, 55);
            lblConfirm.Location = new Point(36, 298);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(126, 15);
            lblConfirm.TabIndex = 9;
            lblConfirm.Text = "CONFIRM PASSWORD";
            //
            // txtConfirm
            //
            txtConfirm.Font = new Font("Segoe UI", 11F);
            txtConfirm.Location = new Point(36, 320);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Confirm new password";
            txtConfirm.Size = new Size(388, 27);
            txtConfirm.TabIndex = 10;
            txtConfirm.UseSystemPasswordChar = true;
            //
            // btnReset
            //
            btnReset.BackColor = Color.FromArgb(2, 132, 199);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(36, 370);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(388, 46);
            btnReset.TabIndex = 11;
            btnReset.Text = "RESET PASSWORD";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            //
            // lnkBack
            //
            lnkBack.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkBack.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkBack.LinkColor = Color.FromArgb(2, 132, 199);
            lnkBack.Location = new Point(0, 432);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(460, 24);
            lnkBack.TabIndex = 12;
            lnkBack.TabStop = true;
            lnkBack.Text = "Back to Sign In";
            lnkBack.TextAlign = ContentAlignment.MiddleCenter;
            lnkBack.LinkClicked += lnkBack_LinkClicked;
            //
            // ResetPasswordForm
            //
            AcceptButton = btnReset;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 478);
            Controls.Add(lnkBack);
            Controls.Add(btnReset);
            Controls.Add(txtConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(txtNew);
            Controls.Add(lblNew);
            Controls.Add(txtCode);
            Controls.Add(lblCode);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pnlDivider);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlDivider;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCode;
        private TextBox txtCode;
        private Label lblNew;
        private TextBox txtNew;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnReset;
        private LinkLabel lnkBack;
    }
}
