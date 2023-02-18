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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        form_2 form_;
        int check = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGiaHang.Text != "" && txtMaHang.Text != "" && txtGiaHang.Text != "")
            {
                check = 1;
                HangHoa hang = new HangHoa();
                string TenHang = "", MaHang = "";
                double GiaHang = 0;
                hang.TenHang = txtTenHang.Text;
                hang.MaHang = txtMaHang.Text;
                int kk = 0;
                try
                {
                    hang.GiaHang = double.Parse(txtGiaHang.Text);
                }catch(Exception ex)
                {
                    kk = 1;
                    MessageBox.Show("Bạn Phải Nhập Vào Một Số Ở Phần Giá Tiền.");
                }
               if (kk != 1)
                {
                    form_ = new form_2(hang.TenHang, hang.MaHang, hang.GiaHang);
                    MessageBox.Show("Thành Công");
                }
            }else
            {
                MessageBox.Show("Bạn Vui Lòng Nhập Đầy Đủ Thông Tin Để Thực Hiện CHương Trình");
            }
       
        }

        private void btnQuaForm_Click(object sender, EventArgs e)
        {
           
            if (check == 1)
            {
                form_.Show();
            }else
            {
                MessageBox.Show("Bạn Vui Lòng Nhập Đầy Đủ Thông Tin Để Thực Hiện CHương Trình");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát không",
            "Thông Báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result== DialogResult.Yes)
            {
                MessageBox.Show("Hẹn Gặp Lại Bạn Một Ngày Gần Nhất");
                Close();
            }else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng Chương Trình!");
            }
        }
    }
}
