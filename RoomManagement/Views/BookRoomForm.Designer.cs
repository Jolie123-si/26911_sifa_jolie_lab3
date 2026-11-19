namespace RoomManagement.Views
{
    partial class BookRoomForm
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
            lblRoomInfo = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            lblPurpose = new Label();
            txtPurpose = new TextBox();
            lblWords = new Label();
            lblRules = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Room";
            //
            // lblRoomInfo
            //
            lblRoomInfo.BackColor = Color.FromArgb(224, 242, 254);
            lblRoomInfo.Font = new Font("Segoe UI", 9.75F);
            lblRoomInfo.ForeColor = Color.FromArgb(2, 132, 199);
            lblRoomInfo.Location = new Point(24, 58);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Padding = new Padding(12, 0, 12, 0);
            lblRoomInfo.Size = new Size(472, 72);
            lblRoomInfo.TabIndex = 1;
            lblRoomInfo.Text = "Room:\r\nLocation:\r\nCapacity:";
            lblRoomInfo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblStartDate
            //
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.FromArgb(31, 41, 55);
            lblStartDate.Location = new Point(24, 146);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(72, 15);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date *";
            //
            // dtpStartDate
            //
            dtpStartDate.CustomFormat = "ddd, dd MMM yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(24, 168);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(224, 25);
            dtpStartDate.TabIndex = 3;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            //
            // lblEndDate
            //
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.ForeColor = Color.FromArgb(31, 41, 55);
            lblEndDate.Location = new Point(272, 146);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(66, 15);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "End Date *";
            //
            // dtpEndDate
            //
            dtpEndDate.CustomFormat = "ddd, dd MMM yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(272, 168);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(224, 25);
            dtpEndDate.TabIndex = 5;
            //
            // lblStartTime
            //
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartTime.ForeColor = Color.FromArgb(31, 41, 55);
            lblStartTime.Location = new Point(24, 206);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(71, 15);
            lblStartTime.TabIndex = 6;
            lblStartTime.Text = "Start Time *";
            //
            // dtpStartTime
            //
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(24, 228);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(224, 25);
            dtpStartTime.TabIndex = 7;
            //
            // lblEndTime
            //
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndTime.ForeColor = Color.FromArgb(31, 41, 55);
            lblEndTime.Location = new Point(272, 206);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(65, 15);
            lblEndTime.TabIndex = 8;
            lblEndTime.Text = "End Time *";
            //
            // dtpEndTime
            //
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(272, 228);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(224, 25);
            dtpEndTime.TabIndex = 9;
            //
            // lblPurpose
            //
            lblPurpose.AutoSize = true;
            lblPurpose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPurpose.ForeColor = Color.FromArgb(31, 41, 55);
            lblPurpose.Location = new Point(24, 268);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(149, 15);
            lblPurpose.TabIndex = 10;
            lblPurpose.Text = "Purpose * (max 10 words)";
            //
            // txtPurpose
            //
            txtPurpose.Location = new Point(24, 290);
            txtPurpose.MaxLength = 255;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.PlaceholderText = "e.g. Weekly team meeting";
            txtPurpose.Size = new Size(472, 25);
            txtPurpose.TabIndex = 11;
            txtPurpose.TextChanged += txtPurpose_TextChanged;
            //
            // lblWords
            //
            lblWords.Font = new Font("Segoe UI", 8.5F);
            lblWords.ForeColor = Color.FromArgb(107, 114, 128);
            lblWords.Location = new Point(24, 318);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(472, 18);
            lblWords.TabIndex = 12;
            lblWords.Text = "10 words left";
            lblWords.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblRules
            //
            lblRules.BackColor = Color.FromArgb(224, 242, 254);
            lblRules.Font = new Font("Segoe UI", 9F);
            lblRules.ForeColor = Color.FromArgb(2, 132, 199);
            lblRules.Location = new Point(24, 346);
            lblRules.Name = "lblRules";
            lblRules.Padding = new Padding(12, 0, 12, 0);
            lblRules.Size = new Size(472, 40);
            lblRules.TabIndex = 13;
            lblRules.Text = "Weekends and public holidays are not allowed. Working hours: 08:00 - 17:00.";
            lblRules.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(2, 132, 199);
            btnCancel.Location = new Point(176, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            //
            // btnSubmit
            //
            btnSubmit.BackColor = Color.FromArgb(2, 132, 199);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(296, 404);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(200, 40);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit Booking Request";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            //
            // BookRoomForm
            //
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(520, 464);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblRules);
            Controls.Add(lblWords);
            Controls.Add(txtPurpose);
            Controls.Add(lblPurpose);
            Controls.Add(dtpEndTime);
            Controls.Add(lblEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblStartTime);
            Controls.Add(dtpEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblRoomInfo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookRoomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Book Room";
            Load += BookRoomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRoomInfo;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblEndTime;
        private DateTimePicker dtpEndTime;
        private Label lblPurpose;
        private TextBox txtPurpose;
        private Label lblWords;
        private Label lblRules;
        private Button btnCancel;
        private Button btnSubmit;
    }
}
