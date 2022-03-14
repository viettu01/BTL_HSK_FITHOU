
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
            this.crvĐT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.btnHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInDoanhThuSanPham
            // 
            this.btnInDoanhThuSanPham.AutoSize = true;
            this.btnInDoanhThuSanPham.Location = new System.Drawing.Point(215, 67);
            this.btnInDoanhThuSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDoanhThuSanPham.Name = "btnInDoanhThuSanPham";
            this.btnInDoanhThuSanPham.Size = new System.Drawing.Size(141, 23);
            this.btnInDoanhThuSanPham.TabIndex = 38;
            this.btnInDoanhThuSanPham.Text = "In danh thu các sản phẩm";
            this.btnInDoanhThuSanPham.UseVisualStyleBackColor = true;
            this.btnInDoanhThuSanPham.Click += new System.EventHandler(this.btnInDoanhThuSanPham_Click);
            // 
            // tbDateStart
            // 
            this.tbDateStart.Location = new System.Drawing.Point(334, 5);
            this.tbDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.Size = new System.Drawing.Size(137, 20);
            this.tbDateStart.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ngày kết thúc";
            // 
            // tbDateEnd
            // 
            this.tbDateEnd.Location = new System.Drawing.Point(334, 35);
            this.tbDateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbDateEnd.Name = "tbDateEnd";
            this.tbDateEnd.Size = new System.Drawing.Size(137, 20);
            this.tbDateEnd.TabIndex = 41;
            // 
            // btnDoanhThuTheoNgay
            // 
            this.btnDoanhThuTheoNgay.AutoSize = true;
            this.btnDoanhThuTheoNgay.Location = new System.Drawing.Point(356, 67);
            this.btnDoanhThuTheoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoanhThuTheoNgay.Name = "btnDoanhThuTheoNgay";
            this.btnDoanhThuTheoNgay.Size = new System.Drawing.Size(176, 23);
            this.btnDoanhThuTheoNgay.TabIndex = 43;
            this.btnDoanhThuTheoNgay.Text = "In doanh thu sản phẩm theo ngày";
            this.btnDoanhThuTheoNgay.UseVisualStyleBackColor = true;
            this.btnDoanhThuTheoNgay.Click += new System.EventHandler(this.btnDoanhThuTheoNgay_Click);
            // 
            // crvĐT
            // 
            this.crvĐT.ActiveViewIndex = -1;
            this.crvĐT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvĐT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvĐT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvĐT.Location = new System.Drawing.Point(12, 110);
            this.crvĐT.Name = "crvĐT";
            this.crvĐT.Size = new System.Drawing.Size(675, 327);
            this.crvĐT.TabIndex = 44;
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "Tồn kho",
            "Hết hàng",
            "Sắp hết"});
            this.cbTrangthai.Location = new System.Drawing.Point(39, 33);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(121, 21);
            this.cbTrangthai.TabIndex = 45;
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(39, 66);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 46;
            this.btnHien.Text = "Hien";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // ThongKeDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 449);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.crvĐT);
            this.Controls.Add(this.btnDoanhThuTheoNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDateEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateStart);
            this.Controls.Add(this.btnInDoanhThuSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvĐT;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.Button btnHien;
    }
}