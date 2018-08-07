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
    public partial class frmKhachHang : Form
    {
        DALQuanLyBanHang dal;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void EnableControls(bool isShow)
        {
            if (ThamSo.Quyen == 2)
            {
                btnThemKH.Enabled = !isShow;
                btnXoaKH.Enabled = !isShow;
            }
            else
            {
                btnXoaKH.Enabled = isShow;
                btnThemKH.Enabled = isShow;
            }
            btnSuaKH.Enabled = isShow;
            btnTimKiemKH.Enabled = isShow;
        }
        private void Load1()
        {
            string sql = "select TaiKhoan from tblTaiKhoan";
            DALQuanLyBanHang dal = new DALQuanLyBanHang();
            DataSet ds = new DataSet();
            ds = dal.GetData(sql);
            cboTaiKhoan.DataSource = ds.Tables[0];
            cboTaiKhoan.DisplayMember = "TaiKhoan";
            cboTaiKhoan.ValueMember = "TaiKhoan";

        }
        private void Hide(bool off)
        {
            lblMaKH.Visible = off;
            lblTenKH.Visible = off;
            lblNgaySinh.Visible = off;
            lblDiaChi.Visible = off;
            lblDienThoai.Visible = off;
            lblTaiKhoan.Visible = off;

            txtMaKH.Visible = off;
            txtTenKH.Visible = off;
            dtpNgaySinh.Visible = off;
            txtDiaChi.Visible = off;
            txtDienThoai.Visible = off;
            cboTaiKhoan.Visible = off;
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtTimKiemKH.Clear();

            txtMaKH.Enabled = off;
            cboTimKiemKH.Visible = !off;
            txtTimKiemKH.Visible = !off;

        }
        private void ShowData(String sql)
        {
            dtgKhachHang.DataSource = dal.GetData(sql).Tables[0];
            dtgKhachHang.Refresh();
        }
        private void check()
        {
            if (txtMaKH.Text.Trim() == "")
            {
                errKhachHang.SetError(txtMaKH, "Mã Khách Hàng không được để trống!");
            }

            if (txtTenKH.Text.Trim() == "")
            {
                errKhachHang.SetError(txtTenKH, "Tên Khách Hàng không được để trống!");
            }
            if (cboTimKiemKH.SelectedIndex < 0)
            {
                errKhachHang.SetError(cboTimKiemKH, "Trường không được để trống!");
            }
            if (txtTimKiemKH.Text.Trim() == "")
            {
                errKhachHang.SetError(txtTimKiemKH, "Trường không được để trống!");
            }

        }
        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            btnThemKH.Enabled = false;
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;
            btnLuuKH.Text = "Tìm kiếm";
            btnLuuKH.Enabled = true;
            Hide(false);
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;
            btnTimKiemKH.Enabled = false;
            btnLuuKH.Enabled = true;
            btnLuuKH.Text = "Thêm";
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btnThemKH.Enabled = false;
            btnXoaKH.Enabled = false;
            btnTimKiemKH.Enabled = false;
            btnLuuKH.Text = "Sửa";
            btnLuuKH.Enabled = true;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            btnSuaKH.Enabled = false;
            btnThemKH.Enabled = false;
            btnTimKiemKH.Enabled = false;
            btnLuuKH.Text = "Xoá";
            btnLuuKH.Enabled = true;
            Hide(false);
        }

        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dtgKhachHang.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dtgKhachHang.CurrentRow.Cells[2].Value;
            txtDiaChi.Text = dtgKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtDienThoai.Text = dtgKhachHang.CurrentRow.Cells[4].Value.ToString();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            Load1();
            btnLuuKH.Enabled = false;
            if (ThamSo.Quyen == 2)
            {
                btnThemKH.Enabled = false;
                btnXoaKH.Enabled = false;
            }
            dal = new DALQuanLyBanHang();
            string sql = "Select * from tblKhachHang";
            ShowData(sql);
            cboTimKiemKH.Visible = false;
            txtTimKiemKH.Visible = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            Hide(true);
            btnLuuKH.Text = "Lưu Lại";
            btnLuuKH.Enabled = false;
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            check();
            string sql = "";
            if (btnThemKH.Enabled == true)
            {
                string date = dtpNgaySinh.Value.ToString();
                DateTime datevalue = DateTime.Parse(date);
                sql = "INSERT INTO tblKhachHang(MaKH,TenKH,NgaySinh,DiaChi,DienThoai,TaiKhoan)";
                sql += " VALUES('" + txtMaKH.Text + "','" + txtTenKH.Text + "','";
                sql += dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy") + "','";
                sql += txtDiaChi.Text + "','" + txtDienThoai.Text + "','" + cboTaiKhoan.SelectedValue.ToString() + "')";
            }
            if (btnSuaKH.Enabled == true)
            {
                if (txtMaKH.Text == "")
                {
                    errKhachHang.SetError(txtMaKH, "Mã Khách Hàng không được để trống!");
                }
                
                sql = "UPDATE tblKhachHang SET ";
                sql += "MaKH = '" + txtMaKH.Text + "', TenKH ='" + txtTenKH.Text + "', ";
                sql += "NgaySinh = '" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy") + "',";
                sql += "DiaChi = '" + txtDiaChi.Text + "', DienThoai = '" + txtDienThoai.Text + "', TaiKhoan = '" + cboTaiKhoan.SelectedItem.ToString() + "'";
                sql += " WHERE MaKH ='" + txtMaKH.Text + "'";
            }
            if (btnXoaKH.Enabled == true)
            {
                if (cboTimKiemKH.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa sản phẩm: " + cboTimKiemKH.SelectedItem.ToString() + " " + txtTimKiemKH.Text + " hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sql = "DELETE FROM tblKhachHang WHERE " + cboTimKiemKH.SelectedItem.ToString() + " = '" + txtTimKiemKH.Text + "'";
                    }
                }
            }

            if (sql != "")
            {
                dal.DoExecute(sql);
            }
                if (btnTimKiemKH.Enabled == true)
                {
                    if (cboTimKiemKH.SelectedIndex >= 0)
                    {
                        sql = "Select * From tblKhachHang Where " + cboTimKiemKH.SelectedItem.ToString() + " ='" + txtTimKiemKH.Text + "'";
                        ShowData(sql);
                    }
                }
        }
    }
}
