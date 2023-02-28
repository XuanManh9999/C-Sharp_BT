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

namespace lap_8_bai_1
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-DKFKEOU\SQLEXPRESS;Initial Catalog=NUMBERS;Integrated Security=True";
        SqlConnection sqlCon = null;// tạo đối tượng kết nối với cơ sở dữ liêu
        int soDau = 0;
        int soCuoi = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Nhận Giá Trị Đầu
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);// kết nối tới cơ sở dữ liêu
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();// đóng thì mở
            }
            SqlCommand sqlCMD = new SqlCommand();// tạo đối tượng truy vấn
            sqlCMD.CommandType = CommandType.Text;// dạng truy vấn ở dạng text
            sqlCMD.CommandText = $"select * from NUMBER";
            sqlCMD.Connection = sqlCon;
            SqlDataReader reader = sqlCMD.ExecuteReader();// tạo truy vấn
            if (reader.Read())
            {
                soCuoi = reader.GetInt32(1);
                lstNhanGiaTri.Items.Add(soCuoi);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void btn_soDau_Click(object sender, EventArgs e)
        {
            // Tầng DAL 
            // Nhận Giá Trị Đầu
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);// kết nối tới cơ sở dữ liêu
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();// đóng thì mở
            }
            SqlCommand sqlCMD = new SqlCommand();// tạo đối tượng truy vấn
            sqlCMD.CommandType = CommandType.Text;// dạng truy vấn ở dạng text
            sqlCMD.CommandText = $"select * from NUMBER";
            sqlCMD.Connection = sqlCon;
            SqlDataReader reader = sqlCMD.ExecuteReader();// tạo truy vấn
            if (reader.Read())
            {
                soDau = reader.GetInt32(0);
                lstNhanGiaTri.Items.Add(soDau);

            }
            reader.Close();
        }

        private void lstDauRa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tầng BUS, GUI -> Hiển Thị Ra
            int ketQua = soDau + soCuoi;
            lstDauRa.Items.Add(ketQua);
        }
    }
}
