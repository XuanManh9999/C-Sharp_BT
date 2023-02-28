namespace lap_8_bai_1
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
            this.btn_soDau = new System.Windows.Forms.Button();
            this.btnSoCuoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNhanGiaTri = new System.Windows.Forms.ListBox();
            this.lstDauRa = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_soDau
            // 
            this.btn_soDau.Location = new System.Drawing.Point(406, 98);
            this.btn_soDau.Name = "btn_soDau";
            this.btn_soDau.Size = new System.Drawing.Size(156, 39);
            this.btn_soDau.TabIndex = 0;
            this.btn_soDau.Text = "Numbers_1";
            this.btn_soDau.UseVisualStyleBackColor = true;
            this.btn_soDau.Click += new System.EventHandler(this.btn_soDau_Click);
            // 
            // btnSoCuoi
            // 
            this.btnSoCuoi.Location = new System.Drawing.Point(406, 166);
            this.btnSoCuoi.Name = "btnSoCuoi";
            this.btnSoCuoi.Size = new System.Drawing.Size(156, 38);
            this.btnSoCuoi.TabIndex = 1;
            this.btnSoCuoi.Text = "Numbers_2";
            this.btnSoCuoi.UseVisualStyleBackColor = true;
            this.btnSoCuoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương Trình Đọc Dữ Liệu Từ Database Rồi Thực Hiện Tính Tổng 2 Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hiển Thị Số Đầu Tiên Từ Cơ Sở Dữ Liệu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hiển Thị Số Thứ Hai Từ Cơ Sở Dữ Liệu:";
            // 
            // lstNhanGiaTri
            // 
            this.lstNhanGiaTri.FormattingEnabled = true;
            this.lstNhanGiaTri.ItemHeight = 25;
            this.lstNhanGiaTri.Location = new System.Drawing.Point(604, 98);
            this.lstNhanGiaTri.Name = "lstNhanGiaTri";
            this.lstNhanGiaTri.Size = new System.Drawing.Size(420, 129);
            this.lstNhanGiaTri.TabIndex = 6;
            // 
            // lstDauRa
            // 
            this.lstDauRa.FormattingEnabled = true;
            this.lstDauRa.ItemHeight = 25;
            this.lstDauRa.Location = new System.Drawing.Point(169, 308);
            this.lstDauRa.Name = "lstDauRa";
            this.lstDauRa.Size = new System.Drawing.Size(769, 204);
            this.lstDauRa.TabIndex = 7;
            this.lstDauRa.SelectedIndexChanged += new System.EventHandler(this.lstDauRa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết Quả Tính Tổng 2 Số";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xem_Ket_Qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDauRa);
            this.Controls.Add(this.lstNhanGiaTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSoCuoi);
            this.Controls.Add(this.btn_soDau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_soDau;
        private System.Windows.Forms.Button btnSoCuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNhanGiaTri;
        private System.Windows.Forms.ListBox lstDauRa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

