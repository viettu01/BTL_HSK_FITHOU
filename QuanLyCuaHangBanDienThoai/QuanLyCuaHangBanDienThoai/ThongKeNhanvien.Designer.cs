
namespace QuanLyCuaHangBanDienThoai
{
    partial class ThongKeNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeNhanvien));
            this.tbTuoitu = new System.Windows.Forms.TextBox();
            this.crvNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnHien = new System.Windows.Forms.Button();
            this.tbTuoiden = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbTang = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbGiam = new System.Windows.Forms.RadioButton();
            this.cbLoaiSX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTuoitu
            // 
            this.tbTuoitu.Location = new System.Drawing.Point(63, 34);
            this.tbTuoitu.Name = "tbTuoitu";
            this.tbTuoitu.Size = new System.Drawing.Size(100, 20);
            this.tbTuoitu.TabIndex = 1;
            this.tbTuoitu.Validating += new System.ComponentModel.CancelEventHandler(this.tbTuoitu_Validating);
            // 
            // crvNV
            // 
            this.crvNV.ActiveViewIndex = -1;
            this.crvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNV.Location = new System.Drawing.Point(12, 183);
            this.crvNV.Name = "crvNV";
            this.crvNV.Size = new System.Drawing.Size(776, 269);
            this.crvNV.TabIndex = 1;
            // 
            // btnHien
            // 
            this.btnHien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHien.BackgroundImage")));
            this.btnHien.FlatAppearance.BorderSize = 0;
            this.btnHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHien.Location = new System.Drawing.Point(419, 32);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 3;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // tbTuoiden
            // 
            this.tbTuoiden.Location = new System.Drawing.Point(266, 34);
            this.tbTuoiden.Name = "tbTuoiden";
            this.tbTuoiden.Size = new System.Drawing.Size(100, 20);
            this.tbTuoiden.TabIndex = 2;
            this.tbTuoiden.Validating += new System.ComponentModel.CancelEventHandler(this.tbTuoiden_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tuổi từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tuổi đến:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Năm";
            // 
            // cbNam
            // 
            this.cbNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(63, 76);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 21);
            this.cbNam.TabIndex = 13;
            // 
            // cbThang
            // 
            this.cbThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cbThang.Location = new System.Drawing.Point(63, 105);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 21);
            this.cbThang.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbMax);
            this.groupBox2.Controls.Add(this.rbTang);
            this.groupBox2.Controls.Add(this.rbMin);
            this.groupBox2.Controls.Add(this.rbGiam);
            this.groupBox2.Controls.Add(this.cbLoaiSX);
            this.groupBox2.Location = new System.Drawing.Point(216, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 101);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại";
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Enabled = false;
            this.rbMax.Location = new System.Drawing.Point(16, 74);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(68, 17);
            this.rbMax.TabIndex = 6;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "Cao nhất";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbTang
            // 
            this.rbTang.AutoSize = true;
            this.rbTang.Enabled = false;
            this.rbTang.Location = new System.Drawing.Point(16, 47);
            this.rbTang.Name = "rbTang";
            this.rbTang.Size = new System.Drawing.Size(71, 17);
            this.rbTang.TabIndex = 4;
            this.rbTang.Text = "Tăng dần";
            this.rbTang.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Enabled = false;
            this.rbMin.Location = new System.Drawing.Point(90, 74);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(74, 17);
            this.rbMin.TabIndex = 7;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Thấp nhất";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // rbGiam
            // 
            this.rbGiam.AutoSize = true;
            this.rbGiam.Enabled = false;
            this.rbGiam.Location = new System.Drawing.Point(90, 46);
            this.rbGiam.Name = "rbGiam";
            this.rbGiam.Size = new System.Drawing.Size(70, 17);
            this.rbGiam.TabIndex = 5;
            this.rbGiam.Text = "Giảm dần";
            this.rbGiam.UseVisualStyleBackColor = true;
            // 
            // cbLoaiSX
            // 
            this.cbLoaiSX.FormattingEnabled = true;
            this.cbLoaiSX.Items.AddRange(new object[] {
            "Số lượng",
            "Doanh thu"});
            this.cbLoaiSX.Location = new System.Drawing.Point(37, 16);
            this.cbLoaiSX.Name = "cbLoaiSX";
            this.cbLoaiSX.Size = new System.Drawing.Size(132, 21);
            this.cbLoaiSX.TabIndex = 3;
            this.cbLoaiSX.TextChanged += new System.EventHandler(this.cbLoaiSX_TextChanged);
            // 
            // ThongKeNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTuoiden);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.crvNV);
            this.Controls.Add(this.tbTuoitu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeNhanvien";
            this.Text = "Thống kê Nhân Viên theo tuổi";
            this.Load += new System.EventHandler(this.ThongKeNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTuoitu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNV;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.TextBox tbTuoiden;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbTang;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbGiam;
        private System.Windows.Forms.ComboBox cbLoaiSX;
    }
}