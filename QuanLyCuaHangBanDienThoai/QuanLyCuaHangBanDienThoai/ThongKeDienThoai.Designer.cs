
namespace QuanLyCuaHangBanDienThoai
{
    partial class ThongKeDienThoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDienThoai));
            this.btnInDoanhThuSanPham = new System.Windows.Forms.Button();
            this.tbDateStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDateEnd = new System.Windows.Forms.TextBox();
            this.btnDoanhThuTheoNgay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInDoanhThuSanPham
            // 
            this.btnInDoanhThuSanPham.AutoSize = true;
            this.btnInDoanhThuSanPham.Location = new System.Drawing.Point(287, 82);
            this.btnInDoanhThuSanPham.Name = "btnInDoanhThuSanPham";
            this.btnInDoanhThuSanPham.Size = new System.Drawing.Size(181, 27);
            this.btnInDoanhThuSanPham.TabIndex = 38;
            this.btnInDoanhThuSanPham.Text = "In danh thu các sản phẩm";
            this.btnInDoanhThuSanPham.UseVisualStyleBackColor = true;
            this.btnInDoanhThuSanPham.Click += new System.EventHandler(this.btnInDoanhThuSanPham_Click);
            // 
            // tbDateStart
            // 
            this.tbDateStart.Location = new System.Drawing.Point(445, 6);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.Size = new System.Drawing.Size(181, 22);
            this.tbDateStart.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ngày kết thúc";
            // 
            // tbDateEnd
            // 
            this.tbDateEnd.Location = new System.Drawing.Point(445, 43);
            this.tbDateEnd.Name = "tbDateEnd";
            this.tbDateEnd.Size = new System.Drawing.Size(181, 22);
            this.tbDateEnd.TabIndex = 41;
            // 
            // btnDoanhThuTheoNgay
            // 
            this.btnDoanhThuTheoNgay.AutoSize = true;
            this.btnDoanhThuTheoNgay.Location = new System.Drawing.Point(474, 82);
            this.btnDoanhThuTheoNgay.Name = "btnDoanhThuTheoNgay";
            this.btnDoanhThuTheoNgay.Size = new System.Drawing.Size(230, 27);
            this.btnDoanhThuTheoNgay.TabIndex = 43;
            this.btnDoanhThuTheoNgay.Text = "In doanh thu sản phẩm theo ngày";
            this.btnDoanhThuTheoNgay.UseVisualStyleBackColor = true;
            this.btnDoanhThuTheoNgay.Click += new System.EventHandler(this.btnDoanhThuTheoNgay_Click);
            // 
            // ThongKeDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnDoanhThuTheoNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDateEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateStart);
            this.Controls.Add(this.btnInDoanhThuSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeDienThoai";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInDoanhThuSanPham;
        private System.Windows.Forms.TextBox tbDateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDateEnd;
        private System.Windows.Forms.Button btnDoanhThuTheoNgay;
    }
}