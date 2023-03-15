using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lab_9
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formThemSuaXoa themSuaXoa = new formThemSuaXoa();
            themSuaXoa.ShowDialog();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            Nhom_2_Thu_Tuc_Truy_Van nhom_2 = new Nhom_2_Thu_Tuc_Truy_Van(); 
            nhom_2.ShowDialog();    
        }

        private void btnQuanLyNhaHang_Click(object sender, EventArgs e)
        {
            Form_QLNH qlnh = new Form_QLNH();
            qlnh.ShowDialog();
        }
    }
}
