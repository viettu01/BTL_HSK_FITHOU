using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        public void showReport(String fileCrystalReport, String filter)
        {
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(@"../../CrytalReport/" + fileCrystalReport);
            rp.Load(path);
            rp.RecordSelectionFormula = filter;
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }

        //public void showReportDoanhThuSanPham()
        //{
        //    ReportDocument rp = new ReportDocument();
        //    String path = Path.GetFullPath(@"../../CrytalReport/CrystalReportDoanhThuDienThoai.rpt");
        //    rp.Load(path);
        //    //rp.RecordSelectionFormula = "{showAllPhone.Hãng} = '" + producer + "'";
        //    //rp.RecordSelectionFormula = "{SACH.TieuDe} = 'Lập trình C/C++'";
        //    crystalReportViewer1.ReportSource = rp;
        //    crystalReportViewer1.Refresh();
        //}

        //public void showReportDoanhThuSanPhamTheoNgay(DateTime startDate, DateTime endDate)
        //{
        //    ReportDocument rp1 = new ReportDocument();
        //    String path = Path.GetFullPath(@"../../CrytalReport/CrystalReportDoanhThuTheoNgay.rpt");
        //    rp1.Load(path);
        //    rp1.RecordSelectionFormula = "{showDoanhThuSanPhamTheoNgay.Ngày bán} >= #" + startDate + "# AND {showDoanhThuSanPhamTheoNgay.Ngày bán} <= #" + endDate + "#";
        //    crystalReportViewer1.ReportSource = rp1;
        //    crystalReportViewer1.Refresh();
        //}
    }
}
