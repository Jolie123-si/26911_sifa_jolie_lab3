namespace RoomManagement.Views
{
    partial class MyBookingForm
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
            DataGridViewCellStyle dateStyle = new DataGridViewCellStyle();
            pnlCard = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            btnCancelBooking = new Button();
            pnlLine = new Panel();
            dgvBookings = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colPurpose = new DataGridViewTextBoxColumn();
            colDateTime = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colInfo = new DataGridViewTextBoxColumn();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            dateStyle.Format = "dd MMM yyyy";
            //
            // pnlCard
            //
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(dgvBookings);
            pnlCard.Controls.Add(pnlLine);
            pnlCard.Controls.Add(btnCancelBooking);
            pnlCard.Controls.Add(btnRefresh);
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
            lblTitle.Size = new Size(200, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Booking History (0)";
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelBooking.BackColor = Color.FromArgb(220, 38, 38);
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.FlatAppearance.BorderSize = 0;
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.Location = new Point(685, 10);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(150, 32);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 242, 254);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(2, 132, 199);
            btnRefresh.Location = new Point(845, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 32);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // pnlLine
            //
            pnlLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlLine.Location = new Point(0, 52);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(973, 1);
            pnlLine.TabIndex = 0;
            //
            // dgvBookings
            //
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dgvBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridHeaderStyle.BackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridHeaderStyle.ForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.Padding = new Padding(8, 0, 0, 0);
            gridHeaderStyle.SelectionBackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.SelectionForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = gridHeaderStyle;
            dgvBookings.ColumnHeadersHeight = 42;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { colId, colRoom, colPurpose, colDateTime, colCreatedAt, colStatus, colInfo });
            gridCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridCellStyle.BackColor = Color.White;
            gridCellStyle.Font = new Font("Segoe UI", 9.75F);
            gridCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            gridCellStyle.Padding = new Padding(8, 0, 0, 0);
            gridCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            gridCellStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            gridCellStyle.WrapMode = DataGridViewTriState.False;
            dgvBookings.DefaultCellStyle = gridCellStyle;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(229, 231, 235);
            dgvBookings.Location = new Point(0, 53);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowTemplate.Height = 42;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(973, 619);
            dgvBookings.TabIndex = 0;
            dgvBookings.CellFormatting += dgvBookings_CellFormatting;
            dgvBookings.DataBindingComplete += dgvBookings_DataBindingComplete;
            dgvBookings.SelectionChanged += dgvBookings_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.FillWeight = 30F;
            colId.HeaderText = "#";
            colId.Name = "colId";
            // 
            // colRoom
            // 
            colRoom.DataPropertyName = "RoomName";
            colRoom.FillWeight = 100F;
            colRoom.HeaderText = "ROOM";
            colRoom.Name = "colRoom";
            // 
            // colPurpose
            // 
            colPurpose.DataPropertyName = "Purpose";
            colPurpose.FillWeight = 110F;
            colPurpose.HeaderText = "PURPOSE";
            colPurpose.Name = "colPurpose";
            // 
            // colDateTime
            // 
            colDateTime.DataPropertyName = "DateAndTime";
            colDateTime.FillWeight = 160F;
            colDateTime.HeaderText = "DATE & TIME";
            colDateTime.Name = "colDateTime";
            // 
            // colCreatedAt
            // 
            colCreatedAt.DataPropertyName = "CreatedAt";
            colCreatedAt.DefaultCellStyle = dateStyle;
            colCreatedAt.FillWeight = 85F;
            colCreatedAt.HeaderText = "SUBMITTED";
            colCreatedAt.Name = "colCreatedAt";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 95F;
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            // 
            // colInfo
            // 
            colInfo.DataPropertyName = "StatusMessage";
            colInfo.FillWeight = 185F;
            colInfo.HeaderText = "INFO";
            colInfo.Name = "colInfo";
            //
            // MyBookingForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(973, 672);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 10F);
            Name = "MyBookingForm";
            Text = "My Bookings";
            Load += MyBookingForm_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblTitle;
        private Button btnRefresh;
        private Button btnCancelBooking;
        private Panel pnlLine;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colPurpose;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewTextBoxColumn colCreatedAt;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colInfo;
    }
}