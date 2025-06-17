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
using System.IO; // ← thêm dòng này nếu bạn load ảnh từ file
namespace hotel_management_nhom5
{
    public partial class KioskForm : Form
    {
        public KioskForm()
        {
            InitializeComponent();
        }

        private void KioskForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            using (var db = new AppDbContext())
            {
                var availableRooms = db.Rooms.Where(r => r.Status == "Trống").ToList();

                foreach (var room in availableRooms)
                {
                    Panel panel = new Panel
                    {
                        Width = 200,
                        Height = 180,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Ảnh phòng – bạn cần copy room.jpg vào thư mục bin\Debug\net...\Images\
                    PictureBox pic = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 180,
                        Height = 100,
                        Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "room.jpg"))
                    };

                    Label lbl = new Label
                    {
                        Text = $"Phòng {room.RoomNumber}\nGiá: {room.Price}đ",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10),
                        Top = 110
                    };

                    panel.Controls.Add(pic);
                    panel.Controls.Add(lbl);

                    flowLayoutPanelRooms.Controls.Add(panel);
                }
            }
        }
    }
}
