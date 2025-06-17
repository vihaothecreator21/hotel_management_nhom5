
namespace hotel_management_nhom5
{
    partial class RoomTypeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoomTypes;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomTypeName;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvRoomTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtRoomTypeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Quản lý loại phòng";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(300, 40);

            // lblName
            this.lblName.Text = "Tên loại phòng:";
            this.lblName.Location = new System.Drawing.Point(20, 70);

            // lblCategory
            this.lblCategory.Text = "Phân loại:";
            this.lblCategory.Location = new System.Drawing.Point(20, 120);

            // txtRoomTypeName
            this.txtRoomTypeName.Location = new System.Drawing.Point(130, 65);
            this.txtRoomTypeName.Size = new System.Drawing.Size(200, 30);

            // cbCategory
            this.cbCategory.Location = new System.Drawing.Point(130, 115);
            this.cbCategory.Size = new System.Drawing.Size(200, 30);
            this.cbCategory.Items.AddRange(new object[] { "Normal", "Premium" });
            this.cbCategory.SelectedIndex = 0;

            // btnAdd
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(360, 65);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Location = new System.Drawing.Point(360, 105);
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Location = new System.Drawing.Point(360, 145);
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvRoomTypes
            this.dgvRoomTypes.Location = new System.Drawing.Point(20, 200);
            this.dgvRoomTypes.Size = new System.Drawing.Size(600, 250);
            this.dgvRoomTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomTypes_CellClick);

            // RoomTypeForm
            this.ClientSize = new System.Drawing.Size(650, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtRoomTypeName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvRoomTypes);
            this.Text = "RoomTypeForm";
            this.Load += new System.EventHandler(this.RoomTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
