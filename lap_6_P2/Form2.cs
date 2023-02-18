using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_6_bai2
{
    public partial class form_2 : Form
    {
       List<HangHoa> danhSachHangHoa = new List<HangHoa>();
       public string tenHang { get; set; }  
       public string maHang { get; set; }
        public double giaHang { get; set; }
        
       
        public form_2 (string tenHang, string maHang, double giaHang)
        {
            InitializeComponent();
            this.tenHang = tenHang;
            this.maHang = maHang;
            this.giaHang= giaHang;
            
            HangHoa hang = new HangHoa(tenHang, maHang, giaHang);
            danhSachHangHoa.Add(hang);
        }
     
       public form_2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(var i in danhSachHangHoa)
            {
                string s = $"Tên Hàng: {i.TenHang} Mã Hàng: {i.MaHang} Giá Hàng: {i.GiaHang}";
                lstHienThi.Items.Add(s);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVeForm1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát không",
           "Thông Báo",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Hẹn Gặp Lại Bạn Một Ngày Gần Nhất");
                Close();
            }
            else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng Chương Trình!");
            }
        }
    }
}
