namespace RoomManagement.Views
{
    partial class CancelReasonForm
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
            lblInfo = new Label();
            lblReason = new Label();
            txtReason = new TextBox();
            lblWords = new Label();
            lblNote = new Label();
            btnBack = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cancel Booking";
            //
            // lblInfo
            //
            lblInfo.BackColor = Color.FromArgb(224, 242, 254);
            lblInfo.Font = new Font("Segoe UI", 9.75F);
            lblInfo.ForeColor = Color.FromArgb(2, 132, 199);
            lblInfo.Location = new Point(24, 58);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(12, 0, 12, 0);
            lblInfo.Size = new Size(432, 72);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Room:\r\nPurpose:\r\nWhen:";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblReason
            //
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReason.ForeColor = Color.FromArgb(31, 41, 55);
            lblReason.Location = new Point(24, 146);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(235, 15);
            lblReason.TabIndex = 2;
            lblReason.Text = "Reason for cancellation * (max 10 words)";
            //
            // txtReason
            //
            txtReason.Location = new Point(24, 168);
            txtReason.MaxLength = 500;
            txtReason.Name = "txtReason";
            txtReason.PlaceholderText = "Briefly explain why you are cancelling...";
            txtReason.Size = new Size(432, 25);
            txtReason.TabIndex = 3;
            txtReason.TextChanged += txtReason_TextChanged;
            //
            // lblWords
            //
            lblWords.Font = new Font("Segoe UI", 8.5F);
            lblWords.ForeColor = Color.FromArgb(107, 114, 128);
            lblWords.Location = new Point(24, 196);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(432, 18);
            lblWords.TabIndex = 4;
            lblWords.Text = "10 words left";
            lblWords.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblNote
            //
            lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.ForeColor = Color.FromArgb(217, 119, 6);
            lblNote.Location = new Point(24, 220);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(432, 36);
            lblNote.TabIndex = 5;
            lblNote.Text = "This booking is approved, so an administrator must confirm the cancellation.";
            //
            // btnBack
            //
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(2, 132, 199);
            btnBack.Location = new Point(186, 270);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 40);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.FromArgb(220, 38, 38);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(306, 270);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 40);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Cancel Booking";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // CancelReasonForm
            //
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnBack;
            ClientSize = new Size(480, 330);
            Controls.Add(btnConfirm);
            Controls.Add(btnBack);
            Controls.Add(lblNote);
            Controls.Add(lblWords);
            Controls.Add(txtReason);
            Controls.Add(lblReason);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CancelReasonForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cancel Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private Label lblReason;
        private TextBox txtReason;
        private Label lblWords;
        private Label lblNote;
        private Button btnBack;
        private Button btnConfirm;
    }
}
