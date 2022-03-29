
namespace QuanLyCuaHangBanDienThoai
{
    partial class ThongkeHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongkeHoaDon));
            this.crvBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnHien = new System.Windows.Forms.Button();
            this.dtpNgaytu = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayden = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvBill
            // 
            this.crvBill.ActiveViewIndex = -1;
            this.crvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBill.Location = new System.Drawing.Point(12, 62);
            this.crvBill.Name = "crvBill";
            this.crvBill.Size = new System.Drawing.Size(1009, 408);
            this.crvBill.TabIndex = 1;
            this.crvBill.Load += new System.EventHandler(this.crvBill_Load);
            // 
            // btnHien
            // 
            this.btnHien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHien.BackgroundImage")));
            this.btnHien.FlatAppearance.BorderSize = 0;
            this.btnHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHien.Location = new System.Drawing.Point(621, 8);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 3;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // dtpNgaytu
            // 
            this.dtpNgaytu.CustomFormat = " ";
            this.dtpNgaytu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaytu.Location = new System.Drawing.Point(65, 11);
            this.dtpNgaytu.Name = "dtpNgaytu";
            this.dtpNgaytu.Size = new System.Drawing.Size(206, 20);
            this.dtpNgaytu.TabIndex = 1;
            this.dtpNgaytu.ValueChanged += new System.EventHandler(this.dtpNgaytu_ValueChanged);
            // 
            // dtpNgayden
            // 
            this.dtpNgayden.CustomFormat = " ";
            this.dtpNgayden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayden.Location = new System.Drawing.Point(384, 11);
            this.dtpNgayden.Name = "dtpNgayden";
            this.dtpNgayden.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayden.TabIndex = 2;
            this.dtpNgayden.ValueChanged += new System.EventHandler(this.dtpNgayden_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Tag = "";
            this.label2.Text = "Ngày đến";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLammoi.BackgroundImage")));
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLammoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLammoi.Location = new System.Drawing.Point(729, 8);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 8;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // ThongkeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 482);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayden);
            this.Controls.Add(this.dtpNgaytu);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.crvBill);
            this.Name = "ThongkeHoaDon";
            this.Text = "Thống kê hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBill;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.DateTimePicker dtpNgaytu;
        private System.Windows.Forms.DateTimePicker dtpNgayden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLammoi;
    }
}