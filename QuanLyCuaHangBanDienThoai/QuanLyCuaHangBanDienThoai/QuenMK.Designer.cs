
namespace QuanLyCuaHangBanDienThoai
{
    partial class QuenMK
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
            this.tbTênĐN = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbMKm = new System.Windows.Forms.TextBox();
            this.tbMKml = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTênĐN
            // 
            this.tbTênĐN.Location = new System.Drawing.Point(143, 23);
            this.tbTênĐN.Name = "tbTênĐN";
            this.tbTênĐN.Size = new System.Drawing.Size(134, 20);
            this.tbTênĐN.TabIndex = 0;
            this.tbTênĐN.Validating += new System.ComponentModel.CancelEventHandler(this.tbTênĐN_Validating_1);
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(143, 63);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(134, 20);
            this.tbSDT.TabIndex = 1;
            this.tbSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txSDT_Validating);
            // 
            // tbMKm
            // 
            this.tbMKm.Location = new System.Drawing.Point(143, 105);
            this.tbMKm.Name = "tbMKm";
            this.tbMKm.Size = new System.Drawing.Size(134, 20);
            this.tbMKm.TabIndex = 2;
            this.tbMKm.Validating += new System.ComponentModel.CancelEventHandler(this.tbMKm_Validating);
            // 
            // tbMKml
            // 
            this.tbMKml.Location = new System.Drawing.Point(143, 155);
            this.tbMKml.Name = "tbMKml";
            this.tbMKml.Size = new System.Drawing.Size(134, 20);
            this.tbMKml.TabIndex = 3;
            this.tbMKml.Validating += new System.ComponentModel.CancelEventHandler(this.tbMKml_Validating);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(143, 204);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(134, 23);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Đổi mât khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên ĐN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(86, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập lại:";
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.tbMKml);
            this.Controls.Add(this.tbMKm);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbTênĐN);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "QuenMK";
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTênĐN;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbMKm;
        private System.Windows.Forms.TextBox tbMKml;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}