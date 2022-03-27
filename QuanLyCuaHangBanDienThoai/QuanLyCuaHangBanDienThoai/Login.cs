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
    public partial class Login : Form
    {
        AccountDao accountDao = new AccountDao();

        int dem = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String username = tbTenDangNhap.Text;
            String password = tbMatKhau.Text;

            if (accountDao.login(username, password) == 0)
                errorProviderLogin.SetError(tbTenDangNhap, "Tên đăng nhập không tồn tại");
            else
                errorProviderLogin.SetError(tbTenDangNhap, "");

            if (accountDao.login(username, password) == 2)
            {
                errorProviderLogin.SetError(tbMatKhau, "Sai mật khẩu");
                tbMatKhau.Text = "";
                dem++;
            }
            else
                errorProviderLogin.SetError(tbMatKhau, "");

            if (dem > 3)
            {
                accountDao.changeStatus(tbTenDangNhap.Text, 0);
                MessageBox.Show("Tài khoản đã bị khóa , mời bạn liên hệ với admin để lấy lại mật khẩu");

                return;
            }

            if (accountDao.login(username, password) == 1)
            {
                new QuanLyCuaHangDienThoai().Show();
                this.Hide();
            }

            if (accountDao.login(username, password) == 3)
                MessageBox.Show("Tài khoản đã bị khóa , mời bạn liên hệ với admin để lấy lại mật khẩu");
        }

        private void tbTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            String username = tbTenDangNhap.Text;
            String password = tbMatKhau.Text;


            if (accountDao.login(username, password) == 0)
                errorProviderLogin.SetError(tbTenDangNhap, "Tên đăng nhập không tồn tại");
            else
                errorProviderLogin.SetError(tbTenDangNhap, "");
        }

        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.Show();
        }
    }
}
