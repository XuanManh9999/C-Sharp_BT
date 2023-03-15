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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_9
{
    public partial class FormThem : Form
    {
        string strCon = @"Data Source=DESKTOP-DKFKEOU\SQLEXPRESS;Initial Catalog=LAP_9_QUAN_LY_BAN_HANG;Integrated Security=True";
        SqlConnection sqlCon = null;
        public FormThem()
        {
            InitializeComponent();
        }

        private void Them_Load(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            formThemSuaXoa troLaiThemSuaXoa = new formThemSuaXoa();
            troLaiThemSuaXoa.ShowDialog();
        }
            string s = "";
            int check = 0;
            int check_2 = 0;
        private void cobBangCanThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chưa chọn thì return 
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
                cot_1.Text = "Ma Khach Hang";
                cot_2.Text = "Ten Khach Hang";
                cot_3.Text = "SDT";
                cot_4.Text = "GhiChu";
                lsvHienThi.Columns[3].Width = 120;
            }
            else if(s == "HANG")
            {
                lblHang1.Text = "Mã Hàng";
                lblHang2.Text = "Tên Hàng";
                lblHang3.Text = "Đơn Giá";
                lblHang4.Visible = true;
                lblHang4.Text = "Ghi Chú";
                cot_1.Text = "MaHang";
                cot_2.Text = "TenHang";
                cot_3.Text = "DonGia";
                cot_4.Text = "GhiChu";
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
                cot_1.Text = "MaHD";
                cot_2.Text = "MaHang";
                cot_3.Text = "SoLuong";
                lsvHienThi.Columns[3].Width = 0;
                
            }else if (s == "HOADON")
            {
                lblHang1.Text = "Mã Hóa Đơn";
                lblHang2.Text = "Mã Khách Hàng";
                lblHang3.Text = "Ngày Hóa Đơn";
                lblHang4.Visible = true;
                txtGhiChu.Visible = true;
                lblHang4.Text = "Ghi Chú";
                cot_1.Text = "MaHD";
                cot_2.Text = "MaKH";
                cot_3.Text = "NgayHD";
                cot_4.Text = "GhiChu";
                lsvHienThi.Columns[3].Width = 120;
            }
            lsvHienThi.View = View.Details;
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
            if (s != "HDCT")
            {
                sqlCMD.CommandText = $"insert into {s}  values ('{txtMaKhachHang.Text}', N'{txtTenKhachHang.Text}', '{txtSoDienThoai.Text}', N'{txtGhiChu.Text}');";
            }else
            {
                sqlCMD.CommandText = $"insert into {s}  values ('{txtMaKhachHang.Text}', N'{txtTenKhachHang.Text}', '{txtSoDienThoai.Text}');";
            }
            sqlCMD.Connection = sqlCon;
            int x = sqlCMD.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Thêm Thành Công");
                HienThi(s);
            } else
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
            }else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng");
            }
        }
    }
}
