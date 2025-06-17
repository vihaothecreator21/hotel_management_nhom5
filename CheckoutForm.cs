using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void btnLoadReview_Click(object sender, EventArgs e)
        {
            int roomNumber;
            if (int.TryParse(txtRoomNumber.Text, out roomNumber))
            {
                using (var db = new AppDbContext())
                {
                    var room = db.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber.ToString() && r.Status == "Đã đặt");
                    if (room != null)
                    {
                        lblInfo.Text = $"Phòng {room.RoomNumber} đang được sử dụng.\nGiá: {room.Price}đ";
                        lblInfo.Visible = true;
                        txtReview.Enabled = true;
                        btnCheckout.Enabled = true;
                        txtReview.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phòng đang hoạt động.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số phòng.");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(txtRoomNumber.Text);
            using (var db = new AppDbContext())
            {
                var room = db.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber.ToString());
                if (room != null)
                {
                    room.Status = "Trống";

                    var review = new Review
                    {
                        RoomId = room.RoomId,
                        Comment = txtReview.Text,
                        CreatedAt = DateTime.Now
                    };

                    db.Reviews.Add(review);
                    db.SaveChanges();

                    MessageBox.Show("Trả phòng và lưu đánh giá thành công!");
                    this.Close();
                }
            }
        }
    }
}
