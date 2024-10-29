namespace Tri_D
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.welcomeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.logintocontinueLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.userTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AllowParentOverrides = false;
            this.welcomeLabel.AutoEllipsis = false;
            this.welcomeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.welcomeLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.Location = new System.Drawing.Point(23, 16);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcomeLabel.Size = new System.Drawing.Size(210, 40);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome Back!";
            this.welcomeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.welcomeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.welcomeLabel.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // logintocontinueLabel
            // 
            this.logintocontinueLabel.AllowParentOverrides = false;
            this.logintocontinueLabel.AutoEllipsis = false;
            this.logintocontinueLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.logintocontinueLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.logintocontinueLabel.EllipsisFormat = Bunifu.UI.WinForms.Ellipsis.EllipsisFormat.Start;
            this.logintocontinueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.logintocontinueLabel.Location = new System.Drawing.Point(63, 62);
            this.logintocontinueLabel.Name = "logintocontinueLabel";
            this.logintocontinueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logintocontinueLabel.Size = new System.Drawing.Size(133, 21);
            this.logintocontinueLabel.TabIndex = 1;
            this.logintocontinueLabel.Text = "Log in to continue";
            this.logintocontinueLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.logintocontinueLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // userTextbox
            // 
            this.userTextbox.AcceptsTab = true;
            this.userTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTextbox.DefaultText = "";
            this.userTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTextbox.DisabledState.Parent = this.userTextbox;
            this.userTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTextbox.FocusedState.Parent = this.userTextbox;
            this.userTextbox.ForeColor = System.Drawing.Color.Black;
            this.userTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTextbox.HoverState.Parent = this.userTextbox;
            this.userTextbox.Location = new System.Drawing.Point(23, 101);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.PasswordChar = '\0';
            this.userTextbox.PlaceholderText = "Username";
            this.userTextbox.SelectedText = "";
            this.userTextbox.ShadowDecoration.Parent = this.userTextbox;
            this.userTextbox.Size = new System.Drawing.Size(200, 36);
            this.userTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.DefaultText = "";
            this.passwordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.DisabledState.Parent = this.passwordTextbox;
            this.passwordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.FocusedState.Parent = this.passwordTextbox;
            this.passwordTextbox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(23, 155);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '\0';
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(200, 36);
            this.passwordTextbox.TabIndex = 3;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.EllipsisFormat = Bunifu.UI.WinForms.Ellipsis.EllipsisFormat.Start;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(23, 197);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(65, 11);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Forgot Password?";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(176)))));
            this.loginButton.BorderRadius = 5;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(91)))), ((int)(((byte)(99)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(122, 223);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(101, 32);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.loginButton);
            this.guna2Panel1.Controls.Add(this.welcomeLabel);
            this.guna2Panel1.Controls.Add(this.bunifuLabel1);
            this.guna2Panel1.Controls.Add(this.logintocontinueLabel);
            this.guna2Panel1.Controls.Add(this.passwordTextbox);
            this.guna2Panel1.Controls.Add(this.userTextbox);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(176)))));
            this.guna2Panel1.Location = new System.Drawing.Point(504, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(247, 387);
            this.guna2Panel1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tri_D.Properties.Resources.TRI_D_DESKTOP_DESIGNS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel welcomeLabel;
        private Bunifu.UI.WinForms.BunifuLabel logintocontinueLabel;
        private Guna.UI2.WinForms.Guna2TextBox userTextbox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

