using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8_bai_2
{
    public partial class Form2 : Form
    {
        public double soDau { get; set; }
        public double soHai { get; set; }
        public double soBa { get; set; }
        public Form2(double soDau, double soHai, double soBa)
        {
            InitializeComponent();
            this.soDau = soDau;
            this.soHai = soHai;
            this.soBa = soBa;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kiemTraXemCoLaTamGiacKhong();// câu hỏi đầu
            kiemTraXemLaTamGiacGi();// câu hỏi sau
            tinhChuViTamGiac();
            tinhDienTichTamGiac();
        }
        private void kiemTraXemCoLaTamGiacKhong()
        {
            if (soDau + soHai > soBa && soDau + soBa > soHai && soHai + soBa > soDau) {
                string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Đã Thỏa mãn Yêu Cầu Là Một Tam Giác";
                lstHienThiRaForm2.Items.Add(s);
            }else
            {
                string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Không Thỏa mãn Yêu Cầu Là Một Tam Giác";
                lstHienThiRaForm2.Items.Add(s);
            }
        }
        private void kiemTraXemLaTamGiacGi()
        {
            if (soDau + soHai > soBa && soDau + soBa > soHai && soHai + soBa > soDau)
            {
                if (soDau == soHai && soHai == soBa)
                {
                    string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Đây Là Một Tam Giác Đều!";
                    lstHienThiRaForm2.Items.Add(s);
                }else if (soDau == soHai || soDau == soBa || soHai == soBa)
                {
                    string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Đây Là Một Tam Giác Cân!";
                    lstHienThiRaForm2.Items.Add(s);
                }else if (soDau * soDau + soHai * soHai == soBa * soBa || soDau * soDau + soBa * soBa == soHai * soHai || soHai * soHai + soBa * soBa == soDau * soDau)
                {
                    string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Đây Là Một Tam Giác Vuông!";
                    lstHienThiRaForm2.Items.Add(s);
                }else
                {
                    string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Đây Là Một Tam Giác Thường!";
                    lstHienThiRaForm2.Items.Add(s);
                }
            }else
            {
                string s = $"Với Số Đầu Tiên {soDau}|Số Thứ Hai: {soHai}|Số Thứ Ba: {soBa} -> Không Thỏa mãn Yêu Cầu Là Một Tam Giác";
                lstHienThiRaForm2.Items.Add(s);
            }
        }
        private void tinhChuViTamGiac()
        {
            double kq = soDau + soHai + soBa;
            string s = $"Chu Vi Của Tam Giác Là: {kq}";
            lstHienThiRaForm2.Items.Add(s);
        }
        private async void tinhDienTichTamGiac()
        {
            double p = (soDau + soHai + soBa) / 2;
            double s = (p * (p - soDau) * (p - soHai) * (p - soBa));
            string k = $"Diện Tích Của Tam Giác Là: {s}";
            lstHienThiRaForm2.Items.Add(k);
        }
        private void lstHienThiRaForm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
