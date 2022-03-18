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
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;
using QuanLyCuaHangBanDienThoai.CrytalReport;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class ThongKeDoanhThu : Form
    {
        ProducerDao producerDao = new ProducerDao();
        BaoCao baoCao = new BaoCao();
        String constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        bool isChecked = false;
        String TKDT = @"..\..\CrytalReport\ThongkeDoanhThu.rpt";
        String SXTKDT = @"..\..\CrytalReport\SXTKDT.rpt";

        String TKĐT = @"..\..\CrytalReport\ThongkeĐT.rpt";
        String SXTKĐT = @"..\..\CrytalReport\SXTKĐT.rpt";
        String TKNV = @"..\..\CrytalReport\ThongkeNV.rpt";
        String SXTKNV = @"..\..\CrytalReport\SXTKNV.rpt";
        String TKKH = @"..\..\CrytalReport\ThongkeKH.rpt";
        String SXTKKH = @"..\..\CrytalReport\SXTKKH.rpt";
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            //producerDao.loadDataProducerCombox(cbHang);
             loadYearCombox(cbNam);
            /*ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(@"../../CrytalReport/ThongkeĐT.rpt");
            rp.Load(path);
            crvĐT.ReportSource = rp;
            crvĐT.Refresh();*/
            //cbLoaiSX.Text = "";
            /*  using (SqlConnection cnn = new SqlConnection(constr))
              {
                  cnn.Open();
                  using (SqlCommand cmd = new SqlCommand("Select * from TKNV", cnn))
                  {
                      using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                      {
                          DataSet1 ds = new DataSet1();
                          DataTable dt = new DataTable();
                          ad.Fill(ds);
                          //ThongKeDienThoai rpt = new ThongKeDienThoai();
                          ReportDocument rpt = new ReportDocument();
                          String path = Path.GetFullPath(@"C:\Users\Admin\source\repos\BTLLLLLLLLLLLLLLLLLLLLLLLLLL\BTL_HSK_FITHOU\QuanLyCuaHangBanDienThoai\QuanLyCuaHangBanDienThoai\CrytalReport\SXTKNV.rpt");
                          rpt.Load(path);
                          rpt.SetDataSource(ds.Tables[2]);
                          crvDT.ReportSource = rpt;
                          crvDT.Refresh();
                      }
                  }
              }*/

            /*using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from TKKH", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet1 ds = new DataSet1();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(@"C:\Users\Admin\source\repos\BTLLLLLLLLLLLLLLLLLLLLLLLLLL\BTL_HSK_FITHOU\QuanLyCuaHangBanDienThoai\QuanLyCuaHangBanDienThoai\CrytalReport\SXTKKH.rpt");
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[3]);
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }*/

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from TKDT", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet1 ds = new DataSet1();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKDT);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[4]);
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }
        }

        /*private void btnInDoanhThuSanPham_Click(object sender, EventArgs e)
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
        }*/
        public DataTable findAllTKĐT()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select distinct [Năm] from TKĐT", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("TKĐT"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public void loadYearCombox(ComboBox cb)
        {
            DataTable dtProducer = findAllTKĐT();
            DataView v = new DataView(dtProducer);
            v.Sort = "Năm";

            cb.DataSource = v;
            cb.DisplayMember = "Năm";
            cb.ValueMember = "Năm";

        }

 
        private void locnamthang(string lenh,string ten)
        {
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(ten);
            rp.Load(path);
            rp.RecordSelectionFormula = lenh;
            crvDT.ReportSource = rp;
            crvDT.Refresh();
        }

        private void sapxep(string kieu,string ten,string loai,int i,string tenv)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from "+tenv+" WHERE [Năm] like '%"+cbNam.Text+"%' and[Tháng]like'%"+cbThang.Text+"%'order by["+loai+"] "+kieu, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet1 ds = new DataSet1();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(ten);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[i]);
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }
        }
        private void sapxep()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from TKNV ", cnn))

                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataSet2 ds = new DataSet2();
                    DataTable dt = new DataTable();
                    ad.Fill(ds);
                    //ThongKeDienThoai rpt = new ThongKeDienThoai();
                    ReportDocument rpt = new ReportDocument();
                    String path = Path.GetFullPath(@"C:\Users\Admin\source\repos\BTLLLLLLLLLLLLLLLLLLLLLLLLLL\BTL_HSK_FITHOU\QuanLyCuaHangBanDienThoai\QuanLyCuaHangBanDienThoai\CrytalReport\CrystalReport1.rpt");
                    rpt.Load(path);
                    rpt.SetDataSource(ds.Tables[1]);
                    crvDT.ReportSource = rpt;
                    crvDT.Refresh();
                }
            }
        }
        private void sapxep1()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TKNV  ", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet2 ds = new DataSet2();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(@"C:\Users\Admin\source\repos\BTLLLLLLLLLLLLLLLLLLLLLLLLLL\BTL_HSK_FITHOU\QuanLyCuaHangBanDienThoai\QuanLyCuaHangBanDienThoai\CrytalReport\SXTKNV.rpt");
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }
        }
        private void filter(string ten1,string ten2,string loai1,string loai2,int i,String tenv)
        {
            if (cbNam.Text != "")
            {

                if (cbThang.Text != "")
                {

                    if (cbLoaiSX.Text == "")
                    {
                        if (!rbTang.Checked && !rbGiam.Checked)
                        {
                            locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text,ten1);
                        }
                        else
                        {
                            MessageBox.Show("Mời bạn nhập kiểu sắp xếp");
                        }




                    }
                    else
                    {

                        if (!rbTang.Checked && !rbGiam.Checked)
                        {
                            MessageBox.Show("Mời bạn chọn kiểu sắp xếp");

                        }
                        if (cbLoaiSX.Text == "SL bán")
                        {

                            if (rbGiam.Checked)
                            {

                                
                                sapxep("desc",ten2,loai1,i,tenv);
                            }

                            else if (rbTang.Checked)
                            {
                               
                                sapxep("asc", ten2, loai1, i,tenv);
                            }
                        }
                        if (cbLoaiSX.Text == "Doanh thu")

                        {

                            if (rbTang.Checked)
                            {
                               
                                sapxep("asc", ten2, loai2, i,tenv);
                            }
                            else if (rbGiam.Checked)
                            {
                                
                                sapxep("desc", ten2, loai2, i, tenv);
                                MessageBox.Show("ok");

                            }
                        }
                    }

                }
                else
                {

                    if (cbLoaiSX.Text == "")
                    {
                        if (!rbTang.Checked && !rbGiam.Checked)
                        {
                            locnamthang("{@Nam}=" + cbNam.Text,ten1);
                        }
                        else
                        {
                            MessageBox.Show("Mời bạn nhập kiểu sắp xếp");
                        }




                    }
                    else
                    {

                        if (!rbTang.Checked && !rbGiam.Checked)
                        {
                            MessageBox.Show("Mời bạn chọn kiểu sắp xếp");

                        }
                        if (cbLoaiSX.Text == "SL bán")
                        {

                            if (rbGiam.Checked)
                            {


                                sapxep("desc", ten2, loai1, i, tenv);
                            }

                            else if (rbTang.Checked)
                            {

                                sapxep("asc", ten2, loai1, i, tenv);
                            }
                        }
                        if (cbLoaiSX.Text == "Doanh thu")

                        {

                            if (rbTang.Checked)
                            {

                                sapxep("asc", ten2, loai2, i, tenv);
                            }
                            else if (rbGiam.Checked)
                            {

                                sapxep("desc", ten2, loai2, i, tenv);
                                MessageBox.Show("ok");

                            }
                        }
                    }

                }


            }
            else
            {
                //ThongKe_Load(sender, e);
                MessageBox.Show("MỜI CHỌN NĂM");
            }


        }
    
        private void btnHien_Click(object sender, EventArgs e)
        {
            /*if (cbTrangthai.Text == "Tồn kho")
                loctrangthai("{ showAllPhone.SL}>" + "100");
            else if (cbTrangthai.Text == "Hết hàng")
            {
                loctrangthai("{ showAllPhone.SL}=" + "0");
            }
            else if (cbTrangthai.Text == "Sắp hết")
            {
                loctrangthai("{ showAllPhone.SL}<" + "10");
            }
*/
            //sapxep1();
            if (rbNV.Checked)
            {
                sapxep();
            }
            //filter(TKDT, SXTKDT, "SLĐT bán", "Doanh thu", 4,"TKDT");
            //locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, TKNV);
            //sapxep1("desc","Doanh thu");
        }
        //bỏ chọn radio
        private void rbTang_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbTang.Checked;
        }

        private void rbTang_Click(object sender, EventArgs e)
        {
            if (rbTang.Checked && !isChecked)
                rbTang.Checked = false;
            else
            {
                rbTang.Checked = true;
                isChecked = false;
            }
        }

        private void rbGiam_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbGiam.Checked;
        }

        private void rbGiam_Click(object sender, EventArgs e)
        {
            if (rbGiam.Checked && !isChecked)
                rbGiam.Checked = false;
            else
            {
                rbGiam.Checked = true;
                isChecked = false;
            }
        }

        private void rbNV_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
