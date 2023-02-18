using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_6_form_1
{
    public partial class form_1 : Form
    {
        public form_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhanSo1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPhanSo2_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void form_1_Load(object sender, EventArgs e)
        {
            
        }
        public void Tong()
        {
            int check = 0;
            int dem = 0;
            for (int i = 0; i < txtPhanSo1.Text.Length; i++)
            {
                ++dem;
                if (txtPhanSo1.Text[i] == '/' && txtPhanSo1.Text[0] != '0')
                {
                    check = 1;
                }
            }
            if (txtPhanSo1.Text != "" && check == 1 && dem >= 3)
            {
                // 1/2
                // phan so 1
                string s = txtPhanSo1.Text;//1/2
                string tu_chuoi = "";
                string mau_chuoi = "";
                int i = 0;
                while (s[i] != '/')
                {
                    tu_chuoi += s[i];//1
                    i++;// 1
                }
                int k = i + 1;//
                while (k != s.Length)
                {
                    mau_chuoi += s[k];//2
                    k++;
                }
                int tu = int.Parse(tu_chuoi);
                int mau = int.Parse(mau_chuoi);
                PhanSo phan_so1 = new PhanSo(tu, mau);
                // phan so 2
                string s_2 = txtPhanSo2.Text;
                string tu_chuoi_2 = "";
                string mau_chuoi_2 = "";
                int j = 0;
                while (s_2[j] != '/')
                {
                    tu_chuoi_2 += s_2[j];
                    j++;// 1
                }
                int m = j + 1;
                while (m != s_2.Length)
                {
                    mau_chuoi_2 += s_2[m];
                    m++;
                }
                int tu_2 = int.Parse(tu_chuoi_2);
                int mau_2 = int.Parse(mau_chuoi_2);
                PhanSo phan_so2 = new PhanSo(tu_2, mau_2);
                PhanSo kq = phan_so1 + phan_so2;
                form2 traVe = new form2(kq.tu, kq.mau);
                traVe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Hãy Nhập Vào Chương Trình Để Thực Hiện");
            }

        }
        public void Hieu()
        {
            int check = 0;
            int dem = 0;
            for (int i = 0; i < txtPhanSo1.Text.Length; i++)
            {
                ++dem;
                if (txtPhanSo1.Text[i] == '/' && txtPhanSo1.Text[0] != '0')
                {
                    check = 1;
                }
            }
            if (txtPhanSo1.Text != "" && check == 1 && dem >= 3)
            {
                // 1/2
                // phan so 1
                string s = txtPhanSo1.Text;//1/2
                string tu_chuoi = "";
                string mau_chuoi = "";
                int i = 0;
                while (s[i] != '/')
                {
                    tu_chuoi += s[i];//1
                    i++;// 1
                }
                int k = i + 1;//
                while (k != s.Length)
                {
                    mau_chuoi += s[k];//2
                    k++;
                }
                int tu = int.Parse(tu_chuoi);
                int mau = int.Parse(mau_chuoi);
                PhanSo phan_so1 = new PhanSo(tu, mau);
                // phan so 2
                string s_2 = txtPhanSo2.Text;
                string tu_chuoi_2 = "";
                string mau_chuoi_2 = "";
                int j = 0;
                while (s_2[j] != '/')
                {
                    tu_chuoi_2 += s_2[j];
                    j++;// 1
                }
                int m = j + 1;
                while (m != s_2.Length)
                {
                    mau_chuoi_2 += s_2[m];
                    m++;
                }
                int tu_2 = int.Parse(tu_chuoi_2);
                int mau_2 = int.Parse(mau_chuoi_2);
                PhanSo phan_so2 = new PhanSo(tu_2, mau_2);
                PhanSo kq = phan_so1 - phan_so2;
                form2 traVe = new form2(kq.tu, kq.mau);
                traVe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Hãy Nhập Vào Chương Trình Để Thực Hiện");
            }

        }
        public void Tich()
        {
            int check = 0;
            int dem = 0;
            for (int i = 0; i < txtPhanSo1.Text.Length; i++)
            {
                ++dem;
                if (txtPhanSo1.Text[i] == '/' && txtPhanSo1.Text[0] != '0')
                {
                    check = 1;
                }
            }
            if (txtPhanSo1.Text != "" && check == 1 && dem >= 3)
            {
                // 1/2
                // phan so 1
                string s = txtPhanSo1.Text;//1/2
                string tu_chuoi = "";
                string mau_chuoi = "";
                int i = 0;
                while (s[i] != '/')
                {
                    tu_chuoi += s[i];//1
                    i++;// 1
                }
                int k = i + 1;//
                while (k != s.Length)
                {
                    mau_chuoi += s[k];//2
                    k++;
                }
                int tu = int.Parse(tu_chuoi);
                int mau = int.Parse(mau_chuoi);
                PhanSo phan_so1 = new PhanSo(tu, mau);
                // phan so 2
                string s_2 = txtPhanSo2.Text;
                string tu_chuoi_2 = "";
                string mau_chuoi_2 = "";
                int j = 0;
                while (s_2[j] != '/')
                {
                    tu_chuoi_2 += s_2[j];
                    j++;// 1
                }
                int m = j + 1;
                while (m != s_2.Length)
                {
                    mau_chuoi_2 += s_2[m];
                    m++;
                }
                int tu_2 = int.Parse(tu_chuoi_2);
                int mau_2 = int.Parse(mau_chuoi_2);
                PhanSo phan_so2 = new PhanSo(tu_2, mau_2);
                PhanSo kq = phan_so1 * phan_so2;
                form2 traVe = new form2(kq.tu, kq.mau);
                traVe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Hãy Nhập Vào Chương Trình Để Thực Hiện");
            }

        }
        public void Thuong()
        {
            int check = 0;
            int dem = 0;
            for (int i = 0; i < txtPhanSo1.Text.Length; i++)
            {
                ++dem;
                if (txtPhanSo1.Text[i] == '/' && txtPhanSo1.Text[0] != '0')
                {
                    check = 1;
                }
            }
            if (txtPhanSo1.Text != "" && check == 1 && dem >= 3)
            {
                // 1/2
                // phan so 1
                string s = txtPhanSo1.Text;//1/2
                string tu_chuoi = "";
                string mau_chuoi = "";
                int i = 0;
                while (s[i] != '/')
                {
                    tu_chuoi += s[i];//1
                    i++;// 1
                }
                int k = i + 1;//
                while (k != s.Length)
                {
                    mau_chuoi += s[k];//2
                    k++;
                }
                int tu = int.Parse(tu_chuoi);
                int mau = int.Parse(mau_chuoi);
                PhanSo phan_so1 = new PhanSo(tu, mau);
                // phan so 2
                string s_2 = txtPhanSo2.Text;
                string tu_chuoi_2 = "";
                string mau_chuoi_2 = "";
                int j = 0;
                while (s_2[j] != '/')
                {
                    tu_chuoi_2 += s_2[j];
                    j++;// 1
                }
                int m = j + 1;
                while (m != s_2.Length)
                {
                    mau_chuoi_2 += s_2[m];
                    m++;
                }
                int tu_2 = int.Parse(tu_chuoi_2);
                int mau_2 = int.Parse(mau_chuoi_2);
                PhanSo phan_so2 = new PhanSo(tu_2, mau_2);
                PhanSo kq = phan_so1 / phan_so2;
                form2 traVe = new form2(kq.tu, kq.mau);
                traVe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Hãy Nhập Vào Chương Trình Để Thực Hiện");
            }

        }

        public void Thoat()
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát Không??",
               "Thông Báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Mòi Bạn Tiếp Tục Sử Dụng Chương Trình");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hieu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tich();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thuong();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Thoat();
        }
    }
}
