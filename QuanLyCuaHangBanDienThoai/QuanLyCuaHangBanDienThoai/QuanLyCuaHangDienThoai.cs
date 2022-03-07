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
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }
            }
        }

        private void toolStripMenuItemManagement_Click(object sender, EventArgs e)
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
    }
}
