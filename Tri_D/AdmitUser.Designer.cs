namespace Tri_D
{
    partial class AdmitUser
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
            this.admit_button = new Guna.UI2.WinForms.Guna2Button();
            this.combo_admin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.combo_choose_slot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_queued_drivers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // admit_button
            // 
            this.admit_button.BorderRadius = 10;
            this.admit_button.CheckedState.Parent = this.admit_button;
            this.admit_button.CustomImages.Parent = this.admit_button;
            this.admit_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(46)))));
            this.admit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admit_button.ForeColor = System.Drawing.Color.White;
            this.admit_button.HoverState.Parent = this.admit_button;
            this.admit_button.Location = new System.Drawing.Point(345, 365);
            this.admit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admit_button.Name = "admit_button";
            this.admit_button.ShadowDecoration.Parent = this.admit_button;
            this.admit_button.Size = new System.Drawing.Size(350, 68);
            this.admit_button.TabIndex = 17;
            this.admit_button.Text = "Admit";
            this.admit_button.Click += new System.EventHandler(this.admit_button_Click);
            // 
            // combo_admin
            // 
            this.combo_admin.BackColor = System.Drawing.Color.Transparent;
            this.combo_admin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_admin.FocusedColor = System.Drawing.Color.Empty;
            this.combo_admin.FocusedState.Parent = this.combo_admin;
            this.combo_admin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_admin.FormattingEnabled = true;
            this.combo_admin.HoverState.Parent = this.combo_admin;
            this.combo_admin.ItemHeight = 30;
            this.combo_admin.ItemsAppearance.Parent = this.combo_admin;
            this.combo_admin.Location = new System.Drawing.Point(428, 270);
            this.combo_admin.Margin = new System.Windows.Forms.Padding(4);
            this.combo_admin.Name = "combo_admin";
            this.combo_admin.ShadowDecoration.Parent = this.combo_admin;
            this.combo_admin.Size = new System.Drawing.Size(364, 36);
            this.combo_admin.TabIndex = 16;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(304, 270);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(101, 32);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "On duty:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(263, 193);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(142, 32);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Choose slot:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(239, 112);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(166, 32);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Choose driver:";
            // 
            // combo_choose_slot
            // 
            this.combo_choose_slot.BackColor = System.Drawing.Color.Transparent;
            this.combo_choose_slot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_choose_slot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_choose_slot.FocusedColor = System.Drawing.Color.Empty;
            this.combo_choose_slot.FocusedState.Parent = this.combo_choose_slot;
            this.combo_choose_slot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_choose_slot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_choose_slot.FormattingEnabled = true;
            this.combo_choose_slot.HoverState.Parent = this.combo_choose_slot;
            this.combo_choose_slot.ItemHeight = 30;
            this.combo_choose_slot.ItemsAppearance.Parent = this.combo_choose_slot;
            this.combo_choose_slot.Location = new System.Drawing.Point(427, 193);
            this.combo_choose_slot.Margin = new System.Windows.Forms.Padding(4);
            this.combo_choose_slot.Name = "combo_choose_slot";
            this.combo_choose_slot.ShadowDecoration.Parent = this.combo_choose_slot;
            this.combo_choose_slot.Size = new System.Drawing.Size(364, 36);
            this.combo_choose_slot.TabIndex = 12;
            // 
            // combo_queued_drivers
            // 
            this.combo_queued_drivers.BackColor = System.Drawing.Color.Transparent;
            this.combo_queued_drivers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_queued_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_queued_drivers.FocusedColor = System.Drawing.Color.Empty;
            this.combo_queued_drivers.FocusedState.Parent = this.combo_queued_drivers;
            this.combo_queued_drivers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_queued_drivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_queued_drivers.FormattingEnabled = true;
            this.combo_queued_drivers.HoverState.Parent = this.combo_queued_drivers;
            this.combo_queued_drivers.ItemHeight = 30;
            this.combo_queued_drivers.ItemsAppearance.Parent = this.combo_queued_drivers;
            this.combo_queued_drivers.Location = new System.Drawing.Point(427, 112);
            this.combo_queued_drivers.Margin = new System.Windows.Forms.Padding(4);
            this.combo_queued_drivers.Name = "combo_queued_drivers";
            this.combo_queued_drivers.ShadowDecoration.Parent = this.combo_queued_drivers;
            this.combo_queued_drivers.Size = new System.Drawing.Size(364, 36);
            this.combo_queued_drivers.TabIndex = 11;
            this.combo_queued_drivers.SelectedIndexChanged += new System.EventHandler(this.combo_queued_drivers_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(411, 30);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(213, 49);
            this.guna2HtmlLabel4.TabIndex = 18;
            this.guna2HtmlLabel4.Text = "Admit Driver";
            // 
            // AdmitUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1031, 544);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.admit_button);
            this.Controls.Add(this.combo_admin);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.combo_choose_slot);
            this.Controls.Add(this.combo_queued_drivers);
            this.Name = "AdmitUser";
            this.Text = "AdmitUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button admit_button;
        private Guna.UI2.WinForms.Guna2ComboBox combo_admin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox combo_choose_slot;
        private Guna.UI2.WinForms.Guna2ComboBox combo_queued_drivers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}