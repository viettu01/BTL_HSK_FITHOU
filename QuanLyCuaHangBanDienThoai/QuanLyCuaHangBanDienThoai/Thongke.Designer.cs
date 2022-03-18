
namespace QuanLyCuaHangBanDienThoai
{
    partial class Thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbĐT = new System.Windows.Forms.RadioButton();
            this.rbNV = new System.Windows.Forms.RadioButton();
            this.rbKH = new System.Windows.Forms.RadioButton();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbLoaiSX = new System.Windows.Forms.ComboBox();
            this.rbTang = new System.Windows.Forms.RadioButton();
            this.rbGiam = new System.Windows.Forms.RadioButton();
            this.crvDT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnHien = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbĐT);
            this.groupBox1.Controls.Add(this.rbNV);
            this.groupBox1.Controls.Add(this.rbKH);
            this.groupBox1.Location = new System.Drawing.Point(116, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theo";
            // 
            // rbĐT
            // 
            this.rbĐT.AutoSize = true;
            this.rbĐT.Location = new System.Drawing.Point(35, 65);
            this.rbĐT.Name = "rbĐT";
            this.rbĐT.Size = new System.Drawing.Size(73, 17);
            this.rbĐT.TabIndex = 2;
            this.rbĐT.TabStop = true;
            this.rbĐT.Text = "Điện thoại";
            this.rbĐT.UseVisualStyleBackColor = true;
            this.rbĐT.CheckedChanged += new System.EventHandler(this.rbĐT_CheckedChanged);
            this.rbĐT.Click += new System.EventHandler(this.rbĐT_Click);
            // 
            // rbNV
            // 
            this.rbNV.AutoSize = true;
            this.rbNV.Location = new System.Drawing.Point(35, 19);
            this.rbNV.Name = "rbNV";
            this.rbNV.Size = new System.Drawing.Size(74, 17);
            this.rbNV.TabIndex = 1;
            this.rbNV.TabStop = true;
            this.rbNV.Text = "Nhân viên";
            this.rbNV.UseVisualStyleBackColor = true;
            this.rbNV.CheckedChanged += new System.EventHandler(this.rbNV_CheckedChanged);
            this.rbNV.Click += new System.EventHandler(this.rbNV_Click);
            // 
            // rbKH
            // 
            this.rbKH.AutoSize = true;
            this.rbKH.Location = new System.Drawing.Point(35, 42);
            this.rbKH.Name = "rbKH";
            this.rbKH.Size = new System.Drawing.Size(83, 17);
            this.rbKH.TabIndex = 0;
            this.rbKH.TabStop = true;
            this.rbKH.Text = "Khách hàng";
            this.rbKH.UseVisualStyleBackColor = true;
            this.rbKH.CheckedChanged += new System.EventHandler(this.rbKH_CheckedChanged);
            this.rbKH.Click += new System.EventHandler(this.rbKH_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(244, 12);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 21);
            this.cbNam.TabIndex = 1;
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
            this.cbThang.Location = new System.Drawing.Point(244, 39);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 21);
            this.cbThang.TabIndex = 2;
            // 
            // cbLoaiSX
            // 
            this.cbLoaiSX.FormattingEnabled = true;
            this.cbLoaiSX.Items.AddRange(new object[] {
            "Số lượng",
            "Doanh thu"});
            this.cbLoaiSX.Location = new System.Drawing.Point(399, 12);
            this.cbLoaiSX.Name = "cbLoaiSX";
            this.cbLoaiSX.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiSX.TabIndex = 3;
            this.cbLoaiSX.Validating += new System.ComponentModel.CancelEventHandler(this.cbLoaiSX_Validating);
            // 
            // rbTang
            // 
            this.rbTang.AutoSize = true;
            this.rbTang.Location = new System.Drawing.Point(6, 14);
            this.rbTang.Name = "rbTang";
            this.rbTang.Size = new System.Drawing.Size(71, 17);
            this.rbTang.TabIndex = 3;
            this.rbTang.Text = "Tăng dần";
            this.rbTang.UseVisualStyleBackColor = true;
            // 
            // rbGiam
            // 
            this.rbGiam.AutoSize = true;
            this.rbGiam.Location = new System.Drawing.Point(83, 13);
            this.rbGiam.Name = "rbGiam";
            this.rbGiam.Size = new System.Drawing.Size(70, 17);
            this.rbGiam.TabIndex = 4;
            this.rbGiam.Text = "Giảm dần";
            this.rbGiam.UseVisualStyleBackColor = true;
            // 
            // crvDT
            // 
            this.crvDT.ActiveViewIndex = -1;
            this.crvDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDT.Location = new System.Drawing.Point(3, 98);
            this.crvDT.Name = "crvDT";
            this.crvDT.Size = new System.Drawing.Size(785, 351);
            this.crvDT.TabIndex = 5;
            // 
            // btnHien
            // 
            this.btnHien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHien.BackgroundImage")));
            this.btnHien.FlatAppearance.BorderSize = 0;
            this.btnHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHien.Location = new System.Drawing.Point(713, 10);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 6;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTang);
            this.groupBox2.Controls.Add(this.rbGiam);
            this.groupBox2.Location = new System.Drawing.Point(399, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 39);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(6, 17);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(68, 17);
            this.rbMax.TabIndex = 8;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "Cao nhất";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(86, 17);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(74, 17);
            this.rbMin.TabIndex = 9;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Thấp nhất";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMax);
            this.groupBox3.Controls.Add(this.rbMin);
            this.groupBox3.Location = new System.Drawing.Point(591, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 40);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.crvDT);
            this.Controls.Add(this.cbLoaiSX);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thongke";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Thongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbĐT;
        private System.Windows.Forms.RadioButton rbNV;
        private System.Windows.Forms.RadioButton rbKH;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbLoaiSX;
        private System.Windows.Forms.RadioButton rbTang;
        private System.Windows.Forms.RadioButton rbGiam;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDT;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}