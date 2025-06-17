namespace hotel_management_nhom5
{
    partial class CheckoutForm
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
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.btnLoadReview = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(78, 57);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(184, 29);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Nhập số phòng";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(391, 50);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(234, 36);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // btnLoadReview
            // 
            this.btnLoadReview.Location = new System.Drawing.Point(327, 292);
            this.btnLoadReview.Name = "btnLoadReview";
            this.btnLoadReview.Size = new System.Drawing.Size(137, 55);
            this.btnLoadReview.TabIndex = 2;
            this.btnLoadReview.Text = "Xem thông tin";
            this.btnLoadReview.UseVisualStyleBackColor = true;
            this.btnLoadReview.Click += new System.EventHandler(this.btnLoadReview_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(28, 131);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(307, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Hiện thông tin phòng + khách (ẩn)";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(123, 169);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(90, 25);
            this.lblReview.TabIndex = 4;
            this.lblReview.Text = "Đánh giá";
            // 
            // txtReview
            // 
            this.txtReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReview.Location = new System.Drawing.Point(391, 131);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(234, 63);
            this.txtReview.TabIndex = 5;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(519, 292);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(178, 55);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Trả phòng va Lưu đánh giá";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnLoadReview);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnLoadReview;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Button btnCheckout;
    }
}