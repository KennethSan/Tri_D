namespace Tri_D
{
    partial class Fullhistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fullhistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.tuaLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.fulltbl = new Bunifu.UI.WinForms.BunifuPanel();
            this.Details = new Guna.UI2.WinForms.Guna2Button();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.typeResultlbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.fullnameResultlbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.typeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.fullnameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.idLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ownerID = new System.Windows.Forms.Label();
            this.fullHistoryTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.typeHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fulltbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullHistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
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
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tuaLabel);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.menuButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(979, 64);
            this.guna2Panel1.TabIndex = 7;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
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
            this.menuButton.ImageSize = new System.Drawing.Size(53, 48);
            this.menuButton.ImageZoomSize = new System.Drawing.Size(54, 49);
            this.menuButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("menuButton.InitialImage")));
            this.menuButton.Location = new System.Drawing.Point(10, 10);
            this.menuButton.Name = "menuButton";
            this.menuButton.Rotation = 0;
            this.menuButton.ShowActiveImage = true;
            this.menuButton.ShowCursorChanges = true;
            this.menuButton.ShowImageBorders = false;
            this.menuButton.ShowSizeMarkers = false;
            this.menuButton.Size = new System.Drawing.Size(54, 49);
            this.menuButton.TabIndex = 0;
            this.menuButton.ToolTipText = "";
            this.menuButton.WaitOnLoad = false;
            this.menuButton.Zoom = 0;
            this.menuButton.ZoomSpeed = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // fulltbl
            // 
            this.fulltbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.fulltbl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fulltbl.BackgroundImage")));
            this.fulltbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fulltbl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.fulltbl.BorderRadius = 3;
            this.fulltbl.BorderThickness = 1;
            this.fulltbl.Controls.Add(this.Details);
            this.fulltbl.Controls.Add(this.printBtn);
            this.fulltbl.Controls.Add(this.typeResultlbl);
            this.fulltbl.Controls.Add(this.fullnameResultlbl);
            this.fulltbl.Controls.Add(this.typeLabel);
            this.fulltbl.Controls.Add(this.fullnameLabel);
            this.fulltbl.Controls.Add(this.idLabel);
            this.fulltbl.Controls.Add(this.ownerID);
            this.fulltbl.Controls.Add(this.fullHistoryTable);
            this.fulltbl.Location = new System.Drawing.Point(12, 70);
            this.fulltbl.Name = "fulltbl";
            this.fulltbl.ShowBorders = true;
            this.fulltbl.Size = new System.Drawing.Size(955, 497);
            this.fulltbl.TabIndex = 9;
            // 
            // Details
            // 
            this.Details.CheckedState.Parent = this.Details;
            this.Details.CustomImages.Parent = this.Details;
            this.Details.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Details.ForeColor = System.Drawing.Color.White;
            this.Details.HoverState.Parent = this.Details;
            this.Details.Location = new System.Drawing.Point(480, 445);
            this.Details.Name = "Details";
            this.Details.ShadowDecoration.Parent = this.Details;
            this.Details.Size = new System.Drawing.Size(180, 45);
            this.Details.TabIndex = 10;
            this.Details.Text = "Details";
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // printBtn
            // 
            this.printBtn.CheckedState.Parent = this.printBtn;
            this.printBtn.CustomImages.Parent = this.printBtn;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.HoverState.Parent = this.printBtn;
            this.printBtn.Location = new System.Drawing.Point(196, 445);
            this.printBtn.Name = "printBtn";
            this.printBtn.ShadowDecoration.Parent = this.printBtn;
            this.printBtn.Size = new System.Drawing.Size(180, 45);
            this.printBtn.TabIndex = 9;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // typeResultlbl
            // 
            this.typeResultlbl.AllowParentOverrides = false;
            this.typeResultlbl.AutoEllipsis = false;
            this.typeResultlbl.CursorType = null;
            this.typeResultlbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typeResultlbl.Location = new System.Drawing.Point(64, 54);
            this.typeResultlbl.Name = "typeResultlbl";
            this.typeResultlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeResultlbl.Size = new System.Drawing.Size(69, 15);
            this.typeResultlbl.TabIndex = 8;
            this.typeResultlbl.Text = "bunifuLabel2";
            this.typeResultlbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.typeResultlbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // fullnameResultlbl
            // 
            this.fullnameResultlbl.AllowParentOverrides = false;
            this.fullnameResultlbl.AutoEllipsis = false;
            this.fullnameResultlbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fullnameResultlbl.CursorType = System.Windows.Forms.Cursors.Default;
            this.fullnameResultlbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullnameResultlbl.Location = new System.Drawing.Point(102, 17);
            this.fullnameResultlbl.Name = "fullnameResultlbl";
            this.fullnameResultlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fullnameResultlbl.Size = new System.Drawing.Size(69, 15);
            this.fullnameResultlbl.TabIndex = 7;
            this.fullnameResultlbl.Text = "bunifuLabel1";
            this.fullnameResultlbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.fullnameResultlbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // typeLabel
            // 
            this.typeLabel.AllowParentOverrides = false;
            this.typeLabel.AutoEllipsis = false;
            this.typeLabel.CursorType = null;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.typeLabel.Location = new System.Drawing.Point(30, 54);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeLabel.Size = new System.Drawing.Size(28, 15);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type:";
            this.typeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.typeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AllowParentOverrides = false;
            this.fullnameLabel.AutoEllipsis = false;
            this.fullnameLabel.CursorType = null;
            this.fullnameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.fullnameLabel.Location = new System.Drawing.Point(30, 17);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fullnameLabel.Size = new System.Drawing.Size(57, 15);
            this.fullnameLabel.TabIndex = 5;
            this.fullnameLabel.Text = "Full Name:";
            this.fullnameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.fullnameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // idLabel
            // 
            this.idLabel.AllowParentOverrides = false;
            this.idLabel.AutoEllipsis = false;
            this.idLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.idLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.idLabel.Location = new System.Drawing.Point(674, 29);
            this.idLabel.Name = "idLabel";
            this.idLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idLabel.Size = new System.Drawing.Size(120, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Identification Number:";
            this.idLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.idLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ownerID
            // 
            this.ownerID.AutoSize = true;
            this.ownerID.Location = new System.Drawing.Point(800, 31);
            this.ownerID.Name = "ownerID";
            this.ownerID.Size = new System.Drawing.Size(67, 13);
            this.ownerID.TabIndex = 3;
            this.ownerID.Text = "2022304056";
            // 
            // fullHistoryTable
            // 
            this.fullHistoryTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.fullHistoryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fullHistoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fullHistoryTable.BackgroundColor = System.Drawing.Color.White;
            this.fullHistoryTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fullHistoryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fullHistoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullHistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fullHistoryTable.ColumnHeadersHeight = 40;
            this.fullHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeHeader,
            this.plateHeader,
            this.dateHeader,
            this.timeinHeader,
            this.timeoutHeader,
            this.durationHeader,
            this.reasonHeader,
            this.slotHeader,
            this.dutyHeader});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fullHistoryTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.fullHistoryTable.EnableHeadersVisualStyles = false;
            this.fullHistoryTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.fullHistoryTable.Location = new System.Drawing.Point(30, 75);
            this.fullHistoryTable.Name = "fullHistoryTable";
            this.fullHistoryTable.RowHeadersVisible = false;
            this.fullHistoryTable.RowTemplate.Height = 40;
            this.fullHistoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullHistoryTable.Size = new System.Drawing.Size(901, 364);
            this.fullHistoryTable.TabIndex = 2;
            this.fullHistoryTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.fullHistoryTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.fullHistoryTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.fullHistoryTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.fullHistoryTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.fullHistoryTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.fullHistoryTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.fullHistoryTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.fullHistoryTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(176)))));
            this.fullHistoryTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.fullHistoryTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fullHistoryTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.fullHistoryTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.fullHistoryTable.ThemeStyle.HeaderStyle.Height = 40;
            this.fullHistoryTable.ThemeStyle.ReadOnly = false;
            this.fullHistoryTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.fullHistoryTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fullHistoryTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fullHistoryTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(89)))));
            this.fullHistoryTable.ThemeStyle.RowsStyle.Height = 40;
            this.fullHistoryTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.fullHistoryTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(89)))));
            // 
            // typeHeader
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.typeHeader.DefaultCellStyle = dataGridViewCellStyle3;
            this.typeHeader.HeaderText = "Vehicle Type";
            this.typeHeader.Name = "typeHeader";
            this.typeHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plateHeader
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.plateHeader.DefaultCellStyle = dataGridViewCellStyle4;
            this.plateHeader.HeaderText = "Plate #";
            this.plateHeader.Name = "plateHeader";
            this.plateHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateHeader
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateHeader.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateHeader.HeaderText = "Date";
            this.dateHeader.Name = "dateHeader";
            this.dateHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // timeinHeader
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.timeinHeader.DefaultCellStyle = dataGridViewCellStyle6;
            this.timeinHeader.HeaderText = "Time-In";
            this.timeinHeader.Name = "timeinHeader";
            this.timeinHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // timeoutHeader
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.timeoutHeader.DefaultCellStyle = dataGridViewCellStyle7;
            this.timeoutHeader.HeaderText = "Time-Out";
            this.timeoutHeader.Name = "timeoutHeader";
            this.timeoutHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // durationHeader
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.durationHeader.DefaultCellStyle = dataGridViewCellStyle8;
            this.durationHeader.HeaderText = "Duration";
            this.durationHeader.Name = "durationHeader";
            this.durationHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reasonHeader
            // 
            this.reasonHeader.HeaderText = "Reason";
            this.reasonHeader.Name = "reasonHeader";
            // 
            // slotHeader
            // 
            this.slotHeader.HeaderText = "Slot";
            this.slotHeader.Name = "slotHeader";
            // 
            // dutyHeader
            // 
            this.dutyHeader.HeaderText = "Duty";
            this.dutyHeader.Name = "dutyHeader";
            // 
            // Fullhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 579);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.fulltbl);
            this.Name = "Fullhistory";
            this.Text = "Fullhistory";
            this.Load += new System.EventHandler(this.Fullhistory_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fulltbl.ResumeLayout(false);
            this.fulltbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullHistoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton menuButton;
        private Guna.UI2.WinForms.Guna2DataGridView fullHistoryTable;
        private System.Windows.Forms.Timer sidebarTimer;
        private Bunifu.UI.WinForms.BunifuLabel tuaLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.UI.WinForms.BunifuPanel fulltbl;
        private System.Windows.Forms.Label ownerID;
        private Bunifu.UI.WinForms.BunifuLabel idLabel;
        private Bunifu.UI.WinForms.BunifuLabel typeResultlbl;
        private Bunifu.UI.WinForms.BunifuLabel fullnameResultlbl;
        private Bunifu.UI.WinForms.BunifuLabel typeLabel;
        private Bunifu.UI.WinForms.BunifuLabel fullnameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyHeader;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2Button Details;
    }
}