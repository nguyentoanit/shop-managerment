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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        DALQuanLyBanHang dal = new DALQuanLyBanHang();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                errDangNhap.SetError(txtTaiKhoan, "Tên đăng nhập không được để trống!");
            }
            else if (txtMatKhau.Text.Trim() == "")
            {
                errDangNhap.SetError(txtMatKhau, "Mật khẩu không được để trống!");
            }
            else
            {
                DALQuanLyBanHang dal = new DALQuanLyBanHang();
                string sql = "Select Quyen from tblTaiKhoan Where TaiKhoan ='" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
                DataSet ds = new DataSet();
                ds = dal.GetData(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "Admin")
                    {
                        ThamSo.Quyen = 1;
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "Manager")
                    {
                        ThamSo.Quyen = 2;
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "Guest")
                    {
                        ThamSo.Quyen = 3;
                    }
                    btnDangNhap.DialogResult = DialogResult.OK;
                }
                else
                {
                    errDangNhap.SetError(txtMatKhau, "Mật khẩu không chính xác!");
                }
            }
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmDangKi frm = new frmDangKi();
            frm.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            txtTaiKhoan.GotFocus += new EventHandler(this.TextGotFocus);
            txtTaiKhoan.LostFocus += new EventHandler(this.TextLostFocus);
        }
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
    }
}
