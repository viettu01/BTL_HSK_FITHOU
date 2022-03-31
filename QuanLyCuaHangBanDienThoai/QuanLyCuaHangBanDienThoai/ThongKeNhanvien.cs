using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;
using QuanLyCuaHangBanDienThoai.CrytalReport;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class ThongKeNhanvien : Form
    {
        String constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        bool test = true;
        String TKNV = @"..\..\CrytalReport\ThongkeNV.rpt";
        String SXTKNV = @"..\..\CrytalReport\SXTKNV.rpt";
        String SXTKNVtheoNam = @"..\..\CrytalReport\SXTKNVtheoNam.rpt";
        public ThongKeNhanvien()
        {
            InitializeComponent();
        }
        //Load năm trong cbNăm
        public DataTable findAllTKNV()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select distinct [Năm] from TKNV", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("TKNV"))
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
            DataTable dtProducer = findAllTKNV();
            DataView v = new DataView(dtProducer);
            v.Sort = "Năm";

            cb.DataSource = v;
            cb.DisplayMember = "Năm";
            cb.ValueMember = "Năm";
        }
        private void ThongKeNhanvien_Load(object sender, EventArgs e)
        {
            // sapxep();
            loadYearCombox(cbNam);
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(@"..\..\CrytalReport\ThongkeTuoiNV.rpt");
            rp.Load(path);

            crvNV.ReportSource = rp;
            crvNV.Refresh();
        }


        private void SXNV(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                String sql = "select * from TKNV WHERE [Năm] like '%" + cbNam.Text + "%' and[Tháng]like'%" + cbThang.Text + "%'order by[" + loai + "] " + kieu;
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet2 ds = new DataSet2();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKNV);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvNV.ReportSource = rpt;
                        crvNV.Refresh();
                    }
                }
            }
        }

        private void MinmaxNV(string mm, string loai, string thang)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                String sql = "select [Mã NV],[Tên NV],[Tuổi],[SLĐT bán],[Doanh thu],TKNV.[Tháng],TKNV.[Năm] from TKNV, (select[Tháng],[Năm], " + mm + "([" + loai + "]) as maxtin from TKNV group by [Năm], [Tháng])a where TKNV.Tháng = " + thang + " and [" + loai + "] = a.maxtin and TKNV.[Năm] like'%" + cbNam.Text + "%' GROUP BY [Mã NV],[Tên NV],[Tuổi],[SLĐT bán],[Doanh thu],TKNV.[Tháng],TKNV.[Năm]";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    // MessageBox.Show("select [Mã NV],[Tên NV],[Tuổi],[SLĐT bán],[Doanh thu],TKNV.[Tháng],TKNV.[Năm] from TKNV, (select[Tháng],[Năm], a.Tháng ([" + loai + "]) as maxtin from TKNV group by [Năm], [Tháng])a where TKNV.Tháng = " + thang + " and [" + loai + "] = a.maxtin and TKNV.[Năm] like'%" + cbNam.Text + "%'");

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet2 ds = new DataSet2();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKNV);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvNV.ReportSource = rpt;
                        crvNV.Refresh();
                    }
                }
            }
        }

        private void sapxep()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from TKNV", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet2 ds = new DataSet2();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(@"..\..\CrytalReport\SXTKNV.rpt");
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvNV.ReportSource = rpt;
                        crvNV.Refresh();
                    }
                }
            }
        }
        private void TKNVtheoNam()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                String sql = "select   [Mã NV], [Tên NV],[Tuổi],sum ([SLĐT bán])as [SLĐT bán],sum([Doanh thu]) as [Doanh thu], [Năm] from TKNV where [Năm] like N'" + cbNam.Text + "' group by[Mã NV], [Tên NV],[Tuổi],[Năm]  ";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet5 ds = new DataSet5();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKNVtheoNam);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvNV.ReportSource = rpt;
                        crvNV.Refresh();
                    }
                }
            }
        }
        private void SXNVtheonam(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                String sql = "select   [Mã NV], [Tên NV],[Tuổi],sum ([SLĐT bán])as [SLĐT bán],sum([Doanh thu]) as [Doanh thu], [Năm] from TKNV where [Năm] like N'" + cbNam.Text + "' group by[Mã NV], [Tên NV],[Tuổi],[Năm] order by sum([" + loai + "]) " + kieu;
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet5 ds = new DataSet5();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKNVtheoNam);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvNV.ReportSource = rpt;
                        crvNV.Refresh();
                    }
                }
            }
        }
        private void MinmaxNVtheoNam(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                String sql = "select top(1)  [Mã NV], [Tên NV],[Tuổi],sum ([SLĐT bán])as [SLĐT bán],sum([Doanh thu]) as [Doanh thu], [Năm] from TKNV where [Năm] like N'" + cbNam.Text + "' group by[Mã NV], [Tên NV],[Tuổi],[Năm] order by sum([" + loai + "]) " + kieu;
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet5 ds = new DataSet5();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKNVtheoNam);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvNV.ReportSource = rpt;
                        crvNV.Refresh();
                    }
                }
            }
        }
        private void loctuoi(string lenh)
        {
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(@"..\..\CrytalReport\ThongkeTuoiNV.rpt");
            rp.Load(path);
            rp.RecordSelectionFormula = lenh;
            crvNV.ReportSource = rp;
            crvNV.Refresh();
        }
        private void locnamthang(string lenh, string ten)
        {
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(ten);
            rp.Load(path);
            rp.RecordSelectionFormula = lenh;
            crvNV.ReportSource = rp;
            crvNV.Refresh();
        }
        private void loc()
        {
            if (cbNam.Text != "")//năm
            {
                if (cbThang.Text != "")//năm+tháng
                {
                    if (cbLoaiSX.Text == "")//năm+tháng +loaisx
                    {
                        if (!rbTang.Checked && !rbGiam.Checked && !rbMin.Checked && !rbMax.Checked)//không có kiểu sx
                        {


                            locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, TKNV);

                        }
                        else
                            MessageBox.Show("Mời bạn nhập kiểu sắp xếp");
                    }
                    else
                    {
                        if (!rbTang.Checked && !rbGiam.Checked && !rbMin.Checked && !rbMax.Checked)
                            MessageBox.Show("Mời bạn chọn kiểu sắp xếp");
                        if (cbLoaiSX.Text == "Số lượng")
                        {
                            if (rbGiam.Checked)
                            {
                                SXNV("desc", "SLĐT bán");
                            }
                            else if (rbTang.Checked)
                            {


                                SXNV("asc", "SLĐT bán");

                            }
                            else if (rbMax.Checked)
                            {

                                MinmaxNV("Max", "SLĐT bán", cbThang.Text);

                            }
                            else if (rbMin.Checked)
                            {

                                MinmaxNV("Min", "SLĐT bán", cbThang.Text);

                            }
                        }
                        if (cbLoaiSX.Text == "Doanh thu")
                        {
                            if (rbTang.Checked)
                            {
                                // sapxep("asc", ten2, loai2, i, tenv);

                                SXNV("asc", "Doanh thu");

                            }
                            else if (rbGiam.Checked)
                            {

                                SXNV("desc", "Doanh thu");

                                //MessageBox.Show("ok");
                            }
                            else if (rbMax.Checked)
                            {

                                MinmaxNV("Max", "Doanh thu", cbThang.Text);

                            }
                            else if (rbMin.Checked)
                            {

                                MinmaxNV("Min", "Doanh thu", cbThang.Text);

                            }
                        }
                    }
                }
                else//năm thôi
                {
                    if (cbLoaiSX.Text == "")
                    {
                        if (!rbTang.Checked && !rbGiam.Checked && !rbMin.Checked && !rbMax.Checked)
                        {
                            MessageBox.Show("Lọc mỗi năm");
                            TKNVtheoNam();

                        }
                        else
                            MessageBox.Show("Mời bạn nhập loại sắp xếp");
                    }
                    else
                    {
                        if (!rbTang.Checked && !rbGiam.Checked && !rbMin.Checked && !rbMax.Checked)
                            MessageBox.Show("Mời bạn chọn kiểu sắp xếp");
                        if (cbLoaiSX.Text == "Số lượng")
                        {
                            if (rbGiam.Checked)
                            {

                                SXNVtheonam("desc", "SLĐT bán");

                            }
                            else if (rbTang.Checked)
                            {
                                // sapxep("asc", ten2, loai1, i, tenv);

                                SXNVtheonam("asc", "SLĐT bán");

                            }
                            else if (rbMax.Checked)
                            {


                                MinmaxNVtheoNam("desc", "SLĐT bán");

                            }
                            else if (rbMin.Checked)
                            {

                                MinmaxNVtheoNam("asc", "SLĐT bán");

                            }
                        }
                        if (cbLoaiSX.Text == "Doanh thu")
                        {
                            if (rbTang.Checked)
                            {

                                SXNVtheonam("asc", "Doanh thu");

                            }
                            else if (rbGiam.Checked)
                            {

                                SXNVtheonam("desc", "Doanh thu");

                            }
                            else if (rbMax.Checked)
                            {

                                MinmaxNVtheoNam("desc", "Doanh thu");

                            }
                            else if (rbMin.Checked)
                            {

                                MinmaxNVtheoNam("asc", "Doanh thu");

                            }
                        }
                    }
                }
            }
            else
            {
                ReportDocument rp = new ReportDocument();
                String path = Path.GetFullPath(TKNV);
                rp.Load(path);

                crvNV.ReportSource = rp;
                crvNV.Refresh();
            }
        }
        private void btnHien_Click(object sender, EventArgs e)
        {
            if (test == true)
            {
                if (tbTuoitu.Text != "" && tbTuoiden.Text != "")
                {
                    if (Int32.Parse(tbTuoitu.Text) > Int32.Parse(tbTuoiden.Text))
                    {
                        MessageBox.Show("Nhập tuổi từ phải nhỏ hơn tuổi đến");
                    }
                    else
                    {
                        loctuoi("{@Tuoi}>= " + tbTuoitu.Text + " and {@Tuoi} <= " + tbTuoiden.Text);
                    }
                }
                else if (tbTuoitu.Text != "" && tbTuoiden.Text == "")
                {
                    loctuoi("{@Tuoi}>= " + tbTuoitu.Text);
                   

                }
                else if (tbTuoitu.Text == "" && tbTuoiden.Text != "")
                {
                    loctuoi(" {@Tuoi} <= " + tbTuoiden.Text);
                }
                else if (tbTuoitu.Text == "" && tbTuoiden.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập ít nhất 1 trong hai ô để có thể lọc");
                    // sapxep();
                }
            }
           // loc();

        }

        private void tbTuoitu_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbTuoitu.Text, out _))
            {
                if (tbTuoitu.Text == "")
                {
                    errorProvider1.Clear();
                    test = true;
                }
                else
                {
                    errorProvider1.SetError(tbTuoitu, "Tuổi từ phải là số");
                    test = false;
                }
            }
            else
            {
                //errorProvider1.SetError(tbTuoiden, "");
                errorProvider1.Clear();
                test = true;
            }
        }

        private void tbTuoiden_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbTuoiden.Text, out _))
            {
                if (tbTuoiden.Text == "")
                {
                    errorProvider1.Clear();
                    test = true;
                }
                else
                {
                    errorProvider1.SetError(tbTuoiden, "Tuổi đến phải là số");
                    test = false;
                }
            }
            else
            {
                //errorProvider1.SetError(tbTuoiden, "");
                errorProvider1.Clear();
                test = true;
            }
        }

        private void cbLoaiSX_TextChanged(object sender, EventArgs e)
        {
            if (cbLoaiSX.Text != "")
            {
                rbTang.Enabled = true;
                rbGiam.Enabled = true;
                rbMax.Enabled = true;
                rbMin.Enabled = true;

                //gbTheo.Enabled = true;
            }
            else
            {
                rbTang.Enabled = false;
                rbGiam.Enabled = false;
                rbMax.Enabled = false;
                rbMin.Enabled = false;

                //gbTheo.Enabled = false;
            }
        }
    }
}
