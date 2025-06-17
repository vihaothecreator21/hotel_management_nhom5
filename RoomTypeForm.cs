
using Guna.UI2.WinForms;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hotel_management_nhom5
{
    public partial class RoomTypeForm : Form
    {
        private readonly IRoomTypeRepository repo = new RoomTypeRepository();
        private int selectedId = -1;

        public RoomTypeForm()
        {
            InitializeComponent();
            LoadRoomTypes();
        }
        private void RoomTypeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadRoomTypes()
        {
            dgvRoomTypes.DataSource = repo.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomTypeName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng.");
                return;
            }

            var newType = new RoomType
            {
                Name = txtRoomTypeName.Text.Trim(),
                Category = cbCategory.SelectedItem?.ToString() ?? "Normal"
            };

            repo.Add(newType);
            LoadRoomTypes();
            ClearForm();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng để sửa.");
                return;
            }

            var updatedType = new RoomType
            {
                Id = selectedId,
                Name = txtRoomTypeName.Text.Trim(),
                Category = cbCategory.SelectedItem?.ToString() ?? "Normal"
            };

            repo.Update(updatedType);
            LoadRoomTypes();
            ClearForm();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng để xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                repo.Delete(selectedId);
                LoadRoomTypes();
                ClearForm();
            }
        }

        private void dgvRoomTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvRoomTypes.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtRoomTypeName.Text = row.Cells["Name"].Value?.ToString();
                cbCategory.SelectedItem = row.Cells["Category"].Value?.ToString();
            }
        }

        private void ClearForm()
        {
            txtRoomTypeName.Clear();
            cbCategory.SelectedIndex = 0;
            selectedId = -1;
        }
    }
}
