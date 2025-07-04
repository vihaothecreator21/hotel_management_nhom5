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
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5
{
    public partial class CustomerForm : Form
    {
        
        private readonly ICustomerRepository _custRepo = new CustomerRepository();
        private readonly IBookingRepository _resRepo = new BookingRepository();
        private BindingList<Booking> _list;
        public CustomerForm()
        {
            InitializeComponent();
            LoadData(Enumerable.Empty<Booking>());   // truyền vào danh sách trống ban đầu
            this.AutoScaleMode = AutoScaleMode.Dpi;

        }
        private void LoadData(IEnumerable<Booking> source)
        {
            _list = new BindingList<Booking>(source.ToList());
            dgvCustomers.DataSource = _list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var idNum = txtSearchId.Text.Trim();
            if (string.IsNullOrEmpty(idNum))
            {
                MessageBox.Show("Vui lòng nhập CCCD để tìm.");
                return;
            }
            var cust = _custRepo.GetByIdentity(idNum);
            if (cust == null)
            {
                MessageBox.Show("Không tìm thấy khách.");
                _list = new BindingList<Booking>();
                dgvCustomers.DataSource = _list;
                return;
            }

            // 2. Lấy danh sách booking cho khách
            var bookings = _resRepo.GetByCustomer(cust.CustomerId);
            if (!bookings.Any())
            {
                MessageBox.Show("Khách chưa có đặt phòng nào.");
            }

            // 3. Bind lên grid
            LoadData(bookings);
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
