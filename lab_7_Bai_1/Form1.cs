using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap_7_Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // khởi tạo ô đầu hàng
            ListViewItem item = new ListViewItem(txtTen.Text);
            // thêm vào các cột phía sau
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(txtLop.Text);
            lvSinhVien.Items.Add(item);// thêm vào
            // sau khi add song thì gán tất cả chúng nó thành rõng
            picAnhSinhVien.Visible = true;
        }

        private void btnRemove_at_Click(object sender, EventArgs e)
        {
            // trả về một mảng
            if (lvSinhVien.SelectedItems.Count > 0) {
                lvSinhVien.Items.RemoveAt(lvSinhVien.SelectedItems[0].Index);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // xóa toàn bộ phần tử, xuất phát tử phần tử đầu tiên
            while (lvSinhVien.SelectedItems.Count > 0)
            {
                // xóa toàn bộ giá trị có trong mảng, xuất phát từ 0
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // tức là có phần tử đang select
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                item.SubItems[0].Text = txtTen.Text;
                item.SubItems[1].Text = txtMa.Text;
                item.SubItems[2].Text = txtLop.Text;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedIndices.Count > 0)
            {
                //                              Lấy dòng đầu tiên
                ListViewItem lv1 = lvSinhVien.SelectedItems[0];
                string ten = lv1.SubItems[0].Text; 
                string ma = lv1.SubItems[1].Text; 
                string lop = lv1.SubItems[2].Text;
                txtTen.Text = ten;
                txtMa.Text = ma;
                txtLop.Text = lop;
            }
            picAnhSinhVien.Visible = false;
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                picAnhSinhVien.Visible = false;
            }else
            {
                picAnhSinhVien.Visible = true;
            }
        }
    }
}
