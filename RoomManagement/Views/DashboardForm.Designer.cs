namespace RoomManagement.Views
{
    partial class DashboardForm
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
            flowCards = new FlowLayoutPanel();
            pnlCardTotalRooms = new Panel();
            pnlIconTotalRooms = new Panel();
            pnlBarTotalRooms = new Panel();
            lblTotalRooms = new Label();
            lblTotalRoomsTitle = new Label();
            pnlCardAvailableRooms = new Panel();
            pnlIconAvailableRooms = new Panel();
            pnlBarAvailableRooms = new Panel();
            lblAvailableRooms = new Label();
            lblAvailableRoomsTitle = new Label();
            pnlCardPending = new Panel();
            pnlIconPending = new Panel();
            pnlBarPending = new Panel();
            lblPending = new Label();
            lblPendingTitle = new Label();
            pnlCardApproved = new Panel();
            pnlIconApproved = new Panel();
            pnlBarApproved = new Panel();
            lblApproved = new Label();
            lblApprovedTitle = new Label();
            pnlCardRejected = new Panel();
            pnlIconRejected = new Panel();
            pnlBarRejected = new Panel();
            lblRejected = new Label();
            lblRejectedTitle = new Label();
            pnlCardCancelRequests = new Panel();
            pnlIconCancelRequests = new Panel();
            pnlBarCancelRequests = new Panel();
            lblCancelRequests = new Label();
            lblCancelRequestsTitle = new Label();
            pnlCardStartingToday = new Panel();
            pnlIconStartingToday = new Panel();
            pnlBarStartingToday = new Panel();
            lblStartingToday = new Label();
            lblStartingTodayTitle = new Label();
            pnlCardUpcoming = new Panel();
            pnlIconUpcoming = new Panel();
            pnlBarUpcoming = new Panel();
            lblUpcoming = new Label();
            lblUpcomingTitle = new Label();
            pnlRecent = new Panel();
            dgvRecent = new DataGridView();
            colUser = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colPurpose = new DataGridViewTextBoxColumn();
            colDateTime = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlRecentLine = new Panel();
            btnRefresh = new Button();
            btnViewAll = new Button();
            txtSearch = new TextBox();
            lblRecent = new Label();
            flowCards.SuspendLayout();
            pnlCardTotalRooms.SuspendLayout();
            pnlIconTotalRooms.SuspendLayout();
            pnlCardAvailableRooms.SuspendLayout();
            pnlIconAvailableRooms.SuspendLayout();
            pnlCardPending.SuspendLayout();
            pnlIconPending.SuspendLayout();
            pnlCardApproved.SuspendLayout();
            pnlIconApproved.SuspendLayout();
            pnlCardRejected.SuspendLayout();
            pnlIconRejected.SuspendLayout();
            pnlCardCancelRequests.SuspendLayout();
            pnlIconCancelRequests.SuspendLayout();
            pnlCardStartingToday.SuspendLayout();
            pnlIconStartingToday.SuspendLayout();
            pnlCardUpcoming.SuspendLayout();
            pnlIconUpcoming.SuspendLayout();
            pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            //
            // flowCards
            //
            flowCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowCards.Controls.Add(pnlCardTotalRooms);
            flowCards.Controls.Add(pnlCardAvailableRooms);
            flowCards.Controls.Add(pnlCardPending);
            flowCards.Controls.Add(pnlCardApproved);
            flowCards.Controls.Add(pnlCardRejected);
            flowCards.Controls.Add(pnlCardCancelRequests);
            flowCards.Controls.Add(pnlCardStartingToday);
            flowCards.Controls.Add(pnlCardUpcoming);
            flowCards.Location = new Point(0, 0);
            flowCards.Name = "flowCards";
            flowCards.Size = new Size(973, 216);
            flowCards.TabIndex = 0;
            //
            // pnlCardTotalRooms
            //
            pnlCardTotalRooms.BackColor = Color.White;
            pnlCardTotalRooms.Controls.Add(lblTotalRoomsTitle);
            pnlCardTotalRooms.Controls.Add(lblTotalRooms);
            pnlCardTotalRooms.Controls.Add(pnlIconTotalRooms);
            pnlCardTotalRooms.Margin = new Padding(0, 0, 15, 16);
            pnlCardTotalRooms.Name = "pnlCardTotalRooms";
            pnlCardTotalRooms.Size = new Size(228, 92);
            pnlCardTotalRooms.TabIndex = 0;
            //
            // pnlIconTotalRooms
            //
            pnlIconTotalRooms.BackColor = Color.FromArgb(224, 242, 254);
            pnlIconTotalRooms.Controls.Add(pnlBarTotalRooms);
            pnlIconTotalRooms.Location = new Point(18, 20);
            pnlIconTotalRooms.Name = "pnlIconTotalRooms";
            pnlIconTotalRooms.Size = new Size(52, 52);
            pnlIconTotalRooms.TabIndex = 0;
            //
            // pnlBarTotalRooms
            //
            pnlBarTotalRooms.BackColor = Color.FromArgb(2, 132, 199);
            pnlBarTotalRooms.Location = new Point(23, 12);
            pnlBarTotalRooms.Name = "pnlBarTotalRooms";
            pnlBarTotalRooms.Size = new Size(6, 28);
            pnlBarTotalRooms.TabIndex = 0;
            //
            // lblTotalRooms
            //
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalRooms.ForeColor = Color.FromArgb(31, 41, 55);
            lblTotalRooms.Location = new Point(82, 14);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(33, 37);
            lblTotalRooms.TabIndex = 1;
            lblTotalRooms.Text = "0";
            //
            // lblTotalRoomsTitle
            //
            lblTotalRoomsTitle.AutoSize = true;
            lblTotalRoomsTitle.Font = new Font("Segoe UI", 9F);
            lblTotalRoomsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalRoomsTitle.Location = new Point(85, 54);
            lblTotalRoomsTitle.Name = "lblTotalRoomsTitle";
            lblTotalRoomsTitle.Size = new Size(100, 15);
            lblTotalRoomsTitle.TabIndex = 2;
            lblTotalRoomsTitle.Text = "Total Rooms";
            //
            // pnlCardAvailableRooms
            //
            pnlCardAvailableRooms.BackColor = Color.White;
            pnlCardAvailableRooms.Controls.Add(lblAvailableRoomsTitle);
            pnlCardAvailableRooms.Controls.Add(lblAvailableRooms);
            pnlCardAvailableRooms.Controls.Add(pnlIconAvailableRooms);
            pnlCardAvailableRooms.Margin = new Padding(0, 0, 15, 16);
            pnlCardAvailableRooms.Name = "pnlCardAvailableRooms";
            pnlCardAvailableRooms.Size = new Size(228, 92);
            pnlCardAvailableRooms.TabIndex = 1;
            //
            // pnlIconAvailableRooms
            //
            pnlIconAvailableRooms.BackColor = Color.FromArgb(240, 253, 244);
            pnlIconAvailableRooms.Controls.Add(pnlBarAvailableRooms);
            pnlIconAvailableRooms.Location = new Point(18, 20);
            pnlIconAvailableRooms.Name = "pnlIconAvailableRooms";
            pnlIconAvailableRooms.Size = new Size(52, 52);
            pnlIconAvailableRooms.TabIndex = 0;
            //
            // pnlBarAvailableRooms
            //
            pnlBarAvailableRooms.BackColor = Color.FromArgb(22, 163, 74);
            pnlBarAvailableRooms.Location = new Point(23, 12);
            pnlBarAvailableRooms.Name = "pnlBarAvailableRooms";
            pnlBarAvailableRooms.Size = new Size(6, 28);
            pnlBarAvailableRooms.TabIndex = 0;
            //
            // lblAvailableRooms
            //
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAvailableRooms.ForeColor = Color.FromArgb(31, 41, 55);
            lblAvailableRooms.Location = new Point(82, 14);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(33, 37);
            lblAvailableRooms.TabIndex = 1;
            lblAvailableRooms.Text = "0";
            //
            // lblAvailableRoomsTitle
            //
            lblAvailableRoomsTitle.AutoSize = true;
            lblAvailableRoomsTitle.Font = new Font("Segoe UI", 9F);
            lblAvailableRoomsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblAvailableRoomsTitle.Location = new Point(85, 54);
            lblAvailableRoomsTitle.Name = "lblAvailableRoomsTitle";
            lblAvailableRoomsTitle.Size = new Size(100, 15);
            lblAvailableRoomsTitle.TabIndex = 2;
            lblAvailableRoomsTitle.Text = "Available Rooms";
            //
            // pnlCardPending
            //
            pnlCardPending.BackColor = Color.White;
            pnlCardPending.Controls.Add(lblPendingTitle);
            pnlCardPending.Controls.Add(lblPending);
            pnlCardPending.Controls.Add(pnlIconPending);
            pnlCardPending.Margin = new Padding(0, 0, 15, 16);
            pnlCardPending.Name = "pnlCardPending";
            pnlCardPending.Size = new Size(228, 92);
            pnlCardPending.TabIndex = 2;
            //
            // pnlIconPending
            //
            pnlIconPending.BackColor = Color.FromArgb(240, 249, 255);
            pnlIconPending.Controls.Add(pnlBarPending);
            pnlIconPending.Location = new Point(18, 20);
            pnlIconPending.Name = "pnlIconPending";
            pnlIconPending.Size = new Size(52, 52);
            pnlIconPending.TabIndex = 0;
            //
            // pnlBarPending
            //
            pnlBarPending.BackColor = Color.FromArgb(2, 132, 199);
            pnlBarPending.Location = new Point(23, 12);
            pnlBarPending.Name = "pnlBarPending";
            pnlBarPending.Size = new Size(6, 28);
            pnlBarPending.TabIndex = 0;
            //
            // lblPending
            //
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPending.ForeColor = Color.FromArgb(31, 41, 55);
            lblPending.Location = new Point(82, 14);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(33, 37);
            lblPending.TabIndex = 1;
            lblPending.Text = "0";
            //
            // lblPendingTitle
            //
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 9F);
            lblPendingTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblPendingTitle.Location = new Point(85, 54);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(100, 15);
            lblPendingTitle.TabIndex = 2;
            lblPendingTitle.Text = "Pending Bookings";
            //
            // pnlCardApproved
            //
            pnlCardApproved.BackColor = Color.White;
            pnlCardApproved.Controls.Add(lblApprovedTitle);
            pnlCardApproved.Controls.Add(lblApproved);
            pnlCardApproved.Controls.Add(pnlIconApproved);
            pnlCardApproved.Margin = new Padding(0, 0, 15, 16);
            pnlCardApproved.Name = "pnlCardApproved";
            pnlCardApproved.Size = new Size(228, 92);
            pnlCardApproved.TabIndex = 3;
            //
            // pnlIconApproved
            //
            pnlIconApproved.BackColor = Color.FromArgb(240, 253, 244);
            pnlIconApproved.Controls.Add(pnlBarApproved);
            pnlIconApproved.Location = new Point(18, 20);
            pnlIconApproved.Name = "pnlIconApproved";
            pnlIconApproved.Size = new Size(52, 52);
            pnlIconApproved.TabIndex = 0;
            //
            // pnlBarApproved
            //
            pnlBarApproved.BackColor = Color.FromArgb(22, 163, 74);
            pnlBarApproved.Location = new Point(23, 12);
            pnlBarApproved.Name = "pnlBarApproved";
            pnlBarApproved.Size = new Size(6, 28);
            pnlBarApproved.TabIndex = 0;
            //
            // lblApproved
            //
            lblApproved.AutoSize = true;
            lblApproved.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblApproved.ForeColor = Color.FromArgb(31, 41, 55);
            lblApproved.Location = new Point(82, 14);
            lblApproved.Name = "lblApproved";
            lblApproved.Size = new Size(33, 37);
            lblApproved.TabIndex = 1;
            lblApproved.Text = "0";
            //
            // lblApprovedTitle
            //
            lblApprovedTitle.AutoSize = true;
            lblApprovedTitle.Font = new Font("Segoe UI", 9F);
            lblApprovedTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblApprovedTitle.Location = new Point(85, 54);
            lblApprovedTitle.Name = "lblApprovedTitle";
            lblApprovedTitle.Size = new Size(100, 15);
            lblApprovedTitle.TabIndex = 2;
            lblApprovedTitle.Text = "Approved Bookings";
            //
            // pnlCardRejected
            //
            pnlCardRejected.BackColor = Color.White;
            pnlCardRejected.Controls.Add(lblRejectedTitle);
            pnlCardRejected.Controls.Add(lblRejected);
            pnlCardRejected.Controls.Add(pnlIconRejected);
            pnlCardRejected.Margin = new Padding(0, 0, 15, 16);
            pnlCardRejected.Name = "pnlCardRejected";
            pnlCardRejected.Size = new Size(228, 92);
            pnlCardRejected.TabIndex = 4;
            //
            // pnlIconRejected
            //
            pnlIconRejected.BackColor = Color.FromArgb(254, 242, 242);
            pnlIconRejected.Controls.Add(pnlBarRejected);
            pnlIconRejected.Location = new Point(18, 20);
            pnlIconRejected.Name = "pnlIconRejected";
            pnlIconRejected.Size = new Size(52, 52);
            pnlIconRejected.TabIndex = 0;
            //
            // pnlBarRejected
            //
            pnlBarRejected.BackColor = Color.FromArgb(220, 38, 38);
            pnlBarRejected.Location = new Point(23, 12);
            pnlBarRejected.Name = "pnlBarRejected";
            pnlBarRejected.Size = new Size(6, 28);
            pnlBarRejected.TabIndex = 0;
            //
            // lblRejected
            //
            lblRejected.AutoSize = true;
            lblRejected.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblRejected.ForeColor = Color.FromArgb(31, 41, 55);
            lblRejected.Location = new Point(82, 14);
            lblRejected.Name = "lblRejected";
            lblRejected.Size = new Size(33, 37);
            lblRejected.TabIndex = 1;
            lblRejected.Text = "0";
            //
            // lblRejectedTitle
            //
            lblRejectedTitle.AutoSize = true;
            lblRejectedTitle.Font = new Font("Segoe UI", 9F);
            lblRejectedTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblRejectedTitle.Location = new Point(85, 54);
            lblRejectedTitle.Name = "lblRejectedTitle";
            lblRejectedTitle.Size = new Size(100, 15);
            lblRejectedTitle.TabIndex = 2;
            lblRejectedTitle.Text = "Rejected Bookings";
            //
            // pnlCardCancelRequests
            //
            pnlCardCancelRequests.BackColor = Color.White;
            pnlCardCancelRequests.Controls.Add(lblCancelRequestsTitle);
            pnlCardCancelRequests.Controls.Add(lblCancelRequests);
            pnlCardCancelRequests.Controls.Add(pnlIconCancelRequests);
            pnlCardCancelRequests.Margin = new Padding(0, 0, 15, 16);
            pnlCardCancelRequests.Name = "pnlCardCancelRequests";
            pnlCardCancelRequests.Size = new Size(228, 92);
            pnlCardCancelRequests.TabIndex = 5;
            //
            // pnlIconCancelRequests
            //
            pnlIconCancelRequests.BackColor = Color.FromArgb(255, 251, 235);
            pnlIconCancelRequests.Controls.Add(pnlBarCancelRequests);
            pnlIconCancelRequests.Location = new Point(18, 20);
            pnlIconCancelRequests.Name = "pnlIconCancelRequests";
            pnlIconCancelRequests.Size = new Size(52, 52);
            pnlIconCancelRequests.TabIndex = 0;
            //
            // pnlBarCancelRequests
            //
            pnlBarCancelRequests.BackColor = Color.FromArgb(217, 119, 6);
            pnlBarCancelRequests.Location = new Point(23, 12);
            pnlBarCancelRequests.Name = "pnlBarCancelRequests";
            pnlBarCancelRequests.Size = new Size(6, 28);
            pnlBarCancelRequests.TabIndex = 0;
            //
            // lblCancelRequests
            //
            lblCancelRequests.AutoSize = true;
            lblCancelRequests.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCancelRequests.ForeColor = Color.FromArgb(31, 41, 55);
            lblCancelRequests.Location = new Point(82, 14);
            lblCancelRequests.Name = "lblCancelRequests";
            lblCancelRequests.Size = new Size(33, 37);
            lblCancelRequests.TabIndex = 1;
            lblCancelRequests.Text = "0";
            //
            // lblCancelRequestsTitle
            //
            lblCancelRequestsTitle.AutoSize = true;
            lblCancelRequestsTitle.Font = new Font("Segoe UI", 9F);
            lblCancelRequestsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblCancelRequestsTitle.Location = new Point(85, 54);
            lblCancelRequestsTitle.Name = "lblCancelRequestsTitle";
            lblCancelRequestsTitle.Size = new Size(100, 15);
            lblCancelRequestsTitle.TabIndex = 2;
            lblCancelRequestsTitle.Text = "Cancel Requests";
            pnlCardCancelRequests.Cursor = Cursors.Hand;
            pnlCardCancelRequests.Click += cardCancelRequests_Click;
            pnlIconCancelRequests.Cursor = Cursors.Hand;
            pnlIconCancelRequests.Click += cardCancelRequests_Click;
            pnlBarCancelRequests.Cursor = Cursors.Hand;
            pnlBarCancelRequests.Click += cardCancelRequests_Click;
            lblCancelRequests.Cursor = Cursors.Hand;
            lblCancelRequests.Click += cardCancelRequests_Click;
            lblCancelRequestsTitle.Cursor = Cursors.Hand;
            lblCancelRequestsTitle.Click += cardCancelRequests_Click;
            //
            // pnlCardStartingToday
            //
            pnlCardStartingToday.BackColor = Color.White;
            pnlCardStartingToday.Controls.Add(lblStartingTodayTitle);
            pnlCardStartingToday.Controls.Add(lblStartingToday);
            pnlCardStartingToday.Controls.Add(pnlIconStartingToday);
            pnlCardStartingToday.Margin = new Padding(0, 0, 15, 16);
            pnlCardStartingToday.Name = "pnlCardStartingToday";
            pnlCardStartingToday.Size = new Size(228, 92);
            pnlCardStartingToday.TabIndex = 6;
            //
            // pnlIconStartingToday
            //
            pnlIconStartingToday.BackColor = Color.FromArgb(255, 251, 235);
            pnlIconStartingToday.Controls.Add(pnlBarStartingToday);
            pnlIconStartingToday.Location = new Point(18, 20);
            pnlIconStartingToday.Name = "pnlIconStartingToday";
            pnlIconStartingToday.Size = new Size(52, 52);
            pnlIconStartingToday.TabIndex = 0;
            //
            // pnlBarStartingToday
            //
            pnlBarStartingToday.BackColor = Color.FromArgb(230, 165, 0);
            pnlBarStartingToday.Location = new Point(23, 12);
            pnlBarStartingToday.Name = "pnlBarStartingToday";
            pnlBarStartingToday.Size = new Size(6, 28);
            pnlBarStartingToday.TabIndex = 0;
            //
            // lblStartingToday
            //
            lblStartingToday.AutoSize = true;
            lblStartingToday.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStartingToday.ForeColor = Color.FromArgb(31, 41, 55);
            lblStartingToday.Location = new Point(82, 14);
            lblStartingToday.Name = "lblStartingToday";
            lblStartingToday.Size = new Size(33, 37);
            lblStartingToday.TabIndex = 1;
            lblStartingToday.Text = "0";
            //
            // lblStartingTodayTitle
            //
            lblStartingTodayTitle.AutoSize = true;
            lblStartingTodayTitle.Font = new Font("Segoe UI", 9F);
            lblStartingTodayTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblStartingTodayTitle.Location = new Point(85, 54);
            lblStartingTodayTitle.Name = "lblStartingTodayTitle";
            lblStartingTodayTitle.Size = new Size(100, 15);
            lblStartingTodayTitle.TabIndex = 2;
            lblStartingTodayTitle.Text = "Today's Bookings";
            //
            // pnlCardUpcoming
            //
            pnlCardUpcoming.BackColor = Color.White;
            pnlCardUpcoming.Controls.Add(lblUpcomingTitle);
            pnlCardUpcoming.Controls.Add(lblUpcoming);
            pnlCardUpcoming.Controls.Add(pnlIconUpcoming);
            pnlCardUpcoming.Margin = new Padding(0, 0, 15, 16);
            pnlCardUpcoming.Name = "pnlCardUpcoming";
            pnlCardUpcoming.Size = new Size(228, 92);
            pnlCardUpcoming.TabIndex = 7;
            //
            // pnlIconUpcoming
            //
            pnlIconUpcoming.BackColor = Color.FromArgb(224, 242, 254);
            pnlIconUpcoming.Controls.Add(pnlBarUpcoming);
            pnlIconUpcoming.Location = new Point(18, 20);
            pnlIconUpcoming.Name = "pnlIconUpcoming";
            pnlIconUpcoming.Size = new Size(52, 52);
            pnlIconUpcoming.TabIndex = 0;
            //
            // pnlBarUpcoming
            //
            pnlBarUpcoming.BackColor = Color.FromArgb(2, 132, 199);
            pnlBarUpcoming.Location = new Point(23, 12);
            pnlBarUpcoming.Name = "pnlBarUpcoming";
            pnlBarUpcoming.Size = new Size(6, 28);
            pnlBarUpcoming.TabIndex = 0;
            //
            // lblUpcoming
            //
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUpcoming.ForeColor = Color.FromArgb(31, 41, 55);
            lblUpcoming.Location = new Point(82, 14);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(33, 37);
            lblUpcoming.TabIndex = 1;
            lblUpcoming.Text = "0";
            //
            // lblUpcomingTitle
            //
            lblUpcomingTitle.AutoSize = true;
            lblUpcomingTitle.Font = new Font("Segoe UI", 9F);
            lblUpcomingTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblUpcomingTitle.Location = new Point(85, 54);
            lblUpcomingTitle.Name = "lblUpcomingTitle";
            lblUpcomingTitle.Size = new Size(100, 15);
            lblUpcomingTitle.TabIndex = 2;
            lblUpcomingTitle.Text = "Upcoming Bookings";
            //
            // pnlRecent
            //
            pnlRecent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecent.BackColor = Color.White;
            pnlRecent.Controls.Add(dgvRecent);
            pnlRecent.Controls.Add(pnlRecentLine);
            pnlRecent.Controls.Add(btnRefresh);
            pnlRecent.Controls.Add(btnViewAll);
            pnlRecent.Controls.Add(txtSearch);
            pnlRecent.Controls.Add(lblRecent);
            pnlRecent.Location = new Point(0, 228);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Size = new Size(973, 444);
            pnlRecent.TabIndex = 1;
            //
            // lblRecent
            //
            lblRecent.AutoSize = true;
            lblRecent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecent.ForeColor = Color.FromArgb(31, 41, 55);
            lblRecent.Location = new Point(18, 15);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(206, 21);
            lblRecent.TabIndex = 0;
            lblRecent.Text = "Recent Booking Requests";
            //
            // txtSearch
            //
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(515, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search requests...";
            txtSearch.Size = new Size(220, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            btnRefresh.Location = new Point(855, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 32);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnViewAll
            //
            btnViewAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewAll.BackColor = Color.FromArgb(2, 132, 199);
            btnViewAll.Cursor = Cursors.Hand;
            btnViewAll.FlatAppearance.BorderSize = 0;
            btnViewAll.FlatStyle = FlatStyle.Flat;
            btnViewAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewAll.ForeColor = Color.White;
            btnViewAll.Location = new Point(745, 10);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(100, 32);
            btnViewAll.TabIndex = 3;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = false;
            btnViewAll.Click += btnViewAll_Click;
            //
            // pnlRecentLine
            //
            pnlRecentLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecentLine.BackColor = Color.FromArgb(229, 231, 235);
            pnlRecentLine.Location = new Point(0, 52);
            pnlRecentLine.Name = "pnlRecentLine";
            pnlRecentLine.Size = new Size(973, 1);
            pnlRecentLine.TabIndex = 3;
            //
            // dgvRecent
            //
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.AllowUserToResizeRows = false;
            dgvRecent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridHeaderStyle.BackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridHeaderStyle.ForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.Padding = new Padding(8, 0, 0, 0);
            gridHeaderStyle.SelectionBackColor = Color.FromArgb(250, 251, 252);
            gridHeaderStyle.SelectionForeColor = Color.FromArgb(107, 114, 128);
            gridHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvRecent.ColumnHeadersDefaultCellStyle = gridHeaderStyle;
            dgvRecent.ColumnHeadersHeight = 42;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecent.Columns.AddRange(new DataGridViewColumn[] { colUser, colRoom, colPurpose, colDateTime, colStatus });
            gridCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridCellStyle.BackColor = Color.White;
            gridCellStyle.Font = new Font("Segoe UI", 9.75F);
            gridCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            gridCellStyle.Padding = new Padding(8, 0, 0, 0);
            gridCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            gridCellStyle.SelectionForeColor = Color.FromArgb(2, 132, 199);
            gridCellStyle.WrapMode = DataGridViewTriState.False;
            dgvRecent.DefaultCellStyle = gridCellStyle;
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.GridColor = Color.FromArgb(229, 231, 235);
            dgvRecent.Location = new Point(0, 53);
            dgvRecent.MultiSelect = false;
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowTemplate.Height = 44;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.Size = new Size(973, 391);
            dgvRecent.TabIndex = 4;
            dgvRecent.CellFormatting += dgvRecent_CellFormatting;
            dgvRecent.DataBindingComplete += dgvRecent_DataBindingComplete;
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
            colRoom.FillWeight = 90F;
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
            colDateTime.FillWeight = 170F;
            colDateTime.HeaderText = "DATE & TIME";
            colDateTime.Name = "colDateTime";
            //
            // colStatus
            //
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 90F;
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            //
            // DashboardForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(973, 672);
            Controls.Add(pnlRecent);
            Controls.Add(flowCards);
            Font = new Font("Segoe UI", 10F);
            Name = "DashboardForm";
            Load += DashboardForm_Load;
            Text = "Dashboard";
            flowCards.ResumeLayout(false);
            pnlCardTotalRooms.ResumeLayout(false);
            pnlCardTotalRooms.PerformLayout();
            pnlIconTotalRooms.ResumeLayout(false);
            pnlCardAvailableRooms.ResumeLayout(false);
            pnlCardAvailableRooms.PerformLayout();
            pnlIconAvailableRooms.ResumeLayout(false);
            pnlCardPending.ResumeLayout(false);
            pnlCardPending.PerformLayout();
            pnlIconPending.ResumeLayout(false);
            pnlCardApproved.ResumeLayout(false);
            pnlCardApproved.PerformLayout();
            pnlIconApproved.ResumeLayout(false);
            pnlCardRejected.ResumeLayout(false);
            pnlCardRejected.PerformLayout();
            pnlIconRejected.ResumeLayout(false);
            pnlCardCancelRequests.ResumeLayout(false);
            pnlCardCancelRequests.PerformLayout();
            pnlIconCancelRequests.ResumeLayout(false);
            pnlCardStartingToday.ResumeLayout(false);
            pnlCardStartingToday.PerformLayout();
            pnlIconStartingToday.ResumeLayout(false);
            pnlCardUpcoming.ResumeLayout(false);
            pnlCardUpcoming.PerformLayout();
            pnlIconUpcoming.ResumeLayout(false);
            pnlRecent.ResumeLayout(false);
            pnlRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowCards;
        private Panel pnlCardTotalRooms;
        private Panel pnlIconTotalRooms;
        private Panel pnlBarTotalRooms;
        private Label lblTotalRooms;
        private Label lblTotalRoomsTitle;
        private Panel pnlCardAvailableRooms;
        private Panel pnlIconAvailableRooms;
        private Panel pnlBarAvailableRooms;
        private Label lblAvailableRooms;
        private Label lblAvailableRoomsTitle;
        private Panel pnlCardPending;
        private Panel pnlIconPending;
        private Panel pnlBarPending;
        private Label lblPending;
        private Label lblPendingTitle;
        private Panel pnlCardApproved;
        private Panel pnlIconApproved;
        private Panel pnlBarApproved;
        private Label lblApproved;
        private Label lblApprovedTitle;
        private Panel pnlCardRejected;
        private Panel pnlIconRejected;
        private Panel pnlBarRejected;
        private Label lblRejected;
        private Label lblRejectedTitle;
        private Panel pnlCardCancelRequests;
        private Panel pnlIconCancelRequests;
        private Panel pnlBarCancelRequests;
        private Label lblCancelRequests;
        private Label lblCancelRequestsTitle;
        private Panel pnlCardStartingToday;
        private Panel pnlIconStartingToday;
        private Panel pnlBarStartingToday;
        private Label lblStartingToday;
        private Label lblStartingTodayTitle;
        private Panel pnlCardUpcoming;
        private Panel pnlIconUpcoming;
        private Panel pnlBarUpcoming;
        private Label lblUpcoming;
        private Label lblUpcomingTitle;
        private Panel pnlRecent;
        private Label lblRecent;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnViewAll;
        private Panel pnlRecentLine;
        private DataGridView dgvRecent;
        private DataGridViewTextBoxColumn colUser;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colPurpose;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewTextBoxColumn colStatus;
    }
}
