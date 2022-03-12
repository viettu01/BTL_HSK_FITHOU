using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class QuanLyCuaHangDienThoai : Form
    {
        public QuanLyCuaHangDienThoai()
        {
            InitializeComponent();
        }

        private void QuanLyCuaHangDienThoai_Load(object sender, EventArgs e)
        {
            //Set màu nền MDI parent
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }
            }

            //if (Program.role.Equals("Nhân viên"))
            //{
            //    toolStripMenuItemQuanLy.Visible = false;
            //    toolStripMenuItemThongKe.Visible = false;
            //}
        }

        private void toolStripMenuItemQuanLy_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            quanLy.MdiParent = this;
            quanLy.Dock = DockStyle.Fill;
            quanLy.Show();
        }

        private void toolStripMenuItemTKDT_Click(object sender, EventArgs e)
        {
            ThongKeDienThoai thongKeDienThoai = new ThongKeDienThoai();
            thongKeDienThoai.MdiParent = this;
            thongKeDienThoai.Dock = DockStyle.Fill;
            thongKeDienThoai.Show();
        }

        private void toolStripMenuItemDangXuat_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void toolStripMenuItemBanHang_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.MdiParent = this;
            banHang.Dock = DockStyle.Fill;
            banHang.Show();
        }
    }
}
