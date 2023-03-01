using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_6_form_1
{
    public partial class form2 : Form
    {
        // sử dụng costructor để hiển thị giá trị ra bên ngoài
        public int tu { get; set; } = 2;
        public int mau { get; set; } = 2;
        public  form2 (int tu, int mau)
        {
            InitializeComponent();
            this.tu = tu;
            this.mau = mau;
        
        }
        // nạp chồng to/string hiển thị kết quả
        public string toString()
        {
            string s = $"{tu}/{mau}";
            return s;
        }
        public form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_1 active = new form_1();
            active.ShowDialog();
        }

        private void lstKq_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void form2_Load(object sender, EventArgs e)
        {
           lstKq.Items.Add(toString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
