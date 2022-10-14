using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class frmDangNhap : Form
    {
        const string taiKhoan = "nhon";
        const string matKhau = "1";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == taiKhoan && txtMatKhau.Text == matKhau)
            {
                frmBanVe frm1 = new frmBanVe();
                frm1.ShowDialog();
            }    
            else
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}
