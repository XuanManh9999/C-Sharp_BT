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
    public partial class formThemSuaXoa : Form
    {
        public formThemSuaXoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThem form_Them = new FormThem();
            form_Them.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Nhom1_Sua nhom_1 = new Nhom1_Sua();
            nhom_1.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Nhom_1_Xoa hienThiXoa = new Nhom_1_Xoa();
            hienThiXoa.ShowDialog();
        }
    }
}
