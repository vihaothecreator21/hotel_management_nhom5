namespace hotel_management_nhom5
{
    partial class BookingForm
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
            this.txtIdentity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbiden = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.flowRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.INFORMATION = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtpCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.INFORMATION.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdentity
            // 
            this.txtIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentity.DefaultText = "";
            this.txtIdentity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentity.Location = new System.Drawing.Point(90, 147);
            this.txtIdentity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.PlaceholderText = "";
            this.txtIdentity.SelectedText = "";
            this.txtIdentity.Size = new System.Drawing.Size(251, 48);
            this.txtIdentity.TabIndex = 0;
            this.txtIdentity.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(90, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(251, 46);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(15, 83);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(52, 20);
            this.lbname.TabIndex = 5;
            this.lbname.Text = "Name:";
            // 
            // lbiden
            // 
            this.lbiden.AutoSize = true;
            this.lbiden.Location = new System.Drawing.Point(15, 160);
            this.lbiden.Name = "lbiden";
            this.lbiden.Size = new System.Drawing.Size(62, 20);
            this.lbiden.TabIndex = 6;
            this.lbiden.Text = "Identity:";
            this.lbiden.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(15, 247);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(53, 20);
            this.lbphone.TabIndex = 7;
            this.lbphone.Text = "Phone:";
            this.lbphone.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowRooms
            // 
            this.flowRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRooms.Location = new System.Drawing.Point(0, 0);
            this.flowRooms.Name = "flowRooms";
            this.flowRooms.Size = new System.Drawing.Size(1067, 450);
            this.flowRooms.TabIndex = 9;
            // 
            // INFORMATION
            // 
            this.INFORMATION.Controls.Add(this.txtPhone);
            this.INFORMATION.Controls.Add(this.lbname);
            this.INFORMATION.Controls.Add(this.lbiden);
            this.INFORMATION.Controls.Add(this.lbphone);
            this.INFORMATION.Controls.Add(this.txtName);
            this.INFORMATION.Controls.Add(this.txtIdentity);
            this.INFORMATION.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.INFORMATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.INFORMATION.Location = new System.Drawing.Point(21, 33);
            this.INFORMATION.Name = "INFORMATION";
            this.INFORMATION.Size = new System.Drawing.Size(416, 321);
            this.INFORMATION.TabIndex = 10;
            this.INFORMATION.Text = "INFORMATION:";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(90, 229);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(251, 48);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(315, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(231, 38);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "CONFIRM";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(477, 12);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(560, 53);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(209, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 10;
            this.guna2GradientPanel2.Controls.Add(this.dtpCheckIn);
            this.guna2GradientPanel2.Controls.Add(this.btnSubmit);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(477, 360);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(563, 53);
            this.guna2GradientPanel2.TabIndex = 12;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Checked = true;
            this.dtpCheckIn.FillColor = System.Drawing.Color.MediumAquamarine;
            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckIn.Location = new System.Drawing.Point(14, 6);
            this.dtpCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(275, 38);
            this.dtpCheckIn.TabIndex = 12;
            this.dtpCheckIn.Value = new System.DateTime(2025, 6, 20, 12, 22, 3, 773);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.INFORMATION);
            this.Controls.Add(this.flowRooms);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.INFORMATION.ResumeLayout(false);
            this.INFORMATION.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtIdentity;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbiden;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.FlowLayoutPanel flowRooms;
        private Guna.UI2.WinForms.Guna2GroupBox INFORMATION;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckIn;
    }
}