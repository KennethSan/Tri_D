namespace Tri_D
{
    partial class ExitUser
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
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.combo_drivers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.exit_button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(421, 78);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(170, 49);
            this.guna2HtmlLabel4.TabIndex = 21;
            this.guna2HtmlLabel4.Text = "Exit Driver";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(233, 160);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(166, 32);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Choose driver:";
            // 
            // combo_drivers
            // 
            this.combo_drivers.BackColor = System.Drawing.Color.Transparent;
            this.combo_drivers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_drivers.FocusedColor = System.Drawing.Color.Empty;
            this.combo_drivers.FocusedState.Parent = this.combo_drivers;
            this.combo_drivers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_drivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_drivers.FormattingEnabled = true;
            this.combo_drivers.HoverState.Parent = this.combo_drivers;
            this.combo_drivers.ItemHeight = 30;
            this.combo_drivers.ItemsAppearance.Parent = this.combo_drivers;
            this.combo_drivers.Location = new System.Drawing.Point(421, 160);
            this.combo_drivers.Margin = new System.Windows.Forms.Padding(4);
            this.combo_drivers.Name = "combo_drivers";
            this.combo_drivers.ShadowDecoration.Parent = this.combo_drivers;
            this.combo_drivers.Size = new System.Drawing.Size(364, 36);
            this.combo_drivers.TabIndex = 19;
            // 
            // exit_button
            // 
            this.exit_button.BorderRadius = 10;
            this.exit_button.CheckedState.Parent = this.exit_button;
            this.exit_button.CustomImages.Parent = this.exit_button;
            this.exit_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.HoverState.Parent = this.exit_button;
            this.exit_button.Location = new System.Drawing.Point(333, 267);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.ShadowDecoration.Parent = this.exit_button;
            this.exit_button.Size = new System.Drawing.Size(350, 68);
            this.exit_button.TabIndex = 22;
            this.exit_button.Text = "Exit";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ExitUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1031, 544);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.combo_drivers);
            this.Name = "ExitUser";
            this.Text = "ExitUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox combo_drivers;
        private Guna.UI2.WinForms.Guna2Button exit_button;
    }
}