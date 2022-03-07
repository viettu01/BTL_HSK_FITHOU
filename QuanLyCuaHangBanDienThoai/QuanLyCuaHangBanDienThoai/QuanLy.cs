﻿using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class QuanLy : Form
    {
        PhoneDao phoneDao = new PhoneDao();
        ProducerDao producerDao = new ProducerDao();
        AccountDao accountDao = new AccountDao();
        CustomerDao customerDao = new CustomerDao();
        BillInDao billInDao = new BillInDao();
        int idProducer, idAccount, idCustomer;
        String namePhone;

        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            //Quản lý điện thoại
            producerDao.loadDataProducerCombox(cbHang);
            loadDataToDataGridView(dtgvDienThoai, phoneDao.findAll());
            cbHang.Text = "";

            //Quản lý hãng sản xuất
            loadDataToDataGridView(dtgvHSX, producerDao.findAll());

            //Quản lý tài khoản
            loadDataToDataGridView(dtgvNV, accountDao.findAll());

            //Quản lý khách hàng
            loadDataToDataGridView(dtgvKH, customerDao.findAll());

            //Quản lý hóa đơn nhập
            loadDataToDataGridView(dtgvHDN, billInDao.findAll());
            loadDataIdPhoneCombox(cbMaDT);
        }

        #region Quản lý điện thoại
        private void btnThemDT_Click(object sender, EventArgs e)
        {
            mtbMaDT.Enabled = true;
            mtbTenDT.Enabled = true;
            cbHang.Enabled = true;
            mtbGia.Enabled = true;
            mtbMau.Enabled = true;
            mtbRom.Enabled = true;
            mtbRam.Enabled = true;
            mtbTGBH.Enabled = true;

            btnThemDT.Enabled = false;
            btnLuuDT.Enabled = true;
            btnLamMoiDT.Enabled = true;

            btnTimKiemDT.Visible = false;
            btnSuaDT.Visible = false;
            btnXoaDT.Visible = false;

            lbGiaMin.Visible = false;
            lbGiaMax.Visible = false;
            mtbGiaMax.Visible = false;

            btnLuuDT.Text = "Lưu";
        }

        private void btnSuaDT_Click(object sender, EventArgs e)
        {
            if (mtbMaDT.Text == "")
            {
                mtbMaDT.Enabled = true;
            }
            else
            {
                mtbMaDT.Enabled = false;
            }

            mtbTenDT.Enabled = true;
            cbHang.Enabled = true;
            mtbGia.Enabled = true;
            mtbMau.Enabled = true;
            mtbRom.Enabled = true;
            mtbRam.Enabled = true;
            mtbTGBH.Enabled = true;

            btnSuaDT.Enabled = false;
            btnLuuDT.Enabled = true;
            btnLamMoiDT.Enabled = true;

            btnTimKiemDT.Visible = false;
            btnThemDT.Visible = false;
            btnXoaDT.Visible = false;

            lbGiaMin.Visible = false;
            lbGiaMax.Visible = false;
            mtbGiaMax.Visible = false;

            btnLuuDT.Text = "Lưu";
        }

        private void btnXoaDT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (phoneDao.deleteById(mtbMaDT.Text))
                {
                    MessageBox.Show("Xóa điện thoại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoiDT_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa điện thoại thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemDT_Click(object sender, EventArgs e)
        {
            mtbMaDT.Enabled = true;
            mtbTenDT.Enabled = true;
            cbHang.Enabled = true;
            mtbGia.Enabled = true;
            mtbMau.Enabled = true;
            mtbRom.Enabled = true;
            mtbRam.Enabled = true;
            mtbTGBH.Enabled = true;

            btnTimKiemDT.Enabled = false;
            btnLuuDT.Enabled = true;
            btnLamMoiDT.Enabled = true;

            btnThemDT.Visible = false;
            btnSuaDT.Visible = false;
            btnXoaDT.Visible = false;

            lbGiaMin.Visible = true;
            lbGiaMax.Visible = true;
            mtbGiaMax.Visible = true;

            btnLuuDT.Text = "Tìm";
        }

        private void btnLamMoiDT_Click(object sender, EventArgs e)
        {
            mtbMaDT.Text = "";
            mtbTenDT.Text = "";
            mtbMau.Text = "";
            mtbRom.Text = "";
            mtbRam.Text = "";
            mtbTGBH.Text = "";
            cbHang.Text = "";
            mtbGia.Text = "";

            mtbMaDT.Enabled = false;
            mtbTenDT.Enabled = false;
            cbHang.Enabled = false;
            mtbGia.Enabled = false;
            mtbMau.Enabled = false;
            mtbRom.Enabled = false;
            mtbRam.Enabled = false;
            mtbTGBH.Enabled = false;

            btnTimKiemDT.Visible = true;
            btnThemDT.Visible = true;
            btnSuaDT.Visible = true;
            btnXoaDT.Visible = true;

            lbGiaMin.Visible = false;
            lbGiaMax.Visible = false;
            mtbGiaMax.Visible = false;

            btnTimKiemDT.Enabled = true;
            btnThemDT.Enabled = true;
            btnSuaDT.Enabled = true;
            btnXoaDT.Enabled = false;
            btnLuuDT.Enabled = false;
            btnLamMoiDT.Enabled = false;

            btnLuuDT.Text = "Lưu";

            errorProvider.Clear();
            QuanLy_Load(sender, e);
        }

        private void btnLuuDT_Click(object sender, EventArgs e)
        {
            String id = mtbMaDT.Text;
            String name = mtbTenDT.Text;
            String color = mtbMau.Text;
            String rom = mtbRom.Text;
            String ram = mtbRam.Text;
            String timeBH = mtbTGBH.Text;
            if (btnTimKiemDT.Visible == true)
            {
                if (id == "" && name == "" && mtbGia.Text == "" && color == "" && rom == "" && ram == "" && timeBH == "" && cbHang.Text == "" && mtbGiaMax.Text == "")
                    MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    loadDataToDataGridView(dtgvDienThoai, phoneDao.search(id, name, cbHang.Text, mtbGia.Text, mtbGiaMax.Text, color, rom, ram, timeBH));
            }
            else
            {
                if (id == "" || name == "" || mtbGia.Text == "" || color == "" || rom == "" || ram == "" || timeBH == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!double.TryParse(mtbGia.Text, out _))
                    MessageBox.Show("Giá phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (double.Parse(mtbGia.Text) <= 0)
                    MessageBox.Show("Giá sản phẩm phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int idProducer = int.Parse(cbHang.SelectedValue.ToString());
                    double price = double.Parse(mtbGia.Text);
                    if (btnThemDT.Visible == true)
                    {
                        if (!phoneDao.checkExistsId(mtbMaDT.Text))
                        {
                            MessageBox.Show("Mã điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (phoneDao.insert(id, name, idProducer, price, color, rom, ram, timeBH))
                            {
                                MessageBox.Show("Thêm điện thoại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnLamMoiDT_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thêm điện thoại thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (btnSuaDT.Visible == true)
                    {
                        if (phoneDao.update(id, name, idProducer, price, color, rom, ram, timeBH))
                        {
                            MessageBox.Show("Sửa điện thoại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLamMoiDT_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa điện thoại thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dtgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbMaDT.Text = dtgvDienThoai.CurrentRow.Cells[0].Value.ToString();
            mtbTenDT.Text = dtgvDienThoai.CurrentRow.Cells[1].Value.ToString();
            cbHang.Text = dtgvDienThoai.CurrentRow.Cells[2].Value.ToString();
            mtbGia.Text = dtgvDienThoai.CurrentRow.Cells[4].Value.ToString();
            mtbMau.Text = dtgvDienThoai.CurrentRow.Cells[5].Value.ToString();
            mtbRom.Text = dtgvDienThoai.CurrentRow.Cells[6].Value.ToString();
            mtbRam.Text = dtgvDienThoai.CurrentRow.Cells[7].Value.ToString();
            mtbTGBH.Text = dtgvDienThoai.CurrentRow.Cells[8].Value.ToString();

            if (btnSuaDT.Enabled == false)
                mtbMaDT.Enabled = false;

            btnXoaDT.Enabled = true;
            btnLamMoiDT.Enabled = true;
        }

        private void mtbMaDT_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbMaDT.Text == "")
                    errorProvider.SetError(mtbMaDT, "Mã điện thoại không được để trống");
                else if (!phoneDao.checkExistsId(mtbMaDT.Text))
                    errorProvider.SetError(mtbMaDT, "Mã điện thoại đã tồn tại");
                else
                    errorProvider.SetError(mtbMaDT, "");
            }
        }

        private void mtbTenDT_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbTenDT.Text == "")
                    errorProvider.SetError(mtbTenDT, "Tên điện thoại không được để trống");
                else
                    errorProvider.SetError(mtbTenDT, "");
            }
        }

        private void cbHang_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (cbHang.Text == "")
                    errorProvider.SetError(cbHang, "Hãng điện thoại không được để trống");
                else
                    errorProvider.SetError(cbHang, "");
            }
        }

        private void mtbGia_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbGia.Text == "")
                    errorProvider.SetError(mtbGia, "Giá điện thoại không được để trống");
                else if (!double.TryParse(mtbGia.Text, out _))
                    errorProvider.SetError(mtbGia, "Giá phải là số");
                else if (double.Parse(mtbGia.Text) <= 0)
                    errorProvider.SetError(mtbGia, "Giá sản phẩm phải lớn hơn 0");
                else
                    errorProvider.SetError(mtbGia, "");
            }
        }

        private void mtbMau_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbMau.Text == "")
                    errorProvider.SetError(mtbMau, "Màu không được để trống");
                else
                    errorProvider.SetError(mtbMau, "");
            }
        }

        private void mtbRom_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbRom.Text == "")
                    errorProvider.SetError(mtbRom, "Rom không được để trống");
                else
                    errorProvider.SetError(mtbRom, "");
            }
        }

        private void mtbRam_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbRam.Text == "")
                    errorProvider.SetError(mtbRam, "Ram không được để trống");
                else
                    errorProvider.SetError(mtbRam, "");
            }
        }

        private void mtbTGBH_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemDT.Visible != true)
            {
                if (mtbTGBH.Text == "")
                    errorProvider.SetError(mtbTGBH, "Thời gian bảo hành không được để trống");
                else
                    errorProvider.SetError(mtbTGBH, "");
            }
        }
        #endregion

        #region Quản lý hãng sản xuất
        private void btnThemHSX_Click(object sender, EventArgs e)
        {
            mtbTenHSX.Enabled = true;

            btnThemHSX.Enabled = false;
            btnLuuHSX.Enabled = true;
            btnLamMoiHSX.Enabled = true;

            btnTimKiemHSX.Visible = false;
            btnSuaHSX.Visible = false;
            btnXoaHSX.Visible = false;

            btnLuuHSX.Text = "Lưu";
        }

        private void btnSuaHSX_Click(object sender, EventArgs e)
        {
            mtbTenHSX.Enabled = true;

            btnSuaHSX.Enabled = false;
            btnLuuHSX.Enabled = true;
            btnLamMoiHSX.Enabled = true;

            btnTimKiemHSX.Visible = false;
            btnThemHSX.Visible = false;
            btnXoaHSX.Visible = false;

            btnLuuHSX.Text = "Lưu";
        }

        private void btnXoaHSX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (producerDao.deleteByName(mtbTenHSX.Text))
                {
                    MessageBox.Show("Xóa hãng sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoiHSX_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa hãng sản xuất thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemHSX_Click(object sender, EventArgs e)
        {
            mtbTenHSX.Enabled = true;

            btnTimKiemHSX.Enabled = false;
            btnLuuHSX.Enabled = true;
            btnLamMoiHSX.Enabled = true;

            btnThemHSX.Visible = false;
            btnSuaHSX.Visible = false;
            btnXoaHSX.Visible = false;

            btnLuuHSX.Text = "Tìm";
        }

        private void btnLamMoiHSX_Click(object sender, EventArgs e)
        {
            mtbTenHSX.Text = "";

            mtbTenHSX.Enabled = false;

            btnTimKiemHSX.Visible = true;
            btnThemHSX.Visible = true;
            btnSuaHSX.Visible = true;
            btnXoaHSX.Visible = true;

            btnTimKiemHSX.Enabled = true;
            btnThemHSX.Enabled = true;
            btnSuaHSX.Enabled = false;
            btnXoaHSX.Enabled = false;
            btnLuuHSX.Enabled = false;
            btnLamMoiHSX.Enabled = false;

            btnLuuHSX.Text = "Lưu";

            errorProvider.Clear();
            QuanLy_Load(sender, e);
        }

        private void btnLuuHSX_Click(object sender, EventArgs e)
        {
            String name = mtbTenHSX.Text;
            if (btnTimKiemHSX.Visible == true)
            {
                if (name == "")
                    MessageBox.Show("Bạn cần nhập tên hãng cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    loadDataToDataGridView(dtgvHSX, producerDao.search(name));
            }
            else
            {
                if (name == "")
                {
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (btnThemHSX.Visible == true)
                    {
                        if (!producerDao.checkExistsName(name))
                        {
                            MessageBox.Show("Hãng sản xuất đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (producerDao.insert(name))
                            {
                                MessageBox.Show("Thêm hãng sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnLamMoiHSX_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thêm hãng sản xuất thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (btnSuaHSX.Visible == true)
                    {
                        if (producerDao.update(idProducer, name))
                        {
                            MessageBox.Show("Sửa hãng sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLamMoiHSX_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa hãng sản xuất thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dtgvHSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducer = int.Parse(dtgvHSX.CurrentRow.Cells[0].Value.ToString());
            mtbTenHSX.Text = dtgvHSX.CurrentRow.Cells[1].Value.ToString();

            btnXoaHSX.Enabled = true;
            btnSuaHSX.Enabled = true;
            btnLamMoiHSX.Enabled = true;
        }

        private void mtbTenHSX_Validating(object sender, CancelEventArgs e)
        {
            if (btnTimKiemHSX.Visible != true)
            {
                if (mtbTenHSX.Text == "")
                    errorProvider.SetError(mtbTenHSX, "Không được để trống");
                else if (!producerDao.checkExistsName(mtbTenHSX.Text))
                    errorProvider.SetError(mtbTenHSX, "Hãng sản xuất đã tồn tại");
                else
                    errorProvider.SetError(mtbTenHSX, "");
            }
        }
        #endregion

        #region Quản lý tài khoản
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            mtbHoTenNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
            mtbSDTNV.Enabled = true;
            mtbTenDN.Enabled = true;
            mtbMK.Enabled = true;
            cbQuyen.Enabled = true;

            btnThemNV.Enabled = false;
            btnLuuNV.Enabled = true;
            btnLamMoiNV.Enabled = true;

            btnTimKiemNV.Visible = false;
            btnSuaNV.Visible = false;
            btnXoaNV.Visible = false;

            btnLuuNV.Text = "Lưu";
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            mtbHoTenNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
            mtbSDTNV.Enabled = true;
            mtbTenDN.Enabled = true;
            mtbMK.Enabled = true;
            cbQuyen.Enabled = true;

            btnSuaNV.Enabled = false;
            btnLuuNV.Enabled = true;
            btnLamMoiNV.Enabled = true;

            btnTimKiemNV.Visible = false;
            btnThemNV.Visible = false;
            btnXoaNV.Visible = false;

            btnLuuDT.Text = "Lưu";
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (accountDao.deleteById(idAccount))
                {
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoiNV_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            mtbHoTenNV.Enabled = true;
            mtbSDTNV.Enabled = true;
            mtbTenDN.Enabled = true;
            cbQuyen.Enabled = true;

            btnTimKiemNV.Enabled = false;
            btnLuuNV.Enabled = true;
            btnLamMoiNV.Enabled = true;

            btnThemNV.Visible = false;
            btnSuaNV.Visible = false;
            btnXoaNV.Visible = false;

            btnLuuNV.Text = "Tìm";
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            mtbHoTenNV.Text = "";
            mtbSDTNV.Text = "";
            dtpNgaySinhNV.CustomFormat = " ";
            mtbTenDN.Text = "";
            mtbMK.Text = "";
            cbQuyen.Text = "";

            mtbHoTenNV.Enabled = false;
            dtpNgaySinhNV.Enabled = false;
            mtbSDTNV.Enabled = false;
            mtbTenDN.Enabled = false;
            mtbMK.Enabled = false;
            cbQuyen.Enabled = false;

            btnTimKiemNV.Visible = true;
            btnThemNV.Visible = true;
            btnSuaNV.Visible = true;
            btnXoaNV.Visible = true;

            btnTimKiemNV.Enabled = true;
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = true;
            btnXoaNV.Enabled = false;
            btnLuuNV.Enabled = false;
            btnLamMoiNV.Enabled = false;

            btnLuuNV.Text = "Lưu";

            errorProvider.Clear();
            QuanLy_Load(sender, e);
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            String fullName = mtbHoTenNV.Text;
            String birthday = dtpNgaySinhNV.Value.Date.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"));
            String phone = mtbSDTNV.Text;
            String username = mtbTenDN.Text;
            String password = mtbMK.Text;
            String role = cbQuyen.Text;
            if (btnTimKiemNV.Visible == true)
            {
                if (fullName == "" && phone == "" && username == "" && password == "" && role == "" && dtpNgaySinhNV.Text == " ")
                    MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    //MessageBox.Show(DateTime.Parse(dtpNgaySinhNV.Text).ToString("dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-US")));
                    loadDataToDataGridView(dtgvNV, accountDao.search(role, username, fullName, phone));
                }
            }
            else
            {
                if (fullName == "" || phone == "" || username == "" || password == "" || role == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!double.TryParse(phone, out _))
                    MessageBox.Show("Số điện thoại phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (phone.Length < 10 || phone.Length > 10)
                    MessageBox.Show("Số điện thoại phải đủ 12 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (btnThemNV.Visible == true)
                    {
                        if (!accountDao.checkExistsPhone(phone))
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (!accountDao.checkExistsUsername(username))
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (accountDao.insert(role, username, password, fullName, phone, DateTime.Parse(birthday)))
                            {
                                MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnLamMoiNV_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (btnSuaNV.Visible == true)
                    {
                        if (accountDao.update(idAccount, role, username, password, fullName, phone, DateTime.Parse(birthday)))
                        {
                            MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLamMoiNV_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Sửa tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAccount = int.Parse(dtgvNV.CurrentRow.Cells[0].Value.ToString());
            cbQuyen.Text = dtgvNV.CurrentRow.Cells[1].Value.ToString();
            mtbTenDN.Text = dtgvNV.CurrentRow.Cells[2].Value.ToString();
            mtbMK.Text = dtgvNV.CurrentRow.Cells[3].Value.ToString();
            mtbHoTenNV.Text = dtgvNV.CurrentRow.Cells[4].Value.ToString();
            mtbSDTNV.Text = dtgvNV.CurrentRow.Cells[5].Value.ToString();
            if (dtgvNV.CurrentRow.Cells[6].Value.ToString() != "")
                dtpNgaySinhNV.Value = DateTime.Parse(dtgvNV.CurrentRow.Cells[6].Value.ToString());
            else
                dtpNgaySinhNV.CustomFormat = " ";

            btnXoaNV.Enabled = true;
            btnSuaNV.Enabled = true;
            btnLamMoiNV.Enabled = true;
        }

        private void dtpNgaySinhNV_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinhNV.CustomFormat = "dd/MM/yyyy";
        }
        #endregion

        #region Quản lý khách hàng
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            mtbHoTenKH.Enabled = true;
            mtbSDTKH.Enabled = true;

            btnThemKH.Enabled = false;
            btnLuuKH.Enabled = true;
            btnLamMoiKH.Enabled = true;

            btnTimKiemKH.Visible = false;
            btnSuaKH.Visible = false;
            btnXoaKH.Visible = false;

            btnLuuKH.Text = "Lưu";
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            mtbHoTenKH.Enabled = true;
            mtbSDTKH.Enabled = true;

            btnSuaKH.Enabled = false;
            btnLuuKH.Enabled = true;
            btnLamMoiKH.Enabled = true;

            btnTimKiemKH.Visible = false;
            btnThemKH.Visible = false;
            btnXoaKH.Visible = false;

            btnLuuKH.Text = "Lưu";
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (customerDao.deleteById(idCustomer))
                {
                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoiKH_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            mtbHoTenKH.Enabled = true;
            mtbSDTKH.Enabled = true;

            btnTimKiemKH.Enabled = false;
            btnLuuKH.Enabled = true;
            btnLamMoiKH.Enabled = true;

            btnThemKH.Visible = false;
            btnSuaKH.Visible = false;
            btnXoaKH.Visible = false;

            btnLuuKH.Text = "Tìm";
        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            mtbHoTenKH.Text = "";
            mtbSDTKH.Text = "";

            mtbHoTenKH.Enabled = false;
            mtbSDTKH.Enabled = false;

            btnTimKiemKH.Visible = true;
            btnThemKH.Visible = true;
            btnSuaKH.Visible = true;
            btnXoaKH.Visible = true;

            btnTimKiemKH.Enabled = true;
            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnXoaKH.Enabled = false;
            btnLuuKH.Enabled = false;
            btnLamMoiKH.Enabled = false;

            btnLuuKH.Text = "Lưu";

            errorProvider.Clear();
            QuanLy_Load(sender, e);
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            String name = mtbHoTenKH.Text;
            String phone = mtbSDTKH.Text;
            if (btnTimKiemKH.Visible == true)
            {
                if (name == "" && phone == "")
                    MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    loadDataToDataGridView(dtgvKH, customerDao.search(name, phone));
            }
            else
            {
                if (name == "" || phone == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!double.TryParse(phone, out _))
                    MessageBox.Show("Số điện thoại phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (phone.Length < 10 || phone.Length > 10)
                    MessageBox.Show("Số điện thoại phải đủ 12 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (btnThemKH.Visible == true)
                    {
                        if (!customerDao.checkExistsPhone(phone))
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (customerDao.insert(name, phone))
                            {
                                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnLamMoiNV_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Thêm khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (btnSuaKH.Visible == true)
                    {
                        if (customerDao.update(idCustomer, name , phone))
                        {
                            MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLamMoiNV_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Sửa khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCustomer = int.Parse(dtgvKH.CurrentRow.Cells[0].Value.ToString());
            mtbHoTenKH.Text = dtgvKH.CurrentRow.Cells[1].Value.ToString();
            mtbSDTKH.Text = dtgvKH.CurrentRow.Cells[2].Value.ToString();

            btnXoaKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnLamMoiKH.Enabled = true;
        }
        #endregion

        #region Quản lý hóa đơn nhập
        private void cbMaDT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = phoneDao.search(cbMaDT.Text, "", "", "", "", "", "", "", "");
            DataView v = new DataView(dt);

            foreach (DataRowView r in v)
            {
                namePhone = r["Tên ĐT"].ToString();
                tbDacDiem.Text = namePhone + "/" + r["Màu"] + "/" + r["Rom"] + "/" + r["Ram"];
                tbGiaNhap.Text = r["Giá"].ToString();
            }
        }

        private void btnThemDTC_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtgvDSDTC.Rows.Count.ToString());

            if (dtgvDSDTC.Rows.Count != 1)
            {
                for (int rows = 0; rows < dtgvDSDTC.Rows.Count-1; rows++)
                {
                    if (dtgvDSDTC.Rows[rows].Cells[0].Value.ToString().Equals(cbMaDT.Text))
                    {
                        int sl = int.Parse(dtgvDSDTC.Rows[rows].Cells[2].Value.ToString());
                        sl = sl + int.Parse(nudSoLuong.Value.ToString());
                        dtgvDSDTC.Rows[rows].Cells[2].Value = sl.ToString();
                        return;
                    }
                }
            }
            String[] row = new string[] { cbMaDT.Text, namePhone, nudSoLuong.Value.ToString(), tbGiaNhap.Text };
            dtgvDSDTC.Rows.Add(row);
            for (int i = 0; i < dtgvDSDTC.Rows.Count-1; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dtgvDSDTC[4, i] = linkCell;
                dtgvDSDTC[4, i].Value = "Delete";
            }
            //dtgvDSDTC.Rows[e.RowIndex].Cells[4].Value = "Delete";
        }

        private void dtgvDSDTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string Task = dtgvDSDTC.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (Task == "Delete")
                {
                    if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        dtgvDSDTC.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            billInDao.insertBillIn(Program.accountId);

            for (int rows = 0; rows < dtgvDSDTC.Rows.Count - 1; rows++)
            {
                String phoneId = dtgvDSDTC.Rows[rows].Cells[0].Value.ToString();
                int quantity = int.Parse(dtgvDSDTC.Rows[rows].Cells[2].Value.ToString());
                double price = double.Parse(dtgvDSDTC.Rows[rows].Cells[3].Value.ToString());

                billInDao.insertDetailBillIn(billInDao.getIdMax(), phoneId, price, quantity);
            }

            QuanLy_Load(sender, e);
        }
    
        #endregion

        //Load data
        private void loadDataToDataGridView(DataGridView dtgv, DataTable dt)
        {
            dtgv.DataSource = dt;
            dtgv.AutoResizeColumns();
        }

        public void loadDataIdPhoneCombox(ComboBox cb)
        {
            DataTable dt = phoneDao.findAll();
            DataView v = new DataView(dt);
            v.Sort = "Mã ĐT";

            cb.DataSource = v;
            cb.DisplayMember = "Mã ĐT";
            cb.ValueMember = "Mã ĐT";
        }
    }
}
