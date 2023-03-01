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
namespace lab_8_bai_2
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-DKFKEOU\SQLEXPRESS;Initial Catalog=LAB8_KIEM_TRA_TAM_GIAC;Integrated Security=True";
        SqlConnection sqlCon = null;// đối tượng kết nối tới csdl
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiCoSoSuLieu();
        }
        private void hienThiCoSoSuLieu()
        {
            // nếu chứ kết nối thì kết nối
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);// kết nối tới csdl
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCMD = new SqlCommand();// tạo đối tượng truy vấn
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = "select * from So";
            sqlCMD.Connection = sqlCon;
            SqlDataReader reader = sqlCMD.ExecuteReader();
            lsvCoSoDuLieu.Items.Clear();
            while (reader.Read())
            {
                try
                {
                    double soDau = reader.GetDouble(0);
                    double soHai = reader.GetDouble(1);
                    double soBa = reader.GetDouble(2);
                    ListViewItem item = new ListViewItem(soDau.ToString());
                    item.SubItems.Add(soHai.ToString());
                    item.SubItems.Add(soBa.ToString());
                    lsvCoSoDuLieu.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            reader.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        // phương thức thêm vào cơ sở dữ liệu
        private void themVaoCoSoDuLieu(string a, string b, string c)
        {
            double soDau = double.Parse(a);
            double soHai = double.Parse(b);
            double soCuoi = double.Parse(c);
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);// kết nối tới csdl
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCMD = new SqlCommand();// tạo đối tượng truy vấn
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = $"insert into So (soThucDau, soThucHai, soThucBa) values ({soDau}, {soHai}, {soCuoi})";
            sqlCMD.Connection = sqlCon;
            int x = sqlCMD.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Thêm Thành Công!!");
                hienThiCoSoSuLieu();
            }else
            {
                MessageBox.Show("Thêm Vào Không Thành Công");
            }
            hienThiCoSoSuLieu();
        }
        private void btnAddVaoCoSoDuLieu_Click(object sender, EventArgs e)
        {
            string a = txtSoMot.Text;
            string b = txtSo2.Text;
            string c = txtSo3.Text;
            themVaoCoSoDuLieu(a, b, c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát!",
            "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Hẹn Gặp Lại Bài Lần Sau");
            }else
            {
                MessageBox.Show("Mời Bạn Tiếp Tục Sử Dụng Chương Trình");
            }
        }

        int cnt = 0;
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (txtindex_1.Text != "")
            {
                int x = int.Parse(txtindex_1.Text);
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
                sqlCMD.CommandText = "select * from So";
                sqlCMD.Connection = sqlCon;
                SqlDataReader reader = sqlCMD.ExecuteReader();
                while (reader.Read())
                {
                    ++cnt;
                    if (cnt == x)
                    {
                        double soDau = reader.GetDouble(0);
                        double soHai = reader.GetDouble(1);
                        double soBa = reader.GetDouble(2);
                        Form2 form2 = new Form2(soDau, soHai, soBa);
                        form2.ShowDialog();
                    }
                }
                reader.Close();
            }else
            {
                errorProvider1.SetError(txtindex_1, "Lỗi Rồi Bạn Ơi");
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
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
            sqlCMD.CommandText = "delete So";
            sqlCMD.Connection = sqlCon;
            int x = sqlCMD.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Xóa Thành Công!!");
                hienThiCoSoSuLieu();
            }else
            {
                MessageBox.Show("Xóa Không Thành Công!!");
            }
        }

        private void txtindex_1_TextChanged(object sender, EventArgs e)
        {
            if (txtindex_1.Text == "")
            {
                errorProvider1.SetError(txtindex_1, "Sai Rồi Bạn");
            }
        }
    }
}
