using System;
using System.Linq;
using System.Windows.Forms;
using hotel_management_nhom5.Data;


namespace hotel_management_nhom5
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

           
        }

        private void OpenBookingForm()
        {
            using (var form = new BookingForm())
                form.ShowDialog();
        }

        private void OpenCustomerForm()
        {
            using (var form = new CustomerForm())
                form.ShowDialog();
        }

        private void OpenCheckOutForm()
        {
            using (var form = new CheckOutForm())
                form.ShowDialog();
        }

        //private void OpenReviewListForm()
        //{
           // using (var form = new ReviewListForm())
             //   form.ShowDialog();
       // }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: Load dashboard metrics here
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
                    bool dbExists = context.Database.Exists();
                    if (!dbExists)
                    {
                        MessageBox.Show(
                            "Database không tồn tại! Hãy chạy Update-Database trước.",
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    int roomsCount = context.Rooms.Count();
                    int customersCount = context.Customers.Count();
                    int bookingsCount = context.Bookings.Count();
                    int reviewsCount = context.Reviews.Count();

                    string message = $@"✅ Database HotelDb đã được tạo thành công!

📊 Thông tin các bảng:
• Rooms: {roomsCount} records
• Customers: {customersCount} records
• Bookings: {bookingsCount} records
• Reviews: {reviewsCount} records

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

        private void btnBookings_Click_Click(object sender, EventArgs e)
        {
            using (var f = new BookingForm())
                f.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            using (var f = new CheckOutForm())
                f.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using (var f = new CustomerForm())
                f.ShowDialog();
        }
    }
}
