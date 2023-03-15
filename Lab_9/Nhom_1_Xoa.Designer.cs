namespace Lab_9
{
    partial class Nhom_1_Xoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.cboLuaChonBangThem = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblHang4 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblHang3 = new System.Windows.Forms.Label();
            this.lblHang2 = new System.Windows.Forms.Label();
            this.lblHang1 = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvHienThi = new System.Windows.Forms.ListView();
            this.cot_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cot_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cot_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cot_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Chọn Bảng Cần Xóa:";
            // 
            // cboLuaChonBangThem
            // 
            this.cboLuaChonBangThem.FormattingEnabled = true;
            this.cboLuaChonBangThem.Items.AddRange(new object[] {
            "KHACHHANG",
            "HANG",
            "HDCT",
            "HOADON"});
            this.cboLuaChonBangThem.Location = new System.Drawing.Point(336, 79);
            this.cboLuaChonBangThem.Name = "cboLuaChonBangThem";
            this.cboLuaChonBangThem.Size = new System.Drawing.Size(309, 33);
            this.cboLuaChonBangThem.TabIndex = 13;
            this.cboLuaChonBangThem.SelectedIndexChanged += new System.EventHandler(this.cboLuaChonBangThem_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(574, 495);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(434, 47);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.lblHang4);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.btnADD);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.lblHang3);
            this.groupBox2.Controls.Add(this.lblHang2);
            this.groupBox2.Controls.Add(this.lblHang1);
            this.groupBox2.Location = new System.Drawing.Point(564, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 340);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Để Thêm";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(209, 208);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(235, 30);
            this.txtGhiChu.TabIndex = 3;
            // 
            // lblHang4
            // 
            this.lblHang4.AutoSize = true;
            this.lblHang4.Location = new System.Drawing.Point(22, 208);
            this.lblHang4.Name = "lblHang4";
            this.lblHang4.Size = new System.Drawing.Size(90, 25);
            this.lblHang4.TabIndex = 6;
            this.lblHang4.Text = "Ghi Chú:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(209, 101);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(235, 30);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(209, 156);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(235, 30);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(27, 262);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(417, 47);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Xóa";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(209, 45);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(235, 30);
            this.txtMaKhachHang.TabIndex = 0;
            // 
            // lblHang3
            // 
            this.lblHang3.AutoSize = true;
            this.lblHang3.Location = new System.Drawing.Point(22, 156);
            this.lblHang3.Name = "lblHang3";
            this.lblHang3.Size = new System.Drawing.Size(59, 25);
            this.lblHang3.TabIndex = 2;
            this.lblHang3.Text = "SĐT:";
            // 
            // lblHang2
            // 
            this.lblHang2.AutoSize = true;
            this.lblHang2.Location = new System.Drawing.Point(22, 101);
            this.lblHang2.Name = "lblHang2";
            this.lblHang2.Size = new System.Drawing.Size(167, 25);
            this.lblHang2.TabIndex = 1;
            this.lblHang2.Text = "Tên Khách Hàng:";
            // 
            // lblHang1
            // 
            this.lblHang1.AutoSize = true;
            this.lblHang1.Location = new System.Drawing.Point(22, 45);
            this.lblHang1.Name = "lblHang1";
            this.lblHang1.Size = new System.Drawing.Size(165, 25);
            this.lblHang1.TabIndex = 0;
            this.lblHang1.Text = "Mã Khách Hàng: ";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Location = new System.Drawing.Point(39, 495);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(496, 47);
            this.btnTroLai.TabIndex = 16;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvHienThi);
            this.groupBox1.Location = new System.Drawing.Point(33, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 355);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiện Thị";
            // 
            // lsvHienThi
            // 
            this.lsvHienThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cot_1,
            this.cot_2,
            this.cot_3,
            this.cot_4});
            this.lsvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvHienThi.FullRowSelect = true;
            this.lsvHienThi.GridLines = true;
            this.lsvHienThi.HideSelection = false;
            this.lsvHienThi.Location = new System.Drawing.Point(3, 26);
            this.lsvHienThi.Name = "lsvHienThi";
            this.lsvHienThi.Size = new System.Drawing.Size(496, 326);
            this.lsvHienThi.TabIndex = 0;
            this.lsvHienThi.UseCompatibleStateImageBehavior = false;
            this.lsvHienThi.SelectedIndexChanged += new System.EventHandler(this.lsvHienThi_SelectedIndexChanged);
            // 
            // cot_1
            // 
            this.cot_1.Text = "MAKH";
            this.cot_1.Width = 80;
            // 
            // cot_2
            // 
            this.cot_2.Text = "TênKH";
            this.cot_2.Width = 150;
            // 
            // cot_3
            // 
            this.cot_3.Text = "SĐT";
            this.cot_3.Width = 120;
            // 
            // cot_4
            // 
            this.cot_4.Text = "Ghi Chú";
            this.cot_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cot_4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chương Trình Xóa";
            // 
            // Nhom_1_Xoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLuaChonBangThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nhom_1_Xoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhom_1_Xoa";
            this.Load += new System.EventHandler(this.Nhom_1_Xoa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLuaChonBangThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblHang4;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblHang3;
        private System.Windows.Forms.Label lblHang2;
        private System.Windows.Forms.Label lblHang1;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvHienThi;
        private System.Windows.Forms.ColumnHeader cot_1;
        private System.Windows.Forms.ColumnHeader cot_2;
        private System.Windows.Forms.ColumnHeader cot_3;
        private System.Windows.Forms.ColumnHeader cot_4;
        private System.Windows.Forms.Label label1;
    }
}