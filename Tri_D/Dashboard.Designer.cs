namespace Tri_D
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.timelbl = new System.Windows.Forms.Label();
            this.tuaLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidePanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.manageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidePanel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.historyButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidePanel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.vacantnumLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.occupiednumLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.vacantLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.occupiedLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.carAvailabilityProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.parkingavailabilityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.vacantnumMOTORLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.occupiednumMOTORLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.motorAvailabilityProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.refreshLoad = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timenow = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.guna2Panel1.Controls.Add(this.timelbl);
            this.guna2Panel1.Controls.Add(this.tuaLabel);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.menuButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.guna2Panel1.Location = new System.Drawing.Point(10, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(841, 61);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(590, 24);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(57, 24);
            this.timelbl.TabIndex = 3;
            this.timelbl.Text = "Time";
            // 
            // tuaLabel
            // 
            this.tuaLabel.AllowParentOverrides = false;
            this.tuaLabel.AutoEllipsis = false;
            this.tuaLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tuaLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.tuaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.tuaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.tuaLabel.Location = new System.Drawing.Point(133, 11);
            this.tuaLabel.Name = "tuaLabel";
            this.tuaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tuaLabel.Size = new System.Drawing.Size(418, 37);
            this.tuaLabel.TabIndex = 2;
            this.tuaLabel.Text = "TUA Parking Management System";
            this.tuaLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.tuaLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.ActiveImage = ((System.Drawing.Image)(resources.GetObject("menuButton.ActiveImage")));
            this.menuButton.AllowAnimations = true;
            this.menuButton.AllowBuffering = false;
            this.menuButton.AllowToggling = false;
            this.menuButton.AllowZooming = true;
            this.menuButton.AllowZoomingOnFocus = false;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("menuButton.ErrorImage")));
            this.menuButton.FadeWhenInactive = false;
            this.menuButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("menuButton.ImageActive")));
            this.menuButton.ImageLocation = null;
            this.menuButton.ImageMargin = 0;
            this.menuButton.ImageSize = new System.Drawing.Size(42, 38);
            this.menuButton.ImageZoomSize = new System.Drawing.Size(43, 39);
            this.menuButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("menuButton.InitialImage")));
            this.menuButton.Location = new System.Drawing.Point(15, 11);
            this.menuButton.Name = "menuButton";
            this.menuButton.Rotation = 0;
            this.menuButton.ShowActiveImage = true;
            this.menuButton.ShowCursorChanges = true;
            this.menuButton.ShowImageBorders = false;
            this.menuButton.ShowSizeMarkers = false;
            this.menuButton.Size = new System.Drawing.Size(43, 39);
            this.menuButton.TabIndex = 0;
            this.menuButton.ToolTipText = "";
            this.menuButton.WaitOnLoad = false;
            this.menuButton.Zoom = 0;
            this.menuButton.ZoomSpeed = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.sidePanel);
            this.sidebar.Controls.Add(this.sidePanel2);
            this.sidebar.Controls.Add(this.sidePanel3);
            this.sidebar.Controls.Add(this.sidePanel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(206, 451);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(10, 451);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 61);
            this.panel1.TabIndex = 2;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sidePanel.BorderRadius = 200;
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.sidePanel.Location = new System.Drawing.Point(3, 70);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.ShadowDecoration.Parent = this.sidePanel;
            this.sidePanel.Size = new System.Drawing.Size(200, 46);
            this.sidePanel.TabIndex = 3;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardButton.BackgroundImage")));
            this.dashboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dashboardButton.CheckedState.Parent = this.dashboardButton;
            this.dashboardButton.HoverState.Parent = this.dashboardButton;
            this.dashboardButton.Location = new System.Drawing.Point(-12, -10);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.PressedState.Parent = this.dashboardButton;
            this.dashboardButton.Size = new System.Drawing.Size(224, 66);
            this.dashboardButton.TabIndex = 4;
            // 
            // sidePanel2
            // 
            this.sidePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sidePanel2.BorderRadius = 200;
            this.sidePanel2.Controls.Add(this.manageButton);
            this.sidePanel2.Location = new System.Drawing.Point(3, 122);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.ShadowDecoration.Parent = this.sidePanel2;
            this.sidePanel2.Size = new System.Drawing.Size(200, 46);
            this.sidePanel2.TabIndex = 4;
            // 
            // manageButton
            // 
            this.manageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manageButton.BackgroundImage")));
            this.manageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manageButton.CheckedState.Parent = this.manageButton;
            this.manageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageButton.HoverState.Parent = this.manageButton;
            this.manageButton.Location = new System.Drawing.Point(0, 0);
            this.manageButton.Name = "manageButton";
            this.manageButton.PressedState.Parent = this.manageButton;
            this.manageButton.Size = new System.Drawing.Size(196, 52);
            this.manageButton.TabIndex = 5;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // sidePanel3
            // 
            this.sidePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sidePanel3.BorderRadius = 200;
            this.sidePanel3.Controls.Add(this.historyButton);
            this.sidePanel3.Location = new System.Drawing.Point(3, 174);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.ShadowDecoration.Parent = this.sidePanel3;
            this.sidePanel3.Size = new System.Drawing.Size(200, 46);
            this.sidePanel3.TabIndex = 4;
            // 
            // historyButton
            // 
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyButton.BackgroundImage")));
            this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.historyButton.CheckedState.Parent = this.historyButton;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.HoverState.Parent = this.historyButton;
            this.historyButton.Location = new System.Drawing.Point(0, 0);
            this.historyButton.Name = "historyButton";
            this.historyButton.PressedState.Parent = this.historyButton;
            this.historyButton.Size = new System.Drawing.Size(196, 52);
            this.historyButton.TabIndex = 6;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // sidePanel4
            // 
            this.sidePanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sidePanel4.BorderRadius = 200;
            this.sidePanel4.Controls.Add(this.logoutButton);
            this.sidePanel4.Location = new System.Drawing.Point(3, 226);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.ShadowDecoration.Parent = this.sidePanel4;
            this.sidePanel4.Size = new System.Drawing.Size(200, 46);
            this.sidePanel4.TabIndex = 4;
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.CheckedState.Parent = this.logoutButton;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.HoverState.Parent = this.logoutButton;
            this.logoutButton.Location = new System.Drawing.Point(0, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.PressedState.Parent = this.logoutButton;
            this.logoutButton.Size = new System.Drawing.Size(196, 52);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Panel2.Controls.Add(this.vacantnumLabel);
            this.guna2Panel2.Controls.Add(this.occupiednumLabel);
            this.guna2Panel2.Controls.Add(this.vacantLabel);
            this.guna2Panel2.Controls.Add(this.occupiedLabel);
            this.guna2Panel2.Controls.Add(this.carAvailabilityProgress);
            this.guna2Panel2.Controls.Add(this.parkingavailabilityLabel);
            this.guna2Panel2.Location = new System.Drawing.Point(42, 104);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(243, 113);
            this.guna2Panel2.TabIndex = 2;
            // 
            // vacantnumLabel
            // 
            this.vacantnumLabel.AllowParentOverrides = false;
            this.vacantnumLabel.AutoEllipsis = false;
            this.vacantnumLabel.CursorType = null;
            this.vacantnumLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacantnumLabel.ForeColor = System.Drawing.Color.Green;
            this.vacantnumLabel.Location = new System.Drawing.Point(190, 49);
            this.vacantnumLabel.Name = "vacantnumLabel";
            this.vacantnumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vacantnumLabel.Size = new System.Drawing.Size(6, 15);
            this.vacantnumLabel.TabIndex = 6;
            this.vacantnumLabel.Text = "0";
            this.vacantnumLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vacantnumLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // occupiednumLabel
            // 
            this.occupiednumLabel.AllowParentOverrides = false;
            this.occupiednumLabel.AutoEllipsis = false;
            this.occupiednumLabel.CursorType = null;
            this.occupiednumLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.occupiednumLabel.ForeColor = System.Drawing.Color.Red;
            this.occupiednumLabel.Location = new System.Drawing.Point(30, 50);
            this.occupiednumLabel.Name = "occupiednumLabel";
            this.occupiednumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.occupiednumLabel.Size = new System.Drawing.Size(6, 15);
            this.occupiednumLabel.TabIndex = 5;
            this.occupiednumLabel.Text = "0";
            this.occupiednumLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.occupiednumLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // vacantLabel
            // 
            this.vacantLabel.AllowParentOverrides = false;
            this.vacantLabel.AutoEllipsis = false;
            this.vacantLabel.CursorType = null;
            this.vacantLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacantLabel.Location = new System.Drawing.Point(180, 29);
            this.vacantLabel.Name = "vacantLabel";
            this.vacantLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vacantLabel.Size = new System.Drawing.Size(36, 15);
            this.vacantLabel.TabIndex = 4;
            this.vacantLabel.Text = "Vacant";
            this.vacantLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vacantLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AllowParentOverrides = false;
            this.occupiedLabel.AutoEllipsis = false;
            this.occupiedLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.occupiedLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.occupiedLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.occupiedLabel.Location = new System.Drawing.Point(13, 29);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.occupiedLabel.Size = new System.Drawing.Size(51, 15);
            this.occupiedLabel.TabIndex = 3;
            this.occupiedLabel.Text = "Occupied";
            this.occupiedLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.occupiedLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // carAvailabilityProgress
            // 
            this.carAvailabilityProgress.AutoRoundedCorners = true;
            this.carAvailabilityProgress.BackColor = System.Drawing.Color.Transparent;
            this.carAvailabilityProgress.BorderRadius = 14;
            this.carAvailabilityProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.carAvailabilityProgress.ForeColor = System.Drawing.Color.Lime;
            this.carAvailabilityProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.carAvailabilityProgress.Location = new System.Drawing.Point(13, 70);
            this.carAvailabilityProgress.Maximum = 75;
            this.carAvailabilityProgress.Name = "carAvailabilityProgress";
            this.carAvailabilityProgress.ProgressColor = System.Drawing.Color.Red;
            this.carAvailabilityProgress.ProgressColor2 = System.Drawing.Color.Red;
            this.carAvailabilityProgress.ShadowDecoration.Parent = this.carAvailabilityProgress;
            this.carAvailabilityProgress.ShowPercentage = true;
            this.carAvailabilityProgress.Size = new System.Drawing.Size(216, 30);
            this.carAvailabilityProgress.TabIndex = 1;
            this.carAvailabilityProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.carAvailabilityProgress.UseTransparentBackground = true;
            this.carAvailabilityProgress.Value = 8;
            // 
            // parkingavailabilityLabel
            // 
            this.parkingavailabilityLabel.AllowParentOverrides = false;
            this.parkingavailabilityLabel.AutoEllipsis = false;
            this.parkingavailabilityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.parkingavailabilityLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.parkingavailabilityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.parkingavailabilityLabel.Location = new System.Drawing.Point(13, 3);
            this.parkingavailabilityLabel.Name = "parkingavailabilityLabel";
            this.parkingavailabilityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parkingavailabilityLabel.Size = new System.Drawing.Size(166, 20);
            this.parkingavailabilityLabel.TabIndex = 0;
            this.parkingavailabilityLabel.Text = "Parking Availability(Car)";
            this.parkingavailabilityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.parkingavailabilityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Panel3.Controls.Add(this.vacantnumMOTORLabel);
            this.guna2Panel3.Controls.Add(this.occupiednumMOTORLabel);
            this.guna2Panel3.Controls.Add(this.bunifuLabel3);
            this.guna2Panel3.Controls.Add(this.bunifuLabel4);
            this.guna2Panel3.Controls.Add(this.motorAvailabilityProgress);
            this.guna2Panel3.Controls.Add(this.bunifuLabel5);
            this.guna2Panel3.Location = new System.Drawing.Point(42, 260);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(247, 113);
            this.guna2Panel3.TabIndex = 7;
            // 
            // vacantnumMOTORLabel
            // 
            this.vacantnumMOTORLabel.AllowParentOverrides = false;
            this.vacantnumMOTORLabel.AutoEllipsis = false;
            this.vacantnumMOTORLabel.CursorType = null;
            this.vacantnumMOTORLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacantnumMOTORLabel.ForeColor = System.Drawing.Color.Green;
            this.vacantnumMOTORLabel.Location = new System.Drawing.Point(197, 49);
            this.vacantnumMOTORLabel.Name = "vacantnumMOTORLabel";
            this.vacantnumMOTORLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vacantnumMOTORLabel.Size = new System.Drawing.Size(6, 15);
            this.vacantnumMOTORLabel.TabIndex = 6;
            this.vacantnumMOTORLabel.Text = "0";
            this.vacantnumMOTORLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vacantnumMOTORLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // occupiednumMOTORLabel
            // 
            this.occupiednumMOTORLabel.AllowParentOverrides = false;
            this.occupiednumMOTORLabel.AutoEllipsis = false;
            this.occupiednumMOTORLabel.CursorType = null;
            this.occupiednumMOTORLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.occupiednumMOTORLabel.ForeColor = System.Drawing.Color.Red;
            this.occupiednumMOTORLabel.Location = new System.Drawing.Point(30, 50);
            this.occupiednumMOTORLabel.Name = "occupiednumMOTORLabel";
            this.occupiednumMOTORLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.occupiednumMOTORLabel.Size = new System.Drawing.Size(6, 15);
            this.occupiednumMOTORLabel.TabIndex = 5;
            this.occupiednumMOTORLabel.Text = "0";
            this.occupiednumMOTORLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.occupiednumMOTORLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(187, 29);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(36, 15);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Vacant";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(13, 29);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(51, 15);
            this.bunifuLabel4.TabIndex = 3;
            this.bunifuLabel4.Text = "Occupied";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // motorAvailabilityProgress
            // 
            this.motorAvailabilityProgress.BackColor = System.Drawing.Color.Transparent;
            this.motorAvailabilityProgress.BorderRadius = 17;
            this.motorAvailabilityProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.motorAvailabilityProgress.ForeColor = System.Drawing.Color.Lime;
            this.motorAvailabilityProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.motorAvailabilityProgress.Location = new System.Drawing.Point(13, 70);
            this.motorAvailabilityProgress.Name = "motorAvailabilityProgress";
            this.motorAvailabilityProgress.ProgressColor = System.Drawing.Color.Red;
            this.motorAvailabilityProgress.ProgressColor2 = System.Drawing.Color.Red;
            this.motorAvailabilityProgress.ShadowDecoration.Parent = this.motorAvailabilityProgress;
            this.motorAvailabilityProgress.Size = new System.Drawing.Size(218, 30);
            this.motorAvailabilityProgress.TabIndex = 1;
            this.motorAvailabilityProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.motorAvailabilityProgress.Value = 20;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(9, 3);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(220, 20);
            this.bunifuLabel5.TabIndex = 0;
            this.bunifuLabel5.Text = "Parking Availability(Motorcycle)";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // refreshLoad
            // 
            this.refreshLoad.Interval = 5;
            this.refreshLoad.Tick += new System.EventHandler(this.refreshLoad_Tick);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(360, 86);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "MorningHrs";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "EveningHrs";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(432, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timenow
            // 
            this.timenow.Tick += new System.EventHandler(this.timenow_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 452);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel4.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton menuButton;
        private Bunifu.UI.WinForms.BunifuLabel tuaLabel;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel sidePanel;
        private Guna.UI2.WinForms.Guna2ImageButton dashboardButton;
        private Guna.UI2.WinForms.Guna2Panel sidePanel2;
        private Guna.UI2.WinForms.Guna2ImageButton manageButton;
        private Guna.UI2.WinForms.Guna2Panel sidePanel3;
        private Guna.UI2.WinForms.Guna2ImageButton historyButton;
        private Guna.UI2.WinForms.Guna2Panel sidePanel4;
        private Guna.UI2.WinForms.Guna2ImageButton logoutButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Bunifu.UI.WinForms.BunifuLabel parkingavailabilityLabel;
        private Bunifu.UI.WinForms.BunifuLabel vacantnumLabel;
        private Bunifu.UI.WinForms.BunifuLabel occupiednumLabel;
        private Bunifu.UI.WinForms.BunifuLabel vacantLabel;
        private Bunifu.UI.WinForms.BunifuLabel occupiedLabel;
        private Guna.UI2.WinForms.Guna2ProgressBar carAvailabilityProgress;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Bunifu.UI.WinForms.BunifuLabel vacantnumMOTORLabel;
        private Bunifu.UI.WinForms.BunifuLabel occupiednumMOTORLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Guna.UI2.WinForms.Guna2ProgressBar motorAvailabilityProgress;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.Timer refreshLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Timer timenow;
    }
}