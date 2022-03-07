using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class ThongKeDienThoai : Form
    {
        ProducerDao producerDao = new ProducerDao();
        BaoCao baoCao = new BaoCao();

        public ThongKeDienThoai()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            //producerDao.loadDataProducerCombox(cbHang);
        }

        private void btnInDoanhThuSanPham_Click(object sender, EventArgs e)
        {
            baoCao.showReport("CrystalReportDoanhThuDienThoai.rpt", "");
            baoCao.Show();
        }

        private void btnDoanhThuTheoNgay_Click(object sender, EventArgs e)
        {
            String filter = "{showDoanhThuSanPhamTheoNgay.Ngày bán} >= #" + DateTime.Parse(tbDateStart.Text) 
                + "# AND {showDoanhThuSanPhamTheoNgay.Ngày bán} <= #" + DateTime.Parse(tbDateEnd.Text) + "#";
            //baoCao.showReportDoanhThuSanPhamTheoNgay(DateTime.Parse(tbDateStart.Text), DateTime.Parse(tbDateEnd.Text));
            baoCao.showReport("CrystalReportDoanhThuTheoNgay.rpt", filter);
            baoCao.Show();
        }
    }
}
