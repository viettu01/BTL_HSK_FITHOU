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
    public partial class Thongke : Form
    {
        bool isChecked = false;
        String constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        String TKDT = @"..\..\CrytalReport\ThongkeDoanhThu.rpt";
        String SXTKDT = @"..\..\CrytalReport\SXTKDT.rpt";

        String TKĐT = @"..\..\CrytalReport\ThongkeĐT.rpt";
        String SXTKĐT = @"..\..\CrytalReport\SXTKĐT.rpt";
        String TKNV = @"..\..\CrytalReport\ThongkeNV.rpt";
        String SXTKNV = @"..\..\CrytalReport\SXTKNV.rpt";
        String TKKH = @"..\..\CrytalReport\ThongkeKH.rpt";
        String SXTKKH = @"..\..\CrytalReport\SXTKKH.rpt";
        public Thongke()
        {
            InitializeComponent();
        }
        //GIAO DIỆN


        private void rbNV_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbNV.Checked;
        }

        private void rbKH_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbKH.Checked;
        }

        private void rbĐT_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbĐT.Checked;
        }

        private void rbNV_Click(object sender, EventArgs e)
        {
            if (rbNV.Checked && !isChecked)
                rbNV.Checked = false;
            else
            {
                rbNV.Checked = true;
                isChecked = false;
            }
        }

        private void rbKH_Click(object sender, EventArgs e)
        {
            if (rbKH.Checked && !isChecked)
                rbKH.Checked = false;
            else
            {
                rbKH.Checked = true;
                isChecked = false;
            }
        }

        private void rbĐT_Click(object sender, EventArgs e)
        {
            if (rbĐT.Checked && !isChecked)
                rbĐT.Checked = false;
            else
            {
                rbĐT.Checked = true;
                isChecked = false;
            }
        }

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
        private void locnamthang(string lenh, string ten)
        {
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(ten);
            rp.Load(path);
            rp.RecordSelectionFormula = lenh;
            crvDT.ReportSource = rp;
            crvDT.Refresh();
        }
        private void Thongke_Load(object sender, EventArgs e)
        {
            loadYearCombox(cbNam);
            ReportDocument rp = new ReportDocument();
            String path = Path.GetFullPath(TKDT);
            rp.Load(path);

            crvDT.ReportSource = rp;
            crvDT.Refresh();

            cbNam.Text = "";
        }
        private void SXDT(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TKDT WHERE [Năm] like '%" + cbNam.Text + "%' and[Tháng]like'%" + cbThang.Text + "%'order by[" + loai + "] " + kieu, cnn))
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

        private void Minmax(string tenview, string nam, string kieu, string loai, string kieu2)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select top(1) * from " + tenview + " where [Năm] like '%" + nam + "%' group by[Năm],[Tháng],[SLĐT bán],[Doanh thu] order by " + kieu2 + "([" + loai + "]) " + kieu, cnn))
                {
                    MessageBox.Show("select top(1) * from " + tenview + " where [Năm] like '%" + nam + "%' group by[Năm],[Tháng],[SLĐT bán],[Doanh thu] order by " + kieu2 + "([" + loai + "]) " + kieu);
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
        private void SXNV(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TKNV WHERE [Năm] like '%" + cbNam.Text + "%' and[Tháng]like'%" + cbThang.Text + "%'order by[" + loai + "] " + kieu, cnn))
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
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }
        }
        private void SXKH(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TKKH WHERE [Năm] like '%" + cbNam.Text + "%' and[Tháng]like'%" + cbThang.Text + "%'order by[" + loai + "] " + kieu, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet3 ds = new DataSet3();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKKH);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }
        }
        private void SXĐT(string kieu, string loai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TKĐT WHERE [Năm] like '%" + cbNam.Text + "%' and[Tháng]like'%" + cbThang.Text + "%'order by[" + loai + "] " + kieu, cnn))
                {

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataSet4 ds = new DataSet4();
                        DataTable dt = new DataTable();
                        ad.Fill(ds);
                        //ThongKeDienThoai rpt = new ThongKeDienThoai();
                        ReportDocument rpt = new ReportDocument();
                        String path = Path.GetFullPath(SXTKĐT);
                        rpt.Load(path);
                        rpt.SetDataSource(ds.Tables[1]);
                        crvDT.ReportSource = rpt;
                        crvDT.Refresh();
                    }
                }
            }
        }

        private void loc()
        {
            if (cbNam.Text != "")
            {
                if (cbThang.Text != "")
                {
                    if (cbLoaiSX.Text == "")
                    {
                        if (!rbTang.Checked && !rbGiam.Checked)
                        {
                            //locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, ten1);
                            if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, TKDT);
                            }
                            else if (rbNV.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, TKNV);
                            }
                            else if (rbKH.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, TKKH);

                            }
                            else if (rbĐT.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text + " and {@Thang}=" + cbThang.Text, TKĐT);
                            }
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
                        if (cbLoaiSX.Text == "Số lượng")
                        {

                            if (rbGiam.Checked)
                            {
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("desc", "SLĐT bán");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("desc", "SLĐT bán");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("desc", "SLĐT mua");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("desc", "SL bán");
                                }

                            }

                            else if (rbTang.Checked)
                            {

                                // sapxep("asc", ten2, loai1, i, tenv);
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("asc", "SLĐT bán");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("asc", "SLĐT bán");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("asc", "SLĐT mua");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("asc", "SL bán");
                                }
                            }
                        }
                        if (cbLoaiSX.Text == "Doanh thu")

                        {

                            if (rbTang.Checked)
                            {

                                // sapxep("asc", ten2, loai2, i, tenv);
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("asc", "Doanh thu");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("asc", "Doanh thu");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("asc", "Tổng tiền");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("asc", "Doanh thu");
                                }
                            }
                            else if (rbGiam.Checked)
                            {


                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("desc", "Doanh thu");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("desc", "Doanh thu");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("desc", "Tổng tiền");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("desc", "Doanh thu");
                                }
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
                            //locnamthang("{@Nam}=" + cbNam.Text, ten1);
                            if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text, TKDT);
                            }
                            else if (rbNV.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text, TKNV);
                            }
                            else if (rbKH.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text, TKKH);

                            }
                            else if (rbĐT.Checked)
                            {
                                locnamthang("{@Nam}=" + cbNam.Text, TKDT);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mời bạn nhập loại sắp xếp");
                        }




                    }
                    else
                    {

                        if (!rbTang.Checked && !rbGiam.Checked)
                        {
                            MessageBox.Show("Mời bạn chọn kiểu sắp xếp");

                        }
                        if (cbLoaiSX.Text == "Số lượng")
                        {

                            if (rbGiam.Checked)
                            {
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("desc", "SLĐT bán");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("desc", "SLĐT bán");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("desc", "SLĐT mua");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("desc", "SL bán");
                                }

                            }

                            else if (rbTang.Checked)
                            {

                                // sapxep("asc", ten2, loai1, i, tenv);
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("asc", "SLĐT bán");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("asc", "SLĐT bán");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("asc", "SLĐT mua");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("asc", "SL bán");
                                }
                            }
                        }
                        if (cbLoaiSX.Text == "Doanh thu")

                        {

                            if (rbTang.Checked)
                            {

                                // sapxep("asc", ten2, loai2, i, tenv);
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("asc", "Doanh thu");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("asc", "Doanh thu");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("asc", "Tổng tiền");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("asc", "Doanh thu");
                                }
                            }
                            else if (rbGiam.Checked)
                            {

                                //sapxep("desc", ten2, loai2, i, tenv);
                                if (!rbNV.Checked && !rbKH.Checked && !rbĐT.Checked)
                                {
                                    SXDT("desc", "Doanh thu");
                                }
                                else if (rbNV.Checked)
                                {
                                    SXNV("desc", "Doanh thu");
                                }
                                else if (rbKH.Checked)
                                {
                                    SXKH("desc", "Tổng tiền");

                                }
                                else if (rbĐT.Checked)
                                {
                                    SXĐT("desc", "Doanh thu");
                                }
                                MessageBox.Show("ok");

                            }
                        }
                    }

                }


            }
            else
            {
                ReportDocument rp = new ReportDocument();
                String path = Path.GetFullPath(TKDT);
                rp.Load(path);

                crvDT.ReportSource = rp;
                crvDT.Refresh();
            }
        }
        private void btnHien_Click(object sender, EventArgs e)
        {
            loc();
            //SXĐT("desc", "SL bán");
            /*  if(rbMin.Checked)
               {
                   Minmax("TKDT", cbNam.Text, "asc", cbLoaiSX.Text, "MIN");
               }
              else if (rbMax.Checked)
               {
                   Minmax("TKDT", cbNam.Text, "desc","SLĐT bán", "MAX");
               }*/
        }

        private void cbLoaiSX_Validating(object sender, CancelEventArgs e)
        {
            if (cbLoaiSX.Text == "")
            {
                rbGiam.Checked = false;
                rbTang.Checked = false;

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

        private void rbTang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!rbTang.Checked && !rbGiam.Checked)
            {
                gbTheo.Enabled = false;
            }
            else
            {
                gbTheo.Enabled = true;
            }
        }

        private void rbGiam_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!rbTang.Checked && !rbGiam.Checked)
            {
                gbTheo.Enabled = false;
            }
            else
            {
                gbTheo.Enabled = true;
            }
        }

        private void cbNam_TextChanged(object sender, EventArgs e)
        {
            if (cbNam.Text == "")
            {
                cbThang.Enabled = false;
            }
            else
            {
                cbThang.Enabled = true;
            }
        }
        //chạy code

    }
}
