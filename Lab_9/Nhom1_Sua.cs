using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lab_9
{
    public partial class Nhom1_Sua : Form
    {
        string strCon = @"Data Source=DESKTOP-DKFKEOU\SQLEXPRESS;Initial Catalog=LAP_9_QUAN_LY_BAN_HANG;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Nhom1_Sua()
        {
            InitializeComponent();
        }

        private void Nhom1_Sua_Load(object sender, EventArgs e)
        {
            
        }
        public void HienThi(string tenBang)
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
            sqlCMD.CommandText = $"select * from {tenBang}";
            sqlCMD.Connection = sqlCon;
            SqlDataReader reader = sqlCMD.ExecuteReader();
            lsvHienThi.Items.Clear();
            while (reader.Read())
            {
                if (s != "HDCT")
                {
                    var maKhachHang = reader.GetSqlValue(0);
                    var tenKhachHang = reader.GetSqlValue(1);
                    var soDienThoat = reader.GetSqlValue(2);
                    var ghiChu = reader.GetSqlValue(3);
                    ListViewItem item = new ListViewItem(maKhachHang.ToString());
                    item.SubItems.Add(tenKhachHang.ToString());
                    item.SubItems.Add(soDienThoat.ToString());
                    item.SubItems.Add(ghiChu.ToString());
                    lsvHienThi.Items.Add(item);
                }else
                {
                    var maKhachHang = reader.GetSqlValue(0);
                    var tenKhachHang = reader.GetSqlValue(1);
                    var soDienThoat = reader.GetSqlValue(2);
                    ListViewItem item = new ListViewItem(maKhachHang.ToString());
                    item.SubItems.Add(tenKhachHang.ToString());
                    item.SubItems.Add(soDienThoat.ToString());
                    lsvHienThi.Items.Add(item);
                }
            }
            reader.Close();
        }
        string s = "";
        private void cboLuaChonBangThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = cboLuaChonBangThem.SelectedItem.ToString();
            HienThi(s);
            if (s == "KHACHHANG")
            {
                lblHang1.Text = "Mã Khách Hàng";
                lblHang2.Text = "Tên Khách Hàng";
                lblHang3.Text = "SĐT";
                lblHang4.Visible = true;
                txtGhiChu.Visible = true;
                lblHang4.Text = "Ghi Chú";
                cot_1.Text = "MAKH";
                cot_2.Text = "TENKHACHHANG";
                cot_3.Text = "SDT";
                cot_4.Text = "GHICHU";
                lsvHienThi.Columns[3].Width = 120;
            }
            else if (s == "HANG")
            {
                lblHang1.Text = "Mã Hàng";
                lblHang2.Text = "Tên Hàng";
                lblHang3.Text = "Đơn Giá";
                lblHang4.Visible = true;
                lblHang4.Text = "Ghi Chú";
                cot_1.Text = "MAHANG";
                cot_2.Text = "TENHANG";
                cot_3.Text = "DONGIA";
                cot_4.Text = "GHICHU";
                txtGhiChu.Visible = true;
                lsvHienThi.Columns[3].Width = 120;
            }
            else if (s == "HDCT")
            {
                lblHang1.Text = "Mã Hóa Đơn";
                lblHang2.Text = "Mã Hàng";
                lblHang3.Text = "Số Lượng";
                lblHang4.Visible = false;
                txtGhiChu.Visible = false;
                cot_1.Text = "MAHD";
                cot_2.Text = "MAHANG";
                cot_3.Text = "SOLUONG";
                lsvHienThi.Columns[3].Width = 0;

            }
            else if (s == "HOADON")
            {
                lblHang1.Text = "Mã Hóa Đơn";
                lblHang2.Text = "Mã Khách Hàng";
                lblHang3.Text = "Ngày Hóa Đơn";
                lblHang4.Visible = true;
                txtGhiChu.Visible = true;
                lblHang4.Text = "Ghi Chú";
                cot_1.Text = "MAHD";
                cot_2.Text = "MAKH";
                cot_3.Text = "NGAYHD";
                cot_4.Text = "GHICHU";
                lsvHienThi.Columns[3].Width = 120;
            }
            lsvHienThi.View = View.Details;
        }
        string maSua = "";
        private void lsvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHienThi.SelectedItems.Count == 0)
            {
                return;
            }
            // Hiển Thị Cái Item mà select lên trên
            if (s != "HDCT")
            {
                ListViewItem item = lsvHienThi.SelectedItems[0];
                maSua = item.SubItems[0].Text;
                txtMaKhachHang.Text = item.SubItems[0].Text;
                txtTenKhachHang.Text = item.SubItems[1].Text;
                txtSoDienThoai.Text = item.SubItems[2].Text;
                txtGhiChu.Text = item.SubItems[3].Text;
            }else
            {
                ListViewItem item = lsvHienThi.SelectedItems[0];
                maSua = item.SubItems[0].Text;
                txtMaKhachHang.Text = item.SubItems[0].Text;
                txtTenKhachHang.Text = item.SubItems[1].Text;
                txtSoDienThoai.Text = item.SubItems[2].Text;
            }

        }

        private void btnADD_Click(object sender, EventArgs e)
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
            MessageBox.Show(maSua);
            if (s != "HDCT")
            {
                sqlCMD.CommandText = $"update {s} set {cot_1.Text} = '{txtMaKhachHang.Text}', {cot_2.Text} = N'{txtTenKhachHang.Text}', {cot_3.Text} = '{txtSoDienThoai.Text}', {cot_4.Text} = N'{txtGhiChu.Text}' where {cot_1.Text} = '{maSua}'";
            }else
            {
                sqlCMD.CommandText = $"update {s} set {cot_1.Text} = '{txtMaKhachHang.Text}', {cot_2.Text} = N'{txtTenKhachHang.Text}', {cot_3.Text} = '{txtSoDienThoai.Text}' where {cot_1.Text} = '{maSua}'";
            }
            sqlCMD.Connection = sqlCon;
            int x = sqlCMD.ExecuteNonQuery();
            if (x > 0)
            {
                HienThi(s);
                MessageBox.Show("Thành Công!!");
            }else
            {
                MessageBox.Show("Không Thành Công!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không!",
"Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng");
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            formThemSuaXoa troLai = new formThemSuaXoa();
            troLai.ShowDialog();
        }
    }
}
