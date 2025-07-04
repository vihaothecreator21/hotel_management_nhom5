using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;

namespace hotel_management_nhom5
{
    public partial class BookingForm : Form
    {
        private readonly CustomerRepository _custRepo = new CustomerRepository();
        private readonly BookingRepository _resRepo = new BookingRepository();
        private readonly RoomRepository _roomRepo = new RoomRepository();
        private Room _selectedRoom;
        public BookingForm()
        {
            InitializeComponent();
            LoadRooms();
            
        }
        private void LoadRooms()
        {
            flowRooms.Controls.Clear();
            foreach (var room in _roomRepo.GetAvailable())
            {
                var pb = new PictureBox
                {
                    Width = 100,
                    Height = 75,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(2),
                    Tag = room
                };
                
                pb.Click += (s, e) =>
                {
                    _selectedRoom = (Room)pb.Tag;
                   
                    foreach (PictureBox c in flowRooms.Controls) c.BorderStyle = BorderStyle.FixedSingle;
                    pb.BorderStyle = BorderStyle.Fixed3D;
                };
                flowRooms.Controls.Add(pb);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_selectedRoom == null)
            {
                MessageBox.Show("Chọn phòng trước.");
                return;
            }
            var idNum = lbiden.Text.Trim();
            if (idNum == "")
            {
                MessageBox.Show("Nhập CCCD.");
                return;
            }

            // Lấy hoặc tạo Customer
            Customer cust = _custRepo.GetByIdentity(idNum);
            if (cust == null)
            {
                cust = new Customer
                {
                    FullName = lbname.Text,
                    IdentityCard = idNum,
                    Phone = lbphone.Text,
                    CreatedAt = DateTime.Now
                };
                _custRepo.Add(cust);
            }
            var res = new Booking
            {
                CustomerId = cust.CustomerId,
                RoomId = _selectedRoom.RoomId,
                CheckIn = dtpCheckIn.Value,
                BookingDate = DateTime.Now,
                Status = BookingStatus.Booked
            };
            _resRepo.Add(res);
            MessageBox.Show("Đặt phòng thành công!");
            this.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowRooms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

