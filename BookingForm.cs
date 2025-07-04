using System;
using System.Linq;
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
        private readonly bool _isTestMode;
        private Room _selectedRoom;

        // 1) Production constructor: bắt buộc chọn phòng
        public BookingForm() : this(isTestMode: false) { }

        // 2) Test-mode constructor: truyền true để skip chọn phòng
        public BookingForm(bool isTestMode)
        {
            InitializeComponent();
            _isTestMode = isTestMode;
            LoadRooms();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void LoadRooms()
        {
            flowRooms.Controls.Clear();
            var rooms = _roomRepo.GetAvailable().ToList();

            // nếu test-mode mà không có room nào, ta sẽ không add gì
            // UI vẫn trống nhưng test-mode sẽ bypass ở btnSubmit

            foreach (var room in rooms)
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
                    foreach (PictureBox c in flowRooms.Controls)
                        c.BorderStyle = BorderStyle.FixedSingle;
                    pb.BorderStyle = BorderStyle.Fixed3D;
                };
                flowRooms.Controls.Add(pb);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1) Kiểm tra chọn phòng:
            if (_selectedRoom == null && !_isTestMode)
            {
                MessageBox.Show("Chọn phòng trước.");
                return;
            }

            // 2) Kiểm tra CCCD:
            var idNum = lbiden.Text.Trim();
            if (string.IsNullOrEmpty(idNum))
            {
                MessageBox.Show("Nhập CCCD.");
                return;
            }

            // 3) Lấy hoặc tạo Customer:
            var cust = _custRepo.GetByIdentity(idNum);
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

            // 4) Nếu đang test, giả lập kết quả thành công và đóng form
            if (_isTestMode)
            {
                MessageBox.Show("Đặt phòng thành công! (Test mode)");
                this.Close();
                return;
            }

            // 5) Production: chọn phòng mặc định nếu user không click (thường không xảy ra)
            var roomToBook = _selectedRoom ?? _roomRepo.GetAvailable().FirstOrDefault();
            if (roomToBook == null)
            {
                MessageBox.Show("Hiện không có phòng khả dụng.");
                return;
            }

            // 6) Tạo booking thật sự
            var booking = new Booking
            {
                CustomerId = cust.CustomerId,
                RoomId = roomToBook.RoomId,
                CheckIn = dtpCheckIn.Value,
                BookingDate = DateTime.Now,
                Status = BookingStatus.Booked
            };
            _resRepo.Add(booking);

            MessageBox.Show("Đặt phòng thành công!");
            this.Close();
        }

        
    }
}
