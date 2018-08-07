using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        DALQuanLyBanHang dal = new DALQuanLyBanHang();
        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Nhập Tài Khoản")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Nhập Tài Khoản";
                tb.ForeColor = Color.LightGray;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                if (txtTaiKhoan.Text.Trim() == "")
                {
                    errDangKi.SetError(txtTaiKhoan, "Tên đăng nhập không được để trống!");
                }
                else if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
                {
                    errDangKi.SetError(txtNhapLaiMatKhau, "Nhập lại mật khẩu không chính xác!");
                }
                else if (cboQuyen.SelectedIndex < 0)
                    {
                        errDangKi.SetError(cboQuyen, "Quyền không được để trống!");
                    }
                else
                {
                    string sql = "INSERT INTO tblTaiKhoan(TaiKhoan, MatKhau, Quyen)";
                    sql += " VALUES('" + txtTaiKhoan.Text + "','" + txtMatKhau.Text + "','" + cboQuyen.SelectedItem.ToString() + "')";
                    dal.DoExecute(sql);
                    MessageBox.Show("Đăng kí tài khoản thành công tài khoản " + txtTaiKhoan.Text + "!");
                }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            txtTaiKhoan.GotFocus += new EventHandler(this.TextGotFocus);
            txtTaiKhoan.LostFocus += new EventHandler(this.TextLostFocus);
        }
        

    }
}
