using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Form_QLNH : Form
    {
        public Form_QLNH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTrangChu form_trang_chu = new FormTrangChu();
            form_trang_chu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không?",
            "Thông Báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }else
            {
                MessageBox.Show("Mới Bạn Tiếp Tục Sử Dụng Chương Trình");
            }
        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            formThemSuaXoa form_1 = new formThemSuaXoa();
            form_1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formThemSuaXoa form_1 = new formThemSuaXoa();
            form_1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formThemSuaXoa form_1 = new formThemSuaXoa();
            form_1.ShowDialog();
        }
    }
}
