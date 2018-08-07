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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            btnDangKiTK.Enabled = false;
            btnQuanLyMH.Enabled = false;
            btnQuanLyNCC.Enabled = false;
            btnDangXuat.Enabled = false;
            btnQuanLyKH.Enabled = false;
        }
     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThamSo.Quyen = 0;
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void btnDangNhapTK_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (ThamSo.Quyen == 1)
                {
                    btnDangKiTK.Enabled = true;
                    btnQuanLyMH.Enabled = true;
                    btnQuanLyNCC.Enabled = true;
                    btnQuanLyKH.Enabled = true;
                }
                else if (ThamSo.Quyen == 2)
                {
                    btnQuanLyMH.Enabled = true;
                    btnQuanLyNCC.Enabled = true;
                    btnQuanLyKH.Enabled = true;
                }
                btnDangNhapTK.Enabled = false;
                btnDangXuat.Enabled = true;
            }
        }

        private void btnDangKiTK_Click(object sender, EventArgs e)
        {
            frmDangKi frm = new frmDangKi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLyMH_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLyNCC_Click(object sender, EventArgs e)
        {
            frmNhaCC frm = new frmNhaCC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            frmLienHe frm = new frmLienHe();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
