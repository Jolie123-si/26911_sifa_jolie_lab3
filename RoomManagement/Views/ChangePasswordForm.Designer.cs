namespace RoomManagement.Views
{
    partial class ChangePasswordForm
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
            lblCurrent = new Label();
            txtCurrent = new TextBox();
            lblNew = new Label();
            txtNew = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(2, 132, 199);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Change password";
            //
            // lblCurrent
            //
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCurrent.ForeColor = Color.FromArgb(31, 41, 55);
            lblCurrent.Location = new Point(26, 70);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(118, 19);
            lblCurrent.TabIndex = 1;
            lblCurrent.Text = "Current password";
            //
            // txtCurrent
            //
            txtCurrent.Location = new Point(26, 92);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(348, 25);
            txtCurrent.TabIndex = 2;
            txtCurrent.UseSystemPasswordChar = true;
            //
            // lblNew
            //
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNew.ForeColor = Color.FromArgb(31, 41, 55);
            lblNew.Location = new Point(26, 128);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(99, 19);
            lblNew.TabIndex = 3;
            lblNew.Text = "New password";
            //
            // txtNew
            //
            txtNew.Location = new Point(26, 150);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(348, 25);
            txtNew.TabIndex = 4;
            txtNew.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.FromArgb(31, 41, 55);
            lblConfirm.Location = new Point(26, 186);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(155, 19);
            lblConfirm.TabIndex = 5;
            lblConfirm.Text = "Confirm new password";
            //
            // txtConfirm
            //
            txtConfirm.Location = new Point(26, 208);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(348, 25);
            txtConfirm.TabIndex = 6;
            txtConfirm.UseSystemPasswordChar = true;
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(2, 132, 199);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(164, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 38);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(2, 132, 199);
            btnCancel.Location = new Point(272, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            //
            // ChangePasswordForm
            //
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(400, 316);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(txtNew);
            Controls.Add(lblNew);
            Controls.Add(txtCurrent);
            Controls.Add(lblCurrent);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCurrent;
        private TextBox txtCurrent;
        private Label lblNew;
        private TextBox txtNew;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnCancel;
    }
}
