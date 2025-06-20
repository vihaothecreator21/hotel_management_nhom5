namespace hotel_management_nhom5
{
    partial class CheckOutForm
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
            this.INFORMATION = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtName = new System.Windows.Forms.Label();
            this.lbiden = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtIdentity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.INFORMATION.SuspendLayout();
            this.SuspendLayout();
            // 
            // INFORMATION
            // 
            this.INFORMATION.Controls.Add(this.btnFind);
            this.INFORMATION.Controls.Add(this.txtName);
            this.INFORMATION.Controls.Add(this.lbiden);
            this.INFORMATION.Controls.Add(this.lblInfo);
            this.INFORMATION.Controls.Add(this.txtIdentity);
            this.INFORMATION.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.INFORMATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.INFORMATION.Location = new System.Drawing.Point(12, 12);
            this.INFORMATION.Name = "INFORMATION";
            this.INFORMATION.Size = new System.Drawing.Size(416, 321);
            this.INFORMATION.TabIndex = 11;
            this.INFORMATION.Text = "INFORMATION:";
            this.INFORMATION.Click += new System.EventHandler(this.INFORMATION_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(15, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 20);
            this.txtName.TabIndex = 5;
            // 
            // lbiden
            // 
            this.lbiden.AutoSize = true;
            this.lbiden.Location = new System.Drawing.Point(15, 63);
            this.lbiden.Name = "lbiden";
            this.lbiden.Size = new System.Drawing.Size(62, 20);
            this.lbiden.TabIndex = 6;
            this.lbiden.Text = "Identity:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(15, 201);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 7;
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
            this.txtIdentity.Location = new System.Drawing.Point(105, 55);
            this.txtIdentity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.PlaceholderText = "";
            this.txtIdentity.SelectedText = "";
            this.txtIdentity.Size = new System.Drawing.Size(251, 48);
            this.txtIdentity.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(105, 125);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(251, 38);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "FIND";
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.INFORMATION);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.INFORMATION.ResumeLayout(false);
            this.INFORMATION.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox INFORMATION;
        
        private System.Windows.Forms.Label lbiden;
        private System.Windows.Forms.Label lblInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentity;
        private Guna.UI2.WinForms.Guna2Button btnFind;
    }
}