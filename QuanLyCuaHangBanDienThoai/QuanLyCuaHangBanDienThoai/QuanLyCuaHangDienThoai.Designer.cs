﻿
namespace QuanLyCuaHangBanDienThoai
{
    partial class QuanLyCuaHangDienThoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyCuaHangDienThoai));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTKDT = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQuanLy,
            this.toolStripMenuItemBanHang,
            this.toolStripMenuItemThongKe,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemQuanLy
            // 
            this.toolStripMenuItemQuanLy.Name = "toolStripMenuItemQuanLy";
            this.toolStripMenuItemQuanLy.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItemQuanLy.Text = "Quản lý";
            this.toolStripMenuItemQuanLy.Click += new System.EventHandler(this.toolStripMenuItemQuanLy_Click);
            // 
            // toolStripMenuItemBanHang
            // 
            this.toolStripMenuItemBanHang.Name = "toolStripMenuItemBanHang";
            this.toolStripMenuItemBanHang.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItemBanHang.Text = "Bán hàng";
            // 
            // toolStripMenuItemThongKe
            // 
            this.toolStripMenuItemThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTKDT});
            this.toolStripMenuItemThongKe.Name = "toolStripMenuItemThongKe";
            this.toolStripMenuItemThongKe.Size = new System.Drawing.Size(84, 24);
            this.toolStripMenuItemThongKe.Text = "Thống kê";
            // 
            // toolStripMenuItemTKDT
            // 
            this.toolStripMenuItemTKDT.Name = "toolStripMenuItemTKDT";
            this.toolStripMenuItemTKDT.Size = new System.Drawing.Size(161, 26);
            this.toolStripMenuItemTKDT.Text = "Điện thoại";
            this.toolStripMenuItemTKDT.Click += new System.EventHandler(this.toolStripMenuItemTKDT_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripMenuItemDangXuat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // toolStripMenuItemDangXuat
            // 
            this.toolStripMenuItemDangXuat.Name = "toolStripMenuItemDangXuat";
            this.toolStripMenuItemDangXuat.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemDangXuat.Text = "Đăng xuất";
            this.toolStripMenuItemDangXuat.Click += new System.EventHandler(this.toolStripMenuItemDangXuat_Click);
            // 
            // QuanLyCuaHangDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyCuaHangDienThoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng bán điện thoại";
            this.Load += new System.EventHandler(this.QuanLyCuaHangDienThoai_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBanHang;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThongKe;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTKDT;
    }
}

