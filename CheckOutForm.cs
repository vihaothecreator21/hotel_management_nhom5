using System;
using System.Windows.Forms;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5
{
    public partial class CheckOutForm : Form
    {
        // Khởi tạo các repository
        private readonly ICustomerRepository _customerRepo = new CustomerRepository();
        private readonly IBookingRepository _bookingRepo = new BookingRepository();
        private readonly IReviewRepository _reviewRepo = new ReviewRepository();

        private Booking _currentBooking;  // Giữ booking đang thao tác

        public CheckOutForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Ban đầu chưa tìm thấy booking → disable nút và rating
            guna2RatingStar1.Enabled = false;
            btnConfirm.Enabled = false;

            // Gắn sự kiện
            btnFind.Click += btnFind_Click;
            btnConfirm.Click += btnConfirm_Click;
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            // Nếu bạn cần load thêm gì khi form mới mở
        }

        private void INFORMATION_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var identity = txtIdentity.Text.Trim();
            if (string.IsNullOrEmpty(identity))
            {
                MessageBox.Show("Vui lòng nhập số căn cước.", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) Tìm Customer theo IdentityCard
            var customer = _customerRepo.GetByIdentity(identity);
            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng với CMT này.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2) Lấy booking đang active của khách
            _currentBooking = _bookingRepo.GetActiveByCustomer(customer.CustomerId);
            if (_currentBooking == null)
            {
                MessageBox.Show("Khách này không có booking đang mở hoặc đã Check-Out.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3) Hiển thị thông tin lên form
            txtName.Text = _currentBooking.GuestName;
            lblInfo.Text =
                $"Phòng: {_currentBooking.RoomNumber}\n" +
                $"Thời gian: {_currentBooking.CheckInOut}\n" +
                $"Tổng tiền: {_currentBooking.TotalPrice:N0} đ";

            // 4) Cho phép đánh giá & confirm
            guna2RatingStar1.Enabled = true;
            btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_currentBooking == null) return;

            // 1) Cập nhật trạng thái Check-Out
            _currentBooking.Status = BookingStatus.CheckedOut;
            _bookingRepo.Update(_currentBooking);

            // 2) Lưu review vào DB
            var review = new Review
            {
                BookingId = _currentBooking.BookingId,
                RoomId = _currentBooking.RoomId,
                Rating = (int)guna2RatingStar1.Value,
                Comment = string.Empty,
                CreatedAt = DateTime.Now
            };
            _reviewRepo.Add(review);

            // 3) Mở ReviewForm (nhớ tạo constructor ReviewForm(Review r))
            var reviewForm = new ReviewForm(review);
            reviewForm.ShowDialog();

            // 4) Đóng form này
            this.Close();
        }
    }
}
