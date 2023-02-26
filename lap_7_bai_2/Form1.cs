using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_7_bai_2
{
    public partial class Form1 : Form
    {
        List<SinhVien> dsSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //dgvSinhVien.DataSource = dsSinhVien;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            SinhVien sv;
            sv = new SinhVien() { TenSinhVien = txtTenSinhVien.Text, maSinhVien = txtMaSinhVien.Text, Lop = txtLop.Text, ViTriCongViec = txtViTriCongViec.Text };
            dsSinhVien.Add(sv);
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không", 
              "Thống Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
            {
                Close();
            }else
            {
                MessageBox.Show("Mời bạn tiếp tục sử dụng chương trình!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThi hienThi = new HienThi(dsSinhVien);
            hienThi.ShowDialog();
        }
    }
}
