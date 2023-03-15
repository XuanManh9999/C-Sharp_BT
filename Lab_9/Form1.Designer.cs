namespace Lab_9
{
    partial class FormTrangChu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTruyVan = new System.Windows.Forms.Button();
            this.btnQuanLyNhaHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các Chức Năng Của Lab 9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Các Thủ Tục Thêm, Sửa, Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Location = new System.Drawing.Point(344, 253);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(366, 46);
            this.btnTruyVan.TabIndex = 2;
            this.btnTruyVan.Text = "Các Thủ Tục Truy Vấn";
            this.btnTruyVan.UseVisualStyleBackColor = true;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // btnQuanLyNhaHang
            // 
            this.btnQuanLyNhaHang.Location = new System.Drawing.Point(344, 350);
            this.btnQuanLyNhaHang.Name = "btnQuanLyNhaHang";
            this.btnQuanLyNhaHang.Size = new System.Drawing.Size(366, 46);
            this.btnQuanLyNhaHang.TabIndex = 3;
            this.btnQuanLyNhaHang.Text = "Quản Lý Nhà Hàng";
            this.btnQuanLyNhaHang.UseVisualStyleBackColor = true;
            this.btnQuanLyNhaHang.Click += new System.EventHandler(this.btnQuanLyNhaHang_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnQuanLyNhaHang);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTruyVan;
        private System.Windows.Forms.Button btnQuanLyNhaHang;
    }
}

