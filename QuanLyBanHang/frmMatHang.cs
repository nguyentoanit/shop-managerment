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
    public partial class frmMatHang : Form
    {
        DALQuanLyBanHang dal;
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void btnThoatMH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load1()
        {
            string sql = "select MaNCC, TenNCC from tblNhaCC";
            DALQuanLyBanHang dal = new DALQuanLyBanHang();
            DataSet ds = new DataSet();
            ds = dal.GetData(sql);
            cboNhaCC.DataSource = ds.Tables[0];
            cboNhaCC.DisplayMember = "TenNCC";
            cboNhaCC.ValueMember = "MaNCC";

        }
        private void check()
        {
            if (txtMaMH.Text.Trim() == "")
            {
                errMatHang.SetError(txtMaMH, "Mã Mặt Hàng không được để trống!");
            }

            if (txtTenMH.Text.Trim() == "")
            {
                errMatHang.SetError(txtTenMH, "Tên Mặt Hàng không được để trống!");
            }
            if (cboTimKiemMH.SelectedIndex < 0)
            {
                errMatHang.SetError(cboTimKiemMH, "Trường không được để trống!");
            }
            if (txtTimKiemMH.Text.Trim() == "")
            {
                errMatHang.SetError(txtTimKiemMH, "Trường không được để trống!");
            }
        }
        private void EnableControls(bool isShow)
        {
            if (ThamSo.Quyen == 2)
            {
                btnThemMH.Enabled = !isShow;
                btnXoaMH.Enabled = !isShow;
            }
            else
            {
                btnXoaMH.Enabled = isShow;
                btnThemMH.Enabled = isShow;
            }
            btnSuaMH.Enabled = isShow;
            btnTimKiemMH.Enabled = isShow;
        }
        private void Hide(bool off)
        {
            lblMaMH.Visible = off;
            lblTenMH.Visible = off;
            lblNgayNhap.Visible = off;
            lblGiaNhap.Visible = off;
            lblGiaBan.Visible = off;
            lblSoLuong.Visible = off;
            lblNhaCC.Visible = off;
            txtMaMH.Visible = off;
            txtTenMH.Visible = off;
            dtpNgayNhap.Visible = off;
            txtGiaBan.Visible = off;
            txtGiaNhap.Visible = off;
            txtSoLuong.Visible = off;
            cboNhaCC.Visible = off;

            txtMaMH.Clear();
            txtTenMH.Clear();
            txtGiaBan.Clear();
            txtGiaNhap.Clear();
            txtSoLuong.Clear();
            txtTimKiemMH.Clear();
            txtMaMH.Enabled = off;
            cboTimKiemMH.Visible = !off;
            txtTimKiemMH.Visible = !off;

        }
        private void ShowData(String sql)
        {
            dtgMatHang.DataSource = dal.GetData(sql).Tables[0];
            dtgMatHang.Refresh();
        }
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            if (ThamSo.Quyen == 2)
            {
                btnThemMH.Enabled = false;
                btnXoaMH.Enabled = false;
            }
            dal = new DALQuanLyBanHang();
            string sql = "Select * from tblMatHang";
            ShowData(sql);

            btnLuuMH.Enabled = false;
        }
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            btnSuaMH.Enabled = false;
            btnXoaMH.Enabled = false;
            btnTimKiemMH.Enabled = false;
            Load1();
            btnLuuMH.Enabled = true;
            btnLuuMH.Text = "Thêm";
        }
        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            Load1();
            txtMaMH.Enabled = false;
            btnThemMH.Enabled = false;
            btnXoaMH.Enabled = false;
            btnTimKiemMH.Enabled = false;
            btnLuuMH.Text = "Sửa";
            btnLuuMH.Enabled = true;
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            btnSuaMH.Enabled = false;
            btnThemMH.Enabled = false;
            btnTimKiemMH.Enabled = false;
            btnLuuMH.Text = "Xoá";
            btnLuuMH.Enabled = true;
            Hide(false);
        }

        private void btnTimKiemMH_Click(object sender, EventArgs e)
        {
            btnThemMH.Enabled = false;
            btnSuaMH.Enabled = false;
            btnXoaMH.Enabled = false;
            btnLuuMH.Text = "Tìm kiếm";
            btnLuuMH.Enabled = true;
            Hide(false);

        }

        private void btnLuuMH_Click(object sender, EventArgs e)
        {
            check();
            string sql = "";
            if (btnThemMH.Enabled == true)
            {
                string date = dtpNgayNhap.Value.ToString();
                DateTime datevalue = DateTime.Parse(date);
                sql = "INSERT INTO tblMatHang(MaMH,TenMH,NgayNhap,GiaNhap,GiaBan,SoLuong,MaNCC)";
                sql += " VALUES('" + txtMaMH.Text + "','" + txtTenMH.Text + "','";
                sql += dtpNgayNhap.Value.Date.ToString("MM/dd/yyyy") + "','";
                sql += txtGiaNhap.Text + "','" + txtGiaBan.Text + "','" + txtSoLuong.Text + "','" + cboNhaCC.SelectedValue.ToString() + "')";
            }
            if (btnSuaMH.Enabled == true)
            {
                txtMaMH.Enabled = false;
                sql = "UPDATE tblMatHang SET ";
                sql += "MaMH = '" + txtMaMH.Text + "', TenMH ='" + txtTenMH.Text + "', ";
                sql += "NgayNhap = '" + dtpNgayNhap.Value.Date.ToString("MM/dd/yyyy") + "', GiaNhap = '" + txtGiaNhap.Text + "',";
                sql += "GiaBan = '" + txtGiaBan.Text + "', SoLuong = '" + txtSoLuong.Text + "', MaNCC = '" + cboNhaCC.SelectedValue.ToString() + "'";
                sql += " WHERE MaMH ='" + txtMaMH.Text + "'";
            }
            if (btnXoaMH.Enabled == true)
            {
                if (cboTimKiemMH.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa sản phẩm: " + cboTimKiemMH.SelectedItem.ToString() + " " + txtTimKiemMH.Text + " hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sql = "DELETE FROM tblMatHang WHERE " + cboTimKiemMH.SelectedItem.ToString() + " = '" + txtTimKiemMH.Text + "'";
                    }
                }
            }

            if (sql != "")
            {
                dal.DoExecute(sql);
            }
            if (btnTimKiemMH.Enabled == true)
            {
                if (cboTimKiemMH.SelectedIndex >= 0)
                {
                    sql = "Select * From tblMatHang Where " + cboTimKiemMH.SelectedItem.ToString() + " ='" + txtTimKiemMH.Text + "'";
                    ShowData(sql);
                }
             }
        }

        private void btnHuyMH_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            Hide(true);
            btnLuuMH.Text = "Lưu Lại";
            btnLuuMH.Enabled = false;
        }

        private void dtgMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dtgMatHang.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dtgMatHang.CurrentRow.Cells[1].Value.ToString();
            dtpNgayNhap.Value = (DateTime)dtgMatHang.CurrentRow.Cells[2].Value;
            txtGiaNhap.Text = dtgMatHang.CurrentRow.Cells[4].Value.ToString();
            txtGiaBan.Text = dtgMatHang.CurrentRow.Cells[5].Value.ToString();
            txtSoLuong.Text = dtgMatHang.CurrentRow.Cells[6].Value.ToString();
            //cmbNhaCC.SelectedItem = dtgMatHang.CurrentRow.Cells[7].Value.ToString();
        }


    }
}
