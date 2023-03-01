namespace lab_8_bai_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoMot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSo3 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvCoSoDuLieu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddVaoCoSoDuLieu = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindex_1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // txtSoMot
            // 
            this.txtSoMot.Location = new System.Drawing.Point(283, 97);
            this.txtSoMot.Name = "txtSoMot";
            this.txtSoMot.Size = new System.Drawing.Size(176, 30);
            this.txtSoMot.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Số Thực 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Số Thực 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập Số Thực 2:";
            // 
            // txtSo3
            // 
            this.txtSo3.Location = new System.Drawing.Point(283, 198);
            this.txtSo3.Name = "txtSo3";
            this.txtSo3.Size = new System.Drawing.Size(176, 30);
            this.txtSo3.TabIndex = 6;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(283, 149);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(176, 30);
            this.txtSo2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chương Trình Kiểm Tra Tam Giác";
            // 
            // lsvCoSoDuLieu
            // 
            this.lsvCoSoDuLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvCoSoDuLieu.FullRowSelect = true;
            this.lsvCoSoDuLieu.GridLines = true;
            this.lsvCoSoDuLieu.HideSelection = false;
            this.lsvCoSoDuLieu.Location = new System.Drawing.Point(553, 97);
            this.lsvCoSoDuLieu.Name = "lsvCoSoDuLieu";
            this.lsvCoSoDuLieu.Size = new System.Drawing.Size(452, 421);
            this.lsvCoSoDuLieu.TabIndex = 13;
            this.lsvCoSoDuLieu.UseCompatibleStateImageBehavior = false;
            this.lsvCoSoDuLieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Đầu Tiên";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Thứ Hai";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Thứ Ba";
            this.columnHeader3.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dữ Liệu Đang Có Trong Cơ Sở Dữ Liệu";
            // 
            // btnAddVaoCoSoDuLieu
            // 
            this.btnAddVaoCoSoDuLieu.Location = new System.Drawing.Point(82, 325);
            this.btnAddVaoCoSoDuLieu.Name = "btnAddVaoCoSoDuLieu";
            this.btnAddVaoCoSoDuLieu.Size = new System.Drawing.Size(381, 43);
            this.btnAddVaoCoSoDuLieu.TabIndex = 8;
            this.btnAddVaoCoSoDuLieu.Text = "Thêm Vào Cơ Sở Dữ Liệu";
            this.btnAddVaoCoSoDuLieu.UseVisualStyleBackColor = true;
            this.btnAddVaoCoSoDuLieu.Click += new System.EventHandler(this.btnAddVaoCoSoDuLieu_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(78, 422);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(385, 45);
            this.btnHoanTat.TabIndex = 10;
            this.btnHoanTat.Text = "Hoàn Tất ";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vị Trí Dùng Để Tính Toán: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 18;
            // 
            // txtindex_1
            // 
            this.txtindex_1.Location = new System.Drawing.Point(283, 264);
            this.txtindex_1.Name = "txtindex_1";
            this.txtindex_1.Size = new System.Drawing.Size(176, 30);
            this.txtindex_1.TabIndex = 7;
            this.txtindex_1.TextChanged += new System.EventHandler(this.txtindex_1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(381, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa Toàn Bộ Cơ Sở Dữ Liệu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtindex_1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.btnAddVaoCoSoDuLieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lsvCoSoDuLieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoMot);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoMot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSo3;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvCoSoDuLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddVaoCoSoDuLieu;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtindex_1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

