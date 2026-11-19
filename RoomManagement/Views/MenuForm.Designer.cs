namespace RoomManagement.Views
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            pnlSidebar = new Panel();
            flowNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnAddRoom = new Button();
            btnRooms = new Button();
            btnBookingRequests = new Button();
            btnHolidays = new Button();
            btnAvailableRooms = new Button();
            btnMyBookings = new Button();
            pnlUser = new Panel();
            btnLogout = new Button();
            btnChangePassword = new Button();
            lblUserRole = new Label();
            lblUserName = new Label();
            lblAvatar = new Label();
            pnlUserLine = new Panel();
            pnlLogoLine = new Panel();
            pnlLogo = new Panel();
            lblBrand = new Label();
            picLogo = new PictureBox();
            pnlSidebarLine = new Panel();
            pnlHeader = new Panel();
            lblDate = new Label();
            lblPageTitle = new Label();
            pnlHeaderLine = new Panel();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            flowNav.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(flowNav);
            pnlSidebar.Controls.Add(pnlUser);
            pnlSidebar.Controls.Add(pnlLogoLine);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 761);
            pnlSidebar.TabIndex = 0;
            //
            // pnlLogo
            //
            pnlLogo.Controls.Add(lblBrand);
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 64);
            pnlLogo.TabIndex = 0;
            //
            // picLogo
            //
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(14, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(88, 44);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblBrand
            //
            lblBrand.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(2, 132, 199);
            lblBrand.Location = new Point(108, 10);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(130, 44);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "ROOM\r\nMANAGEMENT";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlLogoLine
            //
            pnlLogoLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlLogoLine.Dock = DockStyle.Top;
            pnlLogoLine.Location = new Point(0, 64);
            pnlLogoLine.Name = "pnlLogoLine";
            pnlLogoLine.Size = new Size(250, 1);
            pnlLogoLine.TabIndex = 1;
            //
            // flowNav
            //
            flowNav.Controls.Add(btnDashboard);
            flowNav.Controls.Add(btnAddRoom);
            flowNav.Controls.Add(btnRooms);
            flowNav.Controls.Add(btnBookingRequests);
            flowNav.Controls.Add(btnHolidays);
            flowNav.Controls.Add(btnAvailableRooms);
            flowNav.Controls.Add(btnMyBookings);
            flowNav.Dock = DockStyle.Fill;
            flowNav.FlowDirection = FlowDirection.TopDown;
            flowNav.Location = new Point(0, 65);
            flowNav.Name = "flowNav";
            flowNav.Padding = new Padding(12, 10, 12, 0);
            flowNav.Size = new Size(250, 546);
            flowNav.TabIndex = 2;
            flowNav.WrapContents = false;
            //
            // btnDashboard
            //
            btnDashboard.BackColor = Color.White;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(75, 85, 99);
            btnDashboard.Margin = new Padding(0, 0, 0, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(14, 0, 0, 0);
            btnDashboard.Size = new Size(226, 42);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            //
            // btnAddRoom
            //
            btnAddRoom.BackColor = Color.White;
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 10F);
            btnAddRoom.ForeColor = Color.FromArgb(75, 85, 99);
            btnAddRoom.Margin = new Padding(0, 0, 0, 4);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Padding = new Padding(14, 0, 0, 0);
            btnAddRoom.Size = new Size(226, 42);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "Add New Room";
            btnAddRoom.TextAlign = ContentAlignment.MiddleLeft;
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            //
            // btnRooms
            //
            btnRooms.BackColor = Color.White;
            btnRooms.Cursor = Cursors.Hand;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 10F);
            btnRooms.ForeColor = Color.FromArgb(75, 85, 99);
            btnRooms.Margin = new Padding(0, 0, 0, 4);
            btnRooms.Name = "btnRooms";
            btnRooms.Padding = new Padding(14, 0, 0, 0);
            btnRooms.Size = new Size(226, 42);
            btnRooms.TabIndex = 2;
            btnRooms.Text = "Manage Rooms";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            //
            // btnBookingRequests
            //
            btnBookingRequests.BackColor = Color.White;
            btnBookingRequests.Cursor = Cursors.Hand;
            btnBookingRequests.FlatAppearance.BorderSize = 0;
            btnBookingRequests.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnBookingRequests.FlatStyle = FlatStyle.Flat;
            btnBookingRequests.Font = new Font("Segoe UI", 10F);
            btnBookingRequests.ForeColor = Color.FromArgb(75, 85, 99);
            btnBookingRequests.Margin = new Padding(0, 0, 0, 4);
            btnBookingRequests.Name = "btnBookingRequests";
            btnBookingRequests.Padding = new Padding(14, 0, 0, 0);
            btnBookingRequests.Size = new Size(226, 42);
            btnBookingRequests.TabIndex = 3;
            btnBookingRequests.Text = "Booking Requests";
            btnBookingRequests.TextAlign = ContentAlignment.MiddleLeft;
            btnBookingRequests.UseVisualStyleBackColor = false;
            btnBookingRequests.Click += btnBookingRequests_Click;
            //
            // btnHolidays
            //
            btnHolidays.BackColor = Color.White;
            btnHolidays.Cursor = Cursors.Hand;
            btnHolidays.FlatAppearance.BorderSize = 0;
            btnHolidays.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnHolidays.FlatStyle = FlatStyle.Flat;
            btnHolidays.Font = new Font("Segoe UI", 10F);
            btnHolidays.ForeColor = Color.FromArgb(75, 85, 99);
            btnHolidays.Margin = new Padding(0, 0, 0, 4);
            btnHolidays.Name = "btnHolidays";
            btnHolidays.Padding = new Padding(14, 0, 0, 0);
            btnHolidays.Size = new Size(226, 42);
            btnHolidays.TabIndex = 4;
            btnHolidays.Text = "Public Holidays";
            btnHolidays.TextAlign = ContentAlignment.MiddleLeft;
            btnHolidays.UseVisualStyleBackColor = false;
            btnHolidays.Click += btnHolidays_Click;
            //
            // btnAvailableRooms
            //
            btnAvailableRooms.BackColor = Color.White;
            btnAvailableRooms.Cursor = Cursors.Hand;
            btnAvailableRooms.FlatAppearance.BorderSize = 0;
            btnAvailableRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnAvailableRooms.FlatStyle = FlatStyle.Flat;
            btnAvailableRooms.Font = new Font("Segoe UI", 10F);
            btnAvailableRooms.ForeColor = Color.FromArgb(75, 85, 99);
            btnAvailableRooms.Margin = new Padding(0, 0, 0, 4);
            btnAvailableRooms.Name = "btnAvailableRooms";
            btnAvailableRooms.Padding = new Padding(14, 0, 0, 0);
            btnAvailableRooms.Size = new Size(226, 42);
            btnAvailableRooms.TabIndex = 6;
            btnAvailableRooms.Text = "Available Rooms";
            btnAvailableRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnAvailableRooms.UseVisualStyleBackColor = false;
            btnAvailableRooms.Click += btnAvailableRooms_Click;
            //
            // btnMyBookings
            //
            btnMyBookings.BackColor = Color.White;
            btnMyBookings.Cursor = Cursors.Hand;
            btnMyBookings.FlatAppearance.BorderSize = 0;
            btnMyBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnMyBookings.FlatStyle = FlatStyle.Flat;
            btnMyBookings.Font = new Font("Segoe UI", 10F);
            btnMyBookings.ForeColor = Color.FromArgb(75, 85, 99);
            btnMyBookings.Margin = new Padding(0, 0, 0, 4);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Padding = new Padding(14, 0, 0, 0);
            btnMyBookings.Size = new Size(226, 42);
            btnMyBookings.TabIndex = 7;
            btnMyBookings.Text = "My Bookings";
            btnMyBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnMyBookings.UseVisualStyleBackColor = false;
            btnMyBookings.Click += btnMyBookings_Click;
            //
            // pnlUser
            //
            pnlUser.Controls.Add(btnLogout);
            pnlUser.Controls.Add(btnChangePassword);
            pnlUser.Controls.Add(lblUserRole);
            pnlUser.Controls.Add(lblUserName);
            pnlUser.Controls.Add(lblAvatar);
            pnlUser.Controls.Add(pnlUserLine);
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.Location = new Point(0, 611);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(250, 150);
            pnlUser.TabIndex = 3;
            //
            // pnlUserLine
            //
            pnlUserLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlUserLine.Dock = DockStyle.Top;
            pnlUserLine.Location = new Point(0, 0);
            pnlUserLine.Name = "pnlUserLine";
            pnlUserLine.Size = new Size(250, 1);
            pnlUserLine.TabIndex = 0;
            //
            // lblAvatar
            //
            lblAvatar.BackColor = Color.FromArgb(224, 242, 254);
            lblAvatar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.FromArgb(2, 132, 199);
            lblAvatar.Location = new Point(18, 16);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(38, 38);
            lblAvatar.TabIndex = 1;
            lblAvatar.Text = "A";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblUserName
            //
            lblUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(31, 41, 55);
            lblUserName.Location = new Point(64, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(170, 21);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "User name";
            //
            // lblUserRole
            //
            lblUserRole.Font = new Font("Segoe UI", 8.5F);
            lblUserRole.ForeColor = Color.FromArgb(107, 114, 128);
            lblUserRole.Location = new Point(64, 36);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(170, 18);
            lblUserRole.TabIndex = 3;
            lblUserRole.Text = "role";
            //
            // btnChangePassword
            //
            btnChangePassword.BackColor = Color.White;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(2, 132, 199);
            btnChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 242, 254);
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.FromArgb(2, 132, 199);
            btnChangePassword.Location = new Point(18, 66);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(214, 32);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            //
            // btnLogout
            //
            btnLogout.BackColor = Color.FromArgb(255, 245, 245);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 226, 226);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(220, 38, 38);
            btnLogout.Location = new Point(18, 106);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(214, 32);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            //
            // pnlSidebarLine
            //
            pnlSidebarLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlSidebarLine.Dock = DockStyle.Left;
            pnlSidebarLine.Location = new Point(250, 0);
            pnlSidebarLine.Name = "pnlSidebarLine";
            pnlSidebarLine.Size = new Size(1, 761);
            pnlSidebarLine.TabIndex = 1;
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(251, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1013, 56);
            pnlHeader.TabIndex = 2;
            //
            // lblPageTitle
            //
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblPageTitle.Location = new Point(24, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(108, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            //
            // lblDate
            //
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblDate.Location = new Point(713, 16);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(280, 24);
            lblDate.TabIndex = 1;
            lblDate.Text = "date";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            //
            // pnlHeaderLine
            //
            pnlHeaderLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlHeaderLine.Dock = DockStyle.Top;
            pnlHeaderLine.Location = new Point(251, 56);
            pnlHeaderLine.Name = "pnlHeaderLine";
            pnlHeaderLine.Size = new Size(1013, 1);
            pnlHeaderLine.TabIndex = 3;
            //
            // pnlContent
            //
            pnlContent.BackColor = Color.FromArgb(244, 246, 248);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(251, 57);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20, 16, 20, 16);
            pnlContent.Size = new Size(1013, 704);
            pnlContent.TabIndex = 4;
            //
            // MenuForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(1264, 761);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeaderLine);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebarLine);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 620);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "Room Management";
            Shown += MenuForm_Shown;
            pnlSidebar.ResumeLayout(false);
            flowNav.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlLogo;
        private PictureBox picLogo;
        private Label lblBrand;
        private Panel pnlLogoLine;
        private FlowLayoutPanel flowNav;
        private Button btnDashboard;
        private Button btnAddRoom;
        private Button btnRooms;
        private Button btnBookingRequests;
        private Button btnHolidays;
        private Button btnAvailableRooms;
        private Button btnMyBookings;
        private Panel pnlUser;
        private Panel pnlUserLine;
        private Label lblAvatar;
        private Label lblUserName;
        private Label lblUserRole;
        private Button btnChangePassword;
        private Button btnLogout;
        private Panel pnlSidebarLine;
        private Panel pnlHeader;
        private Label lblPageTitle;
        private Label lblDate;
        private Panel pnlHeaderLine;
        private Panel pnlContent;
    }
}