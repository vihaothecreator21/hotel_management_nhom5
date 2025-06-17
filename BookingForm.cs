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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                cbCustomer.DataSource = db.Customers.ToList();
                cbCustomer.DisplayMember = "Name";
                cbCustomer.ValueMember = "CustomerId";

                cbRoom.DataSource = db.Rooms.Where(r => r.Status == "Trống").ToList();
                cbRoom.DisplayMember = "RoomNumber";
                cbRoom.ValueMember = "RoomId";
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string customerName = cbCustomer.Text;

            using (var db = new AppDbContext())
            {
                int customerId;
                var existingCustomer = db.Customers.FirstOrDefault(c => c.Name == customerName);
                if (existingCustomer == null)
                {
                    var newCustomer = new Customer { Name = customerName };
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    customerId = newCustomer.CustomerId;
                }
                else
                {
                    customerId = existingCustomer.CustomerId;
                }

                int roomId = (int)cbRoom.SelectedValue;
                {
                    var booking = new Booking
                    {
                        CustomerId = customerId,
                        RoomId = roomId,
                        BookingDate = DateTime.Now,
                        Status = "Đã đặt"
                    };

                    db.Bookings.Add(booking);

                    var room = db.Rooms.Find(roomId);
                    if (room != null)
                    {
                        room.Status = "Đã đặt";
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Đặt phòng thành công!");
                this.Close();
            }
        }
    }
}
