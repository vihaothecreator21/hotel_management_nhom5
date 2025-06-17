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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent(); this.FormClosed += (s, e) => Application.Exit();

        }

        private void btnCheckDB_Click(object sender, EventArgs e)
        {
            CheckDatabase();
        }
        private void CheckDatabase()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Kiểm tra database có tồn tại không
                    bool dbExists = context.Database.Exists();

                    if (!dbExists)
                    {
                        MessageBox.Show("Database không tồn tại! Hãy chạy Update-Database trước.",
                                      "Database Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra từng bảng
                    var roomsCount = context.Rooms.Count();
                    var customersCount = context.Customers.Count();
                    var bookingsCount = context.Bookings.Count();
                    var reviewsCount = context.Reviews.Count();
                    var staffsCount = context.Staffs.Count();

                    string message = $@"✅ Database HotelDb đã được tạo thành công!

📊 Thông tin các bảng:
• Rooms: {roomsCount} records
• Customers: {customersCount} records  
• Bookings: {bookingsCount} records
• Reviews: {reviewsCount} records
• Staffs: {staffsCount} records

🔗 Connection: {context.Database.Connection.DataSource}
📁 Database: {context.Database.Connection.Database}";

                    MessageBox.Show(message, "Database Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show($"❌ Lỗi SQL: {sqlEx.Message}\n\n💡 Có thể:\n• LocalDB chưa chạy\n• Database chưa được tạo\n• Connection string sai",
                              "SQL Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Lỗi khi kiểm tra database: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnRoomTypes_Click(object sender, EventArgs e)
        {
            RoomTypeForm form = new RoomTypeForm();
            form.ShowDialog();
        }
    }
}
    

