namespace RoomManagement.Views
{
    partial class RoomForm
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
            DataGridViewCellStyle gridAltRowStyle = new DataGridViewCellStyle();
            pnlDetails = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            cmbLocation = new ComboBox();
            lblLocation = new Label();
            txtCapacity = new TextBox();
            lblCapacity = new Label();
            txtRoomName = new TextBox();
            lblRoomName = new Label();
            lblDetailsTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblCount = new Label();
            dgvRooms = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colRoomName = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAvailability = new DataGridViewTextBoxColumn();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            //
            // pnlDetails
            //
            pnlDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlDetails.BackColor = Color.White;
            pnlDetails.Controls.Add(btnClear);
            pnlDetails.Controls.Add(btnDelete);
            pnlDetails.Controls.Add(btnUpdate);
            pnlDetails.Controls.Add(btnAdd);
            pnlDetails.Controls.Add(cmbStatus);
            pnlDetails.Controls.Add(lblStatus);
            pnlDetails.Controls.Add(txtDescription);
            pnlDetails.Controls.Add(lblDescription);
            pnlDetails.Controls.Add(cmbLocation);
            pnlDetails.Controls.Add(lblLocation);
            pnlDetails.Controls.Add(txtCapacity);
            pnlDetails.Controls.Add(lblCapacity);
            pnlDetails.Controls.Add(txtRoomName);
            pnlDetails.Controls.Add(lblRoomName);
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(300, 655);
            pnlDetails.TabIndex = 0;
            //
            // lblDetailsTitle
            //
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(2, 132, 199);
            lblDetailsTitle.Location = new Point(16, 14);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(108, 21);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Room details";
            //
            // lblRoomName
            //
            lblRoomName.AutoSize = true;
            lblRoomName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomName.ForeColor = Color.FromArgb(31, 41, 55);
            lblRoomName.Location = new Point(16, 52);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(87, 19);
            lblRoomName.TabIndex = 1;
            lblRoomName.Text = "Room name *";
            //
            // txtRoomName
            //
            txtRoomName.Location = new Point(16, 74);
            txtRoomName.MaxLength = 100;
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(268, 25);
            txtRoomName.TabIndex = 2;
            //
            // lblCapacity
            //
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.ForeColor = Color.FromArgb(31, 41, 55);
            lblCapacity.Location = new Point(16, 110);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(72, 19);
            lblCapacity.TabIndex = 3;
            lblCapacity.Text = "Capacity *";
            //
            // txtCapacity
            //
            txtCapacity.Location = new Point(16, 132);
            txtCapacity.MaxLength = 4;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(268, 25);
            txtCapacity.TabIndex = 4;
            //
            // lblLocation
            //
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocation.ForeColor = Color.FromArgb(31, 41, 55);
            lblLocation.Location = new Point(16, 168);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(70, 19);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Location *";
            //
            // cmbLocation
            //
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Items.AddRange(new object[] { "Ground", "1st Floor", "2nd Floor", "3rd Floor" });
            cmbLocation.Location = new Point(16, 190);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(268, 25);
            cmbLocation.TabIndex = 6;
            //
            // lblDescription
            //
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(31, 41, 55);
            lblDescription.Location = new Point(16, 226);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(79, 19);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            //
            // txtDescription
            //
            txtDescription.Location = new Point(16, 248);
            txtDescription.MaxLength = 500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(268, 90);
            txtDescription.TabIndex = 8;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(31, 41, 55);
            lblStatus.Location = new Point(16, 348);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 19);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            //
            // cmbStatus
            //
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(16, 370);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(268, 25);
            cmbStatus.TabIndex = 10;
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.FromArgb(22, 163, 74);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(16, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 38);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.BackColor = Color.FromArgb(2, 132, 199);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(154, 418);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 38);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(16, 464);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 38);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnClear
            //
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(2, 132, 199);
            btnClear.Location = new Point(154, 464);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 38);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            //
            // txtSearch
            //
            txtSearch.Location = new Point(316, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, location or description";
            txtSearch.Size = new Size(320, 25);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            //
            // btnSearch
            //
            btnSearch.BackColor = Color.FromArgb(2, 132, 199);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(644, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            //
            // lblCount
            //
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCount.ForeColor = Color.FromArgb(107, 114, 128);
            lblCount.Location = new Point(772, 9);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(210, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "0 rooms";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            //
            // dgvRooms
            //
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            gridAltRowStyle.BackColor = Color.White;
            dgvRooms.AlternatingRowsDefaultCellStyle = gridAltRowStyle;
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
            gridHeaderStyle.SelectionBackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.SelectionForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = gridHeaderStyle;
            dgvRooms.ColumnHeadersHeight = 42;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colId, colRoomName, colCapacity, colLocation, colDescription, colStatus, colAvailability });
            gridCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridCellStyle.BackColor = Color.White;
            gridCellStyle.Font = new Font("Segoe UI", 9.75F);
            gridCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            gridCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            gridCellStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            gridCellStyle.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = gridCellStyle;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(229, 231, 235);
            dgvRooms.Location = new Point(316, 44);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 40;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(666, 611);
            dgvRooms.TabIndex = 4;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;
            dgvRooms.CellFormatting += dgvRooms_CellFormatting;
            dgvRooms.DataBindingComplete += dgvRooms_DataBindingComplete;
            //
            // colId
            //
            colId.DataPropertyName = "Id";
            colId.FillWeight = 30F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            //
            // colRoomName
            //
            colRoomName.DataPropertyName = "RoomName";
            colRoomName.FillWeight = 115F;
            colRoomName.HeaderText = "ROOM";
            colRoomName.Name = "colRoomName";
            //
            // colCapacity
            //
            colCapacity.DataPropertyName = "Capacity";
            colCapacity.FillWeight = 75F;
            colCapacity.HeaderText = "CAPACITY";
            colCapacity.Name = "colCapacity";
            //
            // colLocation
            //
            colLocation.DataPropertyName = "Location";
            colLocation.HeaderText = "LOCATION";
            colLocation.Name = "colLocation";
            //
            // colDescription
            //
            colDescription.DataPropertyName = "Description";
            colDescription.FillWeight = 120F;
            colDescription.HeaderText = "DESCRIPTION";
            colDescription.Name = "colDescription";
            //
            // colStatus
            //
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            //
            // colAvailability
            //
            colAvailability.DataPropertyName = "Availability";
            colAvailability.FillWeight = 80F;
            colAvailability.HeaderText = "TODAY";
            colAvailability.Name = "colAvailability";
            //
            // RoomForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(992, 665);
            Controls.Add(dgvRooms);
            Controls.Add(lblCount);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pnlDetails);
            Font = new Font("Segoe UI", 10F);
            Name = "RoomForm";
            Load += RoomForm_Load;
            Text = "Manage Rooms";
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDetails;
        private Label lblDetailsTitle;
        private Label lblRoomName;
        private TextBox txtRoomName;
        private Label lblCapacity;
        private TextBox txtCapacity;
        private Label lblLocation;
        private ComboBox cmbLocation;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblCount;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colRoomName;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colAvailability;
    }
}
