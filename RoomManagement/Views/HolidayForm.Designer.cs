namespace RoomManagement.Views
{
    partial class HolidayForm
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
            DataGridViewCellStyle dateStyle = new DataGridViewCellStyle();
            pnlDetails = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtName = new TextBox();
            lblName = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            lblDetailsTitle = new Label();
            lblYear = new Label();
            cmbYear = new ComboBox();
            lblCount = new Label();
            dgvHolidays = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colDay = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHolidays).BeginInit();
            SuspendLayout();
            dateStyle.Format = "dd MMMM yyyy";
            //
            // pnlDetails
            //
            pnlDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlDetails.BackColor = Color.White;
            pnlDetails.Controls.Add(btnClear);
            pnlDetails.Controls.Add(btnDelete);
            pnlDetails.Controls.Add(btnUpdate);
            pnlDetails.Controls.Add(btnAdd);
            pnlDetails.Controls.Add(txtName);
            pnlDetails.Controls.Add(lblName);
            pnlDetails.Controls.Add(dtpDate);
            pnlDetails.Controls.Add(lblDate);
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
            lblDetailsTitle.Size = new Size(122, 21);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Holiday details";
            //
            // lblDate
            //
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(31, 41, 55);
            lblDate.Location = new Point(16, 52);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 19);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date *";
            //
            // dtpDate
            //
            dtpDate.CustomFormat = "dd MMMM";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(16, 74);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(268, 25);
            dtpDate.TabIndex = 2;
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(31, 41, 55);
            lblName.Location = new Point(16, 110);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 19);
            lblName.TabIndex = 3;
            lblName.Text = "Name *";
            //
            // txtName
            //
            txtName.Location = new Point(16, 132);
            txtName.MaxLength = 150;
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 25);
            txtName.TabIndex = 4;
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.FromArgb(22, 163, 74);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(16, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 38);
            btnAdd.TabIndex = 5;
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
            btnUpdate.Location = new Point(154, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 38);
            btnUpdate.TabIndex = 6;
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
            btnDelete.Location = new Point(16, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 38);
            btnDelete.TabIndex = 7;
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
            btnClear.Location = new Point(154, 226);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 38);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            //
            // lblYear
            //
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(31, 41, 55);
            lblYear.Location = new Point(316, 9);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(35, 19);
            lblYear.TabIndex = 1;
            lblYear.Text = "Year";
            //
            // cmbYear
            //
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.Location = new Point(360, 5);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(140, 25);
            cmbYear.TabIndex = 2;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            //
            // lblCount
            //
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCount.ForeColor = Color.FromArgb(107, 114, 128);
            lblCount.Location = new Point(772, 9);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(210, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "0 holidays";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            //
            // dgvHolidays
            //
            dgvHolidays.AllowUserToAddRows = false;
            dgvHolidays.AllowUserToDeleteRows = false;
            dgvHolidays.AllowUserToResizeRows = false;
            gridAltRowStyle.BackColor = Color.White;
            dgvHolidays.AlternatingRowsDefaultCellStyle = gridAltRowStyle;
            dgvHolidays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHolidays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHolidays.BackgroundColor = Color.White;
            dgvHolidays.BorderStyle = BorderStyle.None;
            dgvHolidays.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHolidays.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridHeaderStyle.BackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridHeaderStyle.ForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.SelectionBackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.SelectionForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvHolidays.ColumnHeadersDefaultCellStyle = gridHeaderStyle;
            dgvHolidays.ColumnHeadersHeight = 42;
            dgvHolidays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHolidays.Columns.AddRange(new DataGridViewColumn[] { colId, colDate, colDay, colName });
            gridCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridCellStyle.BackColor = Color.White;
            gridCellStyle.Font = new Font("Segoe UI", 9.75F);
            gridCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            gridCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            gridCellStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            gridCellStyle.WrapMode = DataGridViewTriState.False;
            dgvHolidays.DefaultCellStyle = gridCellStyle;
            dgvHolidays.EnableHeadersVisualStyles = false;
            dgvHolidays.GridColor = Color.FromArgb(229, 231, 235);
            dgvHolidays.Location = new Point(316, 44);
            dgvHolidays.MultiSelect = false;
            dgvHolidays.Name = "dgvHolidays";
            dgvHolidays.ReadOnly = true;
            dgvHolidays.RowHeadersVisible = false;
            dgvHolidays.RowTemplate.Height = 40;
            dgvHolidays.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHolidays.Size = new Size(666, 611);
            dgvHolidays.TabIndex = 4;
            dgvHolidays.CellFormatting += dgvHolidays_CellFormatting;
            dgvHolidays.SelectionChanged += dgvHolidays_SelectionChanged;
            dgvHolidays.DataBindingComplete += dgvHolidays_DataBindingComplete;
            //
            // colId
            //
            colId.DataPropertyName = "Id";
            colId.FillWeight = 30F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            //
            // colDate
            //
            colDate.DataPropertyName = "Date";
            colDate.DefaultCellStyle = dateStyle;
            colDate.FillWeight = 70F;
            colDate.HeaderText = "DATE";
            colDate.Name = "colDate";
            //
            // colDay
            //
            colDay.DataPropertyName = "Date";
            colDay.FillWeight = 50F;
            colDay.HeaderText = "DAY";
            colDay.Name = "colDay";
            //
            // colName
            //
            colName.DataPropertyName = "Name";
            colName.FillWeight = 150F;
            colName.HeaderText = "HOLIDAY";
            colName.Name = "colName";
            //
            // HolidayForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(992, 665);
            Controls.Add(dgvHolidays);
            Controls.Add(lblCount);
            Controls.Add(cmbYear);
            Controls.Add(lblYear);
            Controls.Add(pnlDetails);
            Font = new Font("Segoe UI", 10F);
            Name = "HolidayForm";
            Load += HolidayForm_Load;
            Text = "Public Holidays";
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHolidays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDetails;
        private Label lblDetailsTitle;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblName;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblYear;
        private ComboBox cmbYear;
        private Label lblCount;
        private DataGridView dgvHolidays;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colName;
    }
}
