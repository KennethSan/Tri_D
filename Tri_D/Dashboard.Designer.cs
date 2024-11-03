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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tuaLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidePanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.sidePanel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.sidePanel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.manageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.historyButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.logoutButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.guna2Panel1.Controls.Add(this.tuaLabel);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.menuButton);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 64);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tuaLabel
            // 
            this.tuaLabel.AllowParentOverrides = false;
            this.tuaLabel.AutoEllipsis = false;
            this.tuaLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tuaLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.tuaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.tuaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.tuaLabel.Location = new System.Drawing.Point(279, 12);
            this.tuaLabel.Name = "tuaLabel";
            this.tuaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tuaLabel.Size = new System.Drawing.Size(374, 32);
            this.tuaLabel.TabIndex = 2;
            this.tuaLabel.Text = "TUA Parking Management System";
            this.tuaLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.tuaLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.sidebar.Size = new System.Drawing.Size(206, 450);
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
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 3);
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
            this.menuButton.Location = new System.Drawing.Point(12, 12);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sidebar);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}