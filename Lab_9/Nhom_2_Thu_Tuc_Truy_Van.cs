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
    public partial class Nhom_2_Thu_Tuc_Truy_Van : Form
    {
        string strCon = @"Data Source=DESKTOP-DKFKEOU\SQLEXPRESS;Initial Catalog=LAP_9_QUAN_LY_BAN_HANG;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Nhom_2_Thu_Tuc_Truy_Van()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTruyVan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThucHienTruyVan_Click(object sender, EventArgs e)
        {
            lsvHienThi.View = View.Details;
            string s = "";
            s = txtTruyVan.Text;
            if (s == "")
            {
                MessageBox.Show("Không Thành Công, Câu Truy Vấn Sai Cú Pháp");
            }else
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlCMD = new SqlCommand();
                sqlCMD.CommandType = CommandType.Text;
                sqlCMD.CommandText = s;
                sqlCMD.Connection = sqlCon;
                SqlDataReader reader = sqlCMD.ExecuteReader();
                lsvHienThi.Items.Clear();
                while (reader.Read()) { 
                    if (s.IndexOf("HDCT") > 0)
                    {
                        lsvHienThi.Columns[3].Width = 0;
                        var maKH = reader.GetSqlValue(0);
                        var tenKhachHang = reader.GetSqlValue(1);
                        var soDienThoai = reader.GetSqlValue(2);
                        ListViewItem item = new ListViewItem(maKH.ToString());
                        item.SubItems.Add(tenKhachHang.ToString());
                        item.SubItems.Add(soDienThoai.ToString());
                        lsvHienThi.Items.Add(item);
                    }else
                    {
                        lsvHienThi.Columns[3].Width = 120;
                        var maKH = reader.GetSqlValue(0);
                        var tenKhachHang = reader.GetSqlValue(1);
                        var soDienThoai = reader.GetSqlValue(2);
                        var ghiChu = reader.GetSqlValue(3);
                        ListViewItem item = new ListViewItem(maKH.ToString());
                        item.SubItems.Add(tenKhachHang.ToString());
                        item.SubItems.Add(soDienThoai.ToString());
                        item.SubItems.Add(ghiChu.ToString());
                        lsvHienThi.Items.Add(item);
                    }
                }
                reader.Close();
            }
            txtTruyVan.Text = "";
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormTrangChu trangTru = new FormTrangChu();
            trangTru.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không!",
            "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng");
            }
        }
    }
}
