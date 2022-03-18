
namespace QuanLyCuaHangBanDienThoai
{
    partial class ThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhThu));
            this.crvDT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.btnHien = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbLoaiSX = new System.Windows.Forms.ComboBox();
            this.rbTang = new System.Windows.Forms.RadioButton();
            this.rbGiam = new System.Windows.Forms.RadioButton();
            this.rbNV = new System.Windows.Forms.RadioButton();
            this.rbKH = new System.Windows.Forms.RadioButton();
            this.rbĐT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvDT
            // 
            this.crvDT.ActiveViewIndex = -1;
            this.crvDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvDT.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.crvDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDT.Location = new System.Drawing.Point(12, 110);
            this.crvDT.Name = "crvDT";
            this.crvDT.Size = new System.Drawing.Size(675, 327);
            this.crvDT.TabIndex = 44;
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "Tồn kho",
            "Hết hàng",
            "Sắp hết"});
            this.cbTrangthai.Location = new System.Drawing.Point(543, 23);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(121, 21);
            this.cbTrangthai.TabIndex = 45;
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(222, 81);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 46;
            this.btnHien.Text = "Hien";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(222, 32);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 21);
            this.cbNam.TabIndex = 47;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(222, 54);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 21);
            this.cbThang.TabIndex = 48;
            // 
            // cbLoaiSX
            // 
            this.cbLoaiSX.FormattingEnabled = true;
            this.cbLoaiSX.Items.AddRange(new object[] {
            "Doanh thu",
            "SL bán"});
            this.cbLoaiSX.Location = new System.Drawing.Point(349, 32);
            this.cbLoaiSX.Name = "cbLoaiSX";
            this.cbLoaiSX.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiSX.TabIndex = 49;
            // 
            // rbTang
            // 
            this.rbTang.AutoSize = true;
            this.rbTang.Location = new System.Drawing.Point(349, 87);
            this.rbTang.Name = "rbTang";
            this.rbTang.Size = new System.Drawing.Size(71, 17);
            this.rbTang.TabIndex = 51;
            this.rbTang.Text = "Tăng dần";
            this.rbTang.UseVisualStyleBackColor = true;
            this.rbTang.CheckedChanged += new System.EventHandler(this.rbTang_CheckedChanged);
            this.rbTang.Click += new System.EventHandler(this.rbTang_Click);
            // 
            // rbGiam
            // 
            this.rbGiam.AutoSize = true;
            this.rbGiam.Location = new System.Drawing.Point(438, 87);
            this.rbGiam.Name = "rbGiam";
            this.rbGiam.Size = new System.Drawing.Size(70, 17);
            this.rbGiam.TabIndex = 52;
            this.rbGiam.Text = "Giảm dần";
            this.rbGiam.UseVisualStyleBackColor = true;
            this.rbGiam.CheckedChanged += new System.EventHandler(this.rbGiam_CheckedChanged);
            this.rbGiam.Click += new System.EventHandler(this.rbGiam_Click);
            // 
            // rbNV
            // 
            this.rbNV.AutoSize = true;
            this.rbNV.Location = new System.Drawing.Point(12, 19);
            this.rbNV.Name = "rbNV";
            this.rbNV.Size = new System.Drawing.Size(74, 17);
            this.rbNV.TabIndex = 53;
            this.rbNV.TabStop = true;
            this.rbNV.Text = "Nhân viên";
            this.rbNV.UseVisualStyleBackColor = true;
            this.rbNV.CheckedChanged += new System.EventHandler(this.rbNV_CheckedChanged);
            // 
            // rbKH
            // 
            this.rbKH.AutoSize = true;
            this.rbKH.Location = new System.Drawing.Point(12, 42);
            this.rbKH.Name = "rbKH";
            this.rbKH.Size = new System.Drawing.Size(83, 17);
            this.rbKH.TabIndex = 54;
            this.rbKH.TabStop = true;
            this.rbKH.Text = "Khách hàng";
            this.rbKH.UseVisualStyleBackColor = true;
            // 
            // rbĐT
            // 
            this.rbĐT.AutoSize = true;
            this.rbĐT.Location = new System.Drawing.Point(124, 19);
            this.rbĐT.Name = "rbĐT";
            this.rbĐT.Size = new System.Drawing.Size(73, 17);
            this.rbĐT.TabIndex = 55;
            this.rbĐT.TabStop = true;
            this.rbĐT.Text = "Điện thoại";
            this.rbĐT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNV);
            this.groupBox1.Controls.Add(this.rbĐT);
            this.groupBox1.Controls.Add(this.rbKH);
            this.groupBox1.Location = new System.Drawing.Point(0, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 74);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbGiam);
            this.Controls.Add(this.rbTang);
            this.Controls.Add(this.cbLoaiSX);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.crvDT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThongKeDoanhThu";
            this.Text = "Thống kê Doanh Thu";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDT;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbLoaiSX;
        private System.Windows.Forms.RadioButton rbTang;
        private System.Windows.Forms.RadioButton rbGiam;
        private System.Windows.Forms.RadioButton rbNV;
        private System.Windows.Forms.RadioButton rbKH;
        private System.Windows.Forms.RadioButton rbĐT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}