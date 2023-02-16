using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liet_ke_So_Nguyen_to
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            
            print_snt snt = new print_snt();
            snt.so = double.Parse(txtNhap.Text);
            for (int i = 2; i <= snt.so;i++)
            {
                if (snt.kiemTraSoNT(i))
                {
                    lstDanhSachSnt.Items.Add(i);
                }
            }
            MessageBox.Show("Thành Công", 
                "Thông Báo",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Toàn Bộ",
                "Thông Báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtNhap.Text = "";
                lstDanhSachSnt.Items.Clear();
            }else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng Chương Trình");
            }
        }
    }
}
