
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTuoitu
            // 
            this.tbTuoitu.Location = new System.Drawing.Point(49, 28);
            this.tbTuoitu.Name = "tbTuoitu";
            this.tbTuoitu.Size = new System.Drawing.Size(100, 20);
            this.tbTuoitu.TabIndex = 0;
            this.tbTuoitu.Validating += new System.ComponentModel.CancelEventHandler(this.tbTuoitu_Validating);
            // 
            // crvNV
            // 
            this.crvNV.ActiveViewIndex = -1;
            this.crvNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNV.Location = new System.Drawing.Point(12, 74);
            this.crvNV.Name = "crvNV";
            this.crvNV.Size = new System.Drawing.Size(776, 378);
            this.crvNV.TabIndex = 1;
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(367, 28);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 2;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // tbTuoiden
            // 
            this.tbTuoiden.Location = new System.Drawing.Point(214, 28);
            this.tbTuoiden.Name = "tbTuoiden";
            this.tbTuoiden.Size = new System.Drawing.Size(100, 20);
            this.tbTuoiden.TabIndex = 3;
            this.tbTuoiden.Validating += new System.ComponentModel.CancelEventHandler(this.tbTuoiden_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThongKeNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTuoiden);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.crvNV);
            this.Controls.Add(this.tbTuoitu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeNhanvien";
            this.Text = "Thống kê Nhân Viên";
            this.Load += new System.EventHandler(this.ThongKeNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTuoitu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNV;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.TextBox tbTuoiden;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}