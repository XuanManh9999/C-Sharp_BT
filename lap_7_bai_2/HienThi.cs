using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_7_bai_2
{
    public partial class HienThi : Form
    {
        List<SinhVien> dsSinhVien = new List<SinhVien>();
        // tạo một constructor
        public HienThi(List<SinhVien> dsSinhVien)
        {
            this.dsSinhVien = dsSinhVien;
            InitializeComponent();
        }
        public HienThi()
        {
            InitializeComponent();
        }

        private void HienThi_Load(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = dsSinhVien;
        }
    }
}
