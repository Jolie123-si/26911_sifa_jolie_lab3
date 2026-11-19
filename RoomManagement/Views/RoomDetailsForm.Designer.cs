namespace RoomManagement.Views
{
    partial class RoomDetailsForm
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
            lblNameCaption = new Label();
            lblName = new Label();
            lblCapacityCaption = new Label();
            lblCapacity = new Label();
            lblLocationCaption = new Label();
            lblLocation = new Label();
            lblDescriptionCaption = new Label();
            lblDescription = new Label();
            lblAvailabilityCaption = new Label();
            lblAvailability = new Label();
            btnClose = new Button();
            btnBook = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Room Details";
            //
            // lblNameCaption
            //
            lblNameCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNameCaption.ForeColor = Color.FromArgb(55, 65, 81);
            lblNameCaption.Location = new Point(24, 64);
            lblNameCaption.Name = "lblNameCaption";
            lblNameCaption.Size = new Size(140, 24);
            lblNameCaption.TabIndex = 1;
            lblNameCaption.Text = "Room Name";
            //
            // lblName
            //
            lblName.ForeColor = Color.FromArgb(31, 41, 55);
            lblName.Location = new Point(170, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(246, 24);
            lblName.TabIndex = 2;
            lblName.Text = "-";
            //
            // lblCapacityCaption
            //
            lblCapacityCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCapacityCaption.ForeColor = Color.FromArgb(55, 65, 81);
            lblCapacityCaption.Location = new Point(24, 100);
            lblCapacityCaption.Name = "lblCapacityCaption";
            lblCapacityCaption.Size = new Size(140, 24);
            lblCapacityCaption.TabIndex = 3;
            lblCapacityCaption.Text = "Capacity";
            //
            // lblCapacity
            //
            lblCapacity.ForeColor = Color.FromArgb(31, 41, 55);
            lblCapacity.Location = new Point(170, 100);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(246, 24);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "-";
            //
            // lblLocationCaption
            //
            lblLocationCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblLocationCaption.ForeColor = Color.FromArgb(55, 65, 81);
            lblLocationCaption.Location = new Point(24, 136);
            lblLocationCaption.Name = "lblLocationCaption";
            lblLocationCaption.Size = new Size(140, 24);
            lblLocationCaption.TabIndex = 5;
            lblLocationCaption.Text = "Location";
            //
            // lblLocation
            //
            lblLocation.ForeColor = Color.FromArgb(31, 41, 55);
            lblLocation.Location = new Point(170, 136);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(246, 24);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "-";
            //
            // lblDescriptionCaption
            //
            lblDescriptionCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDescriptionCaption.ForeColor = Color.FromArgb(55, 65, 81);
            lblDescriptionCaption.Location = new Point(24, 172);
            lblDescriptionCaption.Name = "lblDescriptionCaption";
            lblDescriptionCaption.Size = new Size(140, 24);
            lblDescriptionCaption.TabIndex = 7;
            lblDescriptionCaption.Text = "Description";
            //
            // lblDescription
            //
            lblDescription.ForeColor = Color.FromArgb(31, 41, 55);
            lblDescription.Location = new Point(170, 172);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(246, 44);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "-";
            //
            // lblAvailabilityCaption
            //
            lblAvailabilityCaption.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAvailabilityCaption.ForeColor = Color.FromArgb(55, 65, 81);
            lblAvailabilityCaption.Location = new Point(24, 228);
            lblAvailabilityCaption.Name = "lblAvailabilityCaption";
            lblAvailabilityCaption.Size = new Size(140, 24);
            lblAvailabilityCaption.TabIndex = 9;
            lblAvailabilityCaption.Text = "Availability";
            //
            // lblAvailability
            //
            lblAvailability.ForeColor = Color.FromArgb(31, 41, 55);
            lblAvailability.Location = new Point(170, 228);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(246, 24);
            lblAvailability.TabIndex = 10;
            lblAvailability.Text = "-";
            //
            // btnClose
            //
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(2, 132, 199);
            btnClose.Location = new Point(146, 276);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 40);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            //
            // btnBook
            //
            btnBook.BackColor = Color.FromArgb(2, 132, 199);
            btnBook.Cursor = Cursors.Hand;
            btnBook.DialogResult = DialogResult.Yes;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(266, 276);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(150, 40);
            btnBook.TabIndex = 11;
            btnBook.Text = "Book This Room";
            btnBook.UseVisualStyleBackColor = false;
            //
            // RoomDetailsForm
            //
            AcceptButton = btnBook;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(440, 336);
            Controls.Add(btnBook);
            Controls.Add(btnClose);
            Controls.Add(lblName);
            Controls.Add(lblNameCaption);
            Controls.Add(lblCapacity);
            Controls.Add(lblCapacityCaption);
            Controls.Add(lblLocation);
            Controls.Add(lblLocationCaption);
            Controls.Add(lblDescription);
            Controls.Add(lblDescriptionCaption);
            Controls.Add(lblAvailability);
            Controls.Add(lblAvailabilityCaption);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoomDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Room Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNameCaption;
        private Label lblName;
        private Label lblCapacityCaption;
        private Label lblCapacity;
        private Label lblLocationCaption;
        private Label lblLocation;
        private Label lblDescriptionCaption;
        private Label lblDescription;
        private Label lblAvailabilityCaption;
        private Label lblAvailability;
        private Button btnClose;
        private Button btnBook;
    }
}