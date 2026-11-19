namespace RoomManagement.Views
{
    partial class AvailableRoomForm
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
            DataGridViewCellStyle gridHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle gridCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle bookButtonStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle detailsButtonStyle = new DataGridViewCellStyle();
            pnlCard = new Panel();
            dgvRooms = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colRoomName = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colAvailability = new DataGridViewTextBoxColumn();
            colBook = new DataGridViewButtonColumn();
            colDetails = new DataGridViewButtonColumn();
            pnlLine = new Panel();
            lblHint = new Label();
            lblTitle = new Label();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            //
            // pnlCard
            //
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(dgvRooms);
            pnlCard.Controls.Add(pnlLine);
            pnlCard.Controls.Add(lblHint);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(0, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(973, 672);
            pnlCard.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(18, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Available Rooms (0)";
            //
            // lblHint
            //
            lblHint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHint.ForeColor = Color.FromArgb(107, 114, 128);
            lblHint.Location = new Point(493, 15);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(462, 22);
            lblHint.TabIndex = 1;
            lblHint.Text = "Click \"Book\" to request a room.";
            lblHint.TextAlign = ContentAlignment.MiddleRight;
            //
            // pnlLine
            //
            pnlLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlLine.Location = new Point(0, 52);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(973, 1);
            pnlLine.TabIndex = 2;
            //
            // dgvRooms
            //
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridHeaderStyle.BackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridHeaderStyle.ForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.Padding = new Padding(8, 0, 0, 0);
            gridHeaderStyle.SelectionBackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.SelectionForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = gridHeaderStyle;
            dgvRooms.ColumnHeadersHeight = 42;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colNumber, colRoomName, colCapacity, colLocation, colAvailability, colBook, colDetails });
            gridCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridCellStyle.BackColor = Color.White;
            gridCellStyle.Font = new Font("Segoe UI", 9.75F);
            gridCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            gridCellStyle.Padding = new Padding(8, 0, 0, 0);
            gridCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            gridCellStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            gridCellStyle.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = gridCellStyle;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(229, 231, 235);
            dgvRooms.Location = new Point(0, 53);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 48;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(973, 619);
            dgvRooms.TabIndex = 3;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            dgvRooms.CellFormatting += dgvRooms_CellFormatting;
            dgvRooms.DataBindingComplete += dgvRooms_DataBindingComplete;
            //
            // colNumber
            //
            colNumber.DataPropertyName = "Id";
            colNumber.FillWeight = 30F;
            colNumber.HeaderText = "#";
            colNumber.Name = "colNumber";
            //
            // colRoomName
            //
            colRoomName.DataPropertyName = "RoomName";
            colRoomName.FillWeight = 120F;
            colRoomName.HeaderText = "ROOM NAME";
            colRoomName.Name = "colRoomName";
            //
            // colCapacity
            //
            colCapacity.DataPropertyName = "Capacity";
            colCapacity.FillWeight = 70F;
            colCapacity.HeaderText = "CAPACITY";
            colCapacity.Name = "colCapacity";
            //
            // colLocation
            //
            colLocation.DataPropertyName = "Location";
            colLocation.HeaderText = "LOCATION";
            colLocation.Name = "colLocation";
            //
            // colAvailability
            //
            colAvailability.DataPropertyName = "Availability";
            colAvailability.FillWeight = 90F;
            colAvailability.HeaderText = "AVAILABILITY";
            colAvailability.Name = "colAvailability";
            //
            // colBook
            //
            bookButtonStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookButtonStyle.BackColor = Color.FromArgb(2, 132, 199);
            bookButtonStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bookButtonStyle.ForeColor = Color.White;
            bookButtonStyle.Padding = new Padding(10, 8, 10, 8);
            bookButtonStyle.SelectionBackColor = Color.FromArgb(2, 132, 199);
            bookButtonStyle.SelectionForeColor = Color.White;
            colBook.DefaultCellStyle = bookButtonStyle;
            colBook.FillWeight = 70F;
            colBook.FlatStyle = FlatStyle.Flat;
            colBook.HeaderText = "ACTION";
            colBook.Name = "colBook";
            colBook.Text = "Book";
            colBook.UseColumnTextForButtonValue = true;
            //
            // colDetails
            //
            detailsButtonStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailsButtonStyle.BackColor = Color.White;
            detailsButtonStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            detailsButtonStyle.ForeColor = Color.FromArgb(2, 132, 199);
            detailsButtonStyle.Padding = new Padding(10, 8, 10, 8);
            detailsButtonStyle.SelectionBackColor = Color.White;
            detailsButtonStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            colDetails.DefaultCellStyle = detailsButtonStyle;
            colDetails.FillWeight = 90F;
            colDetails.FlatStyle = FlatStyle.Flat;
            colDetails.HeaderText = "DETAILS";
            colDetails.Name = "colDetails";
            colDetails.Text = "View Details";
            colDetails.UseColumnTextForButtonValue = true;
            //
            // AvailableRoomForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(973, 672);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 10F);
            Name = "AvailableRoomForm";
            Text = "Available Rooms";
            Load += AvailableRoomForm_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblHint;
        private Panel pnlLine;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colRoomName;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colAvailability;
        private DataGridViewButtonColumn colBook;
        private DataGridViewButtonColumn colDetails;
    }
}
