namespace RoomManagement.Views
{
    partial class BookingRequestForm
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
            DataGridViewCellStyle cancelHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cancelCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle gridHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle gridCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dateStyle = new DataGridViewCellStyle();
            pnlCancel = new Panel();
            lblCancelTitle = new Label();
            lblNeedsAction = new Label();
            pnlCancelLine = new Panel();
            dgvCancel = new DataGridView();
            btnApproveCancel = new Button();
            btnRejectCancel = new Button();
            pnlAll = new Panel();
            lblAllTitle = new Label();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            cmbSort = new ComboBox();
            pnlAllLine = new Panel();
            dgvBookings = new DataGridView();
            btnApprove = new Button();
            btnReject = new Button();
            btnDelete = new Button();
            btnPrevious = new Button();
            lblPage = new Label();
            btnNext = new Button();
            colCUser = new DataGridViewTextBoxColumn();
            colCRoom = new DataGridViewTextBoxColumn();
            colCPurpose = new DataGridViewTextBoxColumn();
            colCReason = new DataGridViewTextBoxColumn();
            colCDateTime = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colPurpose = new DataGridViewTextBoxColumn();
            colDateTime = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCancel).BeginInit();
            pnlAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            dateStyle.Format = "dd MMM yyyy";
            //
            // pnlCancel
            //
            pnlCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCancel.BackColor = Color.White;
            pnlCancel.Controls.Add(btnRejectCancel);
            pnlCancel.Controls.Add(btnApproveCancel);
            pnlCancel.Controls.Add(dgvCancel);
            pnlCancel.Controls.Add(pnlCancelLine);
            pnlCancel.Controls.Add(lblNeedsAction);
            pnlCancel.Controls.Add(lblCancelTitle);
            pnlCancel.Location = new Point(0, 0);
            pnlCancel.Name = "pnlCancel";
            pnlCancel.Size = new Size(973, 236);
            pnlCancel.TabIndex = 0;
            //
            // lblCancelTitle
            //
            lblCancelTitle.AutoSize = true;
            lblCancelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCancelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblCancelTitle.Location = new Point(18, 15);
            lblCancelTitle.Name = "lblCancelTitle";
            lblCancelTitle.Size = new Size(200, 21);
            lblCancelTitle.TabIndex = 0;
            lblCancelTitle.Text = "Cancellation Requests (0)";
            //
            // lblNeedsAction
            //
            lblNeedsAction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNeedsAction.BackColor = Color.FromArgb(254, 243, 199);
            lblNeedsAction.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNeedsAction.ForeColor = Color.FromArgb(217, 119, 6);
            lblNeedsAction.Location = new Point(815, 15);
            lblNeedsAction.Name = "lblNeedsAction";
            lblNeedsAction.Size = new Size(140, 24);
            lblNeedsAction.TabIndex = 0;
            lblNeedsAction.Text = "Needs admin action";
            lblNeedsAction.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlCancelLine
            //
            pnlCancelLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCancelLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlCancelLine.Location = new Point(0, 52);
            pnlCancelLine.Name = "pnlCancelLine";
            pnlCancelLine.Size = new Size(973, 1);
            pnlCancelLine.TabIndex = 0;
            //
            // dgvCancel
            //
            dgvCancel.AllowUserToAddRows = false;
            dgvCancel.AllowUserToDeleteRows = false;
            dgvCancel.AllowUserToResizeRows = false;
            dgvCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCancel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCancel.BackgroundColor = Color.White;
            dgvCancel.BorderStyle = BorderStyle.None;
            dgvCancel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCancel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            cancelHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cancelHeaderStyle.BackColor = Color.FromArgb(250, 251, 252);
            cancelHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelHeaderStyle.ForeColor = Color.FromArgb(107, 114, 128);
            cancelHeaderStyle.Padding = new Padding(8, 0, 0, 0);
            cancelHeaderStyle.SelectionBackColor = Color.FromArgb(250, 251, 252);
            cancelHeaderStyle.SelectionForeColor = Color.FromArgb(107, 114, 128);
            cancelHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvCancel.ColumnHeadersDefaultCellStyle = cancelHeaderStyle;
            dgvCancel.ColumnHeadersHeight = 42;
            dgvCancel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCancel.Columns.AddRange(new DataGridViewColumn[] { colCUser, colCRoom, colCPurpose, colCReason, colCDateTime });
            cancelCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cancelCellStyle.BackColor = Color.White;
            cancelCellStyle.Font = new Font("Segoe UI", 9.75F);
            cancelCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            cancelCellStyle.Padding = new Padding(8, 0, 0, 0);
            cancelCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            cancelCellStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            cancelCellStyle.WrapMode = DataGridViewTriState.False;
            dgvCancel.DefaultCellStyle = cancelCellStyle;
            dgvCancel.EnableHeadersVisualStyles = false;
            dgvCancel.GridColor = Color.FromArgb(229, 231, 235);
            dgvCancel.Location = new Point(0, 53);
            dgvCancel.MultiSelect = false;
            dgvCancel.Name = "dgvCancel";
            dgvCancel.ReadOnly = true;
            dgvCancel.RowHeadersVisible = false;
            dgvCancel.RowTemplate.Height = 42;
            dgvCancel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCancel.Size = new Size(973, 132);
            dgvCancel.TabIndex = 0;
            dgvCancel.DataBindingComplete += dgvCancel_DataBindingComplete;
            dgvCancel.SelectionChanged += dgvCancel_SelectionChanged;
            // 
            // colCUser
            // 
            colCUser.DataPropertyName = "UserFullName";
            colCUser.FillWeight = 100F;
            colCUser.HeaderText = "USER";
            colCUser.Name = "colCUser";
            // 
            // colCRoom
            // 
            colCRoom.DataPropertyName = "RoomName";
            colCRoom.FillWeight = 100F;
            colCRoom.HeaderText = "ROOM";
            colCRoom.Name = "colCRoom";
            // 
            // colCPurpose
            // 
            colCPurpose.DataPropertyName = "Purpose";
            colCPurpose.FillWeight = 130F;
            colCPurpose.HeaderText = "PURPOSE";
            colCPurpose.Name = "colCPurpose";
            // 
            // colCReason
            // 
            colCReason.DataPropertyName = "CancelReason";
            colCReason.FillWeight = 130F;
            colCReason.HeaderText = "REASON";
            colCReason.Name = "colCReason";
            // 
            // colCDateTime
            // 
            colCDateTime.DataPropertyName = "DateAndTime";
            colCDateTime.FillWeight = 180F;
            colCDateTime.HeaderText = "DATE & TIME";
            colCDateTime.Name = "colCDateTime";
            // 
            // btnApproveCancel
            // 
            btnApproveCancel.BackColor = Color.FromArgb(22, 163, 74);
            btnApproveCancel.Cursor = Cursors.Hand;
            btnApproveCancel.FlatAppearance.BorderSize = 0;
            btnApproveCancel.FlatStyle = FlatStyle.Flat;
            btnApproveCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApproveCancel.ForeColor = Color.White;
            btnApproveCancel.Location = new Point(18, 194);
            btnApproveCancel.Name = "btnApproveCancel";
            btnApproveCancel.Size = new Size(150, 32);
            btnApproveCancel.TabIndex = 1;
            btnApproveCancel.Text = "Approve Cancel";
            btnApproveCancel.UseVisualStyleBackColor = false;
            btnApproveCancel.Click += btnApproveCancel_Click;
            // 
            // btnRejectCancel
            // 
            btnRejectCancel.BackColor = Color.White;
            btnRejectCancel.Cursor = Cursors.Hand;
            btnRejectCancel.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnRejectCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 242, 254);
            btnRejectCancel.FlatStyle = FlatStyle.Flat;
            btnRejectCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRejectCancel.ForeColor = Color.FromArgb(2, 132, 199);
            btnRejectCancel.Location = new Point(176, 194);
            btnRejectCancel.Name = "btnRejectCancel";
            btnRejectCancel.Size = new Size(150, 32);
            btnRejectCancel.TabIndex = 2;
            btnRejectCancel.Text = "Reject Cancel";
            btnRejectCancel.UseVisualStyleBackColor = false;
            btnRejectCancel.Click += btnRejectCancel_Click;
            //
            // pnlAll
            //
            pnlAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAll.BackColor = Color.White;
            pnlAll.Controls.Add(btnNext);
            pnlAll.Controls.Add(lblPage);
            pnlAll.Controls.Add(btnPrevious);
            pnlAll.Controls.Add(btnDelete);
            pnlAll.Controls.Add(btnReject);
            pnlAll.Controls.Add(btnApprove);
            pnlAll.Controls.Add(dgvBookings);
            pnlAll.Controls.Add(pnlAllLine);
            pnlAll.Controls.Add(cmbSort);
            pnlAll.Controls.Add(txtSearch);
            pnlAll.Controls.Add(cmbFilter);
            pnlAll.Controls.Add(lblAllTitle);
            pnlAll.Location = new Point(0, 252);
            pnlAll.Name = "pnlAll";
            pnlAll.Size = new Size(973, 420);
            pnlAll.TabIndex = 0;
            //
            // lblAllTitle
            //
            lblAllTitle.AutoSize = true;
            lblAllTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAllTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblAllTitle.Location = new Point(18, 15);
            lblAllTitle.Name = "lblAllTitle";
            lblAllTitle.Size = new Size(200, 21);
            lblAllTitle.TabIndex = 0;
            lblAllTitle.Text = "All Booking Status (0)";
            //
            // cmbFilter
            //
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Approved", "Rejected", "Cancel Request", "Cancelled" });
            cmbFilter.Location = new Point(440, 13);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(160, 25);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            //
            // txtSearch
            //
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(610, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(190, 25);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // cmbSort
            //
            cmbSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Items.AddRange(new object[] { "Newest first", "Oldest first" });
            cmbSort.Location = new Point(810, 13);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(145, 25);
            cmbSort.TabIndex = 3;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            //
            // pnlAllLine
            //
            pnlAllLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAllLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlAllLine.Location = new Point(0, 52);
            pnlAllLine.Name = "pnlAllLine";
            pnlAllLine.Size = new Size(973, 1);
            pnlAllLine.TabIndex = 0;
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
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { colId, colUser, colRoom, colPurpose, colDateTime, colCreatedAt, colStatus });
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
            dgvBookings.Size = new Size(973, 314);
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
            // colUser
            // 
            colUser.DataPropertyName = "UserFullName";
            colUser.FillWeight = 100F;
            colUser.HeaderText = "USER";
            colUser.Name = "colUser";
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
            colPurpose.FillWeight = 130F;
            colPurpose.HeaderText = "PURPOSE";
            colPurpose.Name = "colPurpose";
            // 
            // colDateTime
            // 
            colDateTime.DataPropertyName = "DateAndTime";
            colDateTime.FillWeight = 180F;
            colDateTime.HeaderText = "DATE & TIME";
            colDateTime.Name = "colDateTime";
            // 
            // colCreatedAt
            // 
            colCreatedAt.DataPropertyName = "CreatedAt";
            colCreatedAt.DefaultCellStyle = dateStyle;
            colCreatedAt.FillWeight = 90F;
            colCreatedAt.HeaderText = "SUBMITTED";
            colCreatedAt.Name = "colCreatedAt";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 100F;
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            // 
            // btnApprove
            // 
            btnApprove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnApprove.BackColor = Color.FromArgb(22, 163, 74);
            btnApprove.Cursor = Cursors.Hand;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(18, 376);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(120, 34);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReject.BackColor = Color.FromArgb(220, 38, 38);
            btnReject.Cursor = Cursors.Hand;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(146, 376);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(120, 34);
            btnReject.TabIndex = 5;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 242, 254);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(2, 132, 199);
            btnDelete.Location = new Point(274, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnPrevious
            //
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.BackColor = Color.White;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 242, 254);
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrevious.ForeColor = Color.FromArgb(2, 132, 199);
            btnPrevious.Location = new Point(625, 376);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 34);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "< Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            //
            // lblPage
            //
            lblPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPage.ForeColor = Color.FromArgb(107, 114, 128);
            lblPage.Location = new Point(730, 376);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(115, 34);
            lblPage.TabIndex = 8;
            lblPage.Text = "Page 1 of 1";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnNext
            //
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.White;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 242, 254);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNext.ForeColor = Color.FromArgb(2, 132, 199);
            btnNext.Location = new Point(850, 376);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 34);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next >";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            //
            // BookingRequestForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(973, 672);
            Controls.Add(pnlAll);
            Controls.Add(pnlCancel);
            Font = new Font("Segoe UI", 10F);
            Name = "BookingRequestForm";
            Text = "Booking Requests";
            Load += BookingRequestForm_Load;
            pnlCancel.ResumeLayout(false);
            pnlCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCancel).EndInit();
            pnlAll.ResumeLayout(false);
            pnlAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCancel;
        private Label lblCancelTitle;
        private Label lblNeedsAction;
        private Panel pnlCancelLine;
        private DataGridView dgvCancel;
        private Button btnApproveCancel;
        private Button btnRejectCancel;
        private Panel pnlAll;
        private Label lblAllTitle;
        private ComboBox cmbFilter;
        private TextBox txtSearch;
        private ComboBox cmbSort;
        private Panel pnlAllLine;
        private DataGridView dgvBookings;
        private Button btnApprove;
        private Button btnReject;
        private Button btnDelete;
        private Button btnPrevious;
        private Label lblPage;
        private Button btnNext;
        private DataGridViewTextBoxColumn colCUser;
        private DataGridViewTextBoxColumn colCRoom;
        private DataGridViewTextBoxColumn colCPurpose;
        private DataGridViewTextBoxColumn colCReason;
        private DataGridViewTextBoxColumn colCDateTime;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUser;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colPurpose;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewTextBoxColumn colCreatedAt;
        private DataGridViewTextBoxColumn colStatus;
    }
}