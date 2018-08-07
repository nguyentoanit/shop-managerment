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
    public partial class frmNhaCC : Form
    {
        DALQuanLyBanHang dal = new DALQuanLyBanHang();
        public frmNhaCC()
        {
            InitializeComponent();
        }
        private void TurnControls(bool off)
        {
            btnTimKiemNCC.Enabled = off;
            btnSuaNCC.Enabled = off;
            if (ThamSo.Quyen != 2)
            {
                btnXoaNCC.Enabled = off;
                btnThemNCC.Enabled = off;
            }
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDienThoaiNCC.Clear();
            txtDiaChiNCC.Clear();
        }
        private void ShowData(String sql)
        {
            dtgNhaCC.DataSource = dal.GetData(sql).Tables[0];
            dtgNhaCC.Refresh();
        }
        private void Hide(bool off)
        {
            lblMaNCC.Visible = off;
            lblTenNCC.Visible = off;
            lblDiaChiNCC.Visible = off;
            lblDienThoaiNCC.Visible = off;

            txtMaNCC.Visible = off;
            txtTenNCC.Visible = off;
            txtDiaChiNCC.Visible = off;
            txtDienThoaiNCC.Visible = off;
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtDienThoaiNCC.Clear();
            txtTimKiemNCC.Clear();
            txtMaNCC.Enabled = off;
            cboTimKiemNCC.Visible = !off;
            txtTimKiemNCC.Visible = !off;
        }
        private void check()
        {
            if (txtMaNCC.Text.Trim() == "")
            {
                errNCC.SetError(txtMaNCC, "Mã Nhà Cung Cấp không được để trống!");
            }

            if (txtTenNCC.Text.Trim() == "")
            {
                errNCC.SetError(txtTenNCC, "Tên Nhà Cung Cấp không được để trống!");
            }
            if (cboTimKiemNCC.SelectedIndex < 0)
            {
                errNCC.SetError(cboTimKiemNCC, "Trường không được để trống!");
            }
            if (txtTimKiemNCC.Text.Trim() == "")
            {
                errNCC.SetError(txtTimKiemNCC, "Trường không được để trống!");
            }
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            if (ThamSo.Quyen == 2)
            {
                btnThemNCC.Enabled = false;
                btnXoaNCC.Enabled = false;
            }
            String sql = "Select * from tblNhaCC";
            ShowData(sql);
            btnLuuNCC.Enabled = false;
        }
        
        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            btnThemNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            btnXoaNCC.Enabled = false;        
            btnLuuNCC.Text = "Tìm Kiếm";
            btnLuuNCC.Enabled = true;
            Hide(false);          
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            btnSuaNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnTimKiemNCC.Enabled = false;
            btnLuuNCC.Enabled = true;
            btnLuuNCC.Text = "Thêm";
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            btnThemNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnTimKiemNCC.Enabled = false;
            btnLuuNCC.Enabled = true;
            btnLuuNCC.Text = "Sửa";
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            btnSuaNCC.Enabled = false;
            btnThemNCC.Enabled = false;
            btnTimKiemNCC.Enabled = false;
            btnLuuNCC.Enabled = true;
            btnLuuNCC.Text = "Xoá";
            Hide(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyNCC_Click(object sender, EventArgs e)
        {
            Hide(true);
            TurnControls(true);
            btnLuuNCC.Enabled = false;
            btnLuuNCC.Text = "Lưu Lại";
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            check();
            string sql = "";
            if (btnThemNCC.Enabled == true)
            {
                sql = "INSERT INTO tblNhaCC(MaNCC,TenNCC,DiaChi,DienThoai)";
                sql += " VALUES('" + txtMaNCC.Text + "','" + txtTenNCC.Text + "','";
                sql += txtDiaChiNCC.Text + "','" +txtDienThoaiNCC.Text + "')";
            }
            if (btnSuaNCC.Enabled == true)
            {
                sql = "UPDATE tblNhaCC SET ";
                sql += "MaNCC = '" + txtMaNCC.Text + "', TenNCC ='" + txtTenNCC.Text + "', ";
                sql += "DienThoai = '" + txtDienThoaiNCC.Text + "', DiaChi = '" + txtDiaChiNCC.Text + "'";
                sql += " WHERE MaNCC ='" + txtMaNCC.Text + "'";
            }
            if (btnXoaNCC.Enabled == true)
            {
                if (cboTimKiemNCC.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa sản phẩm: " + cboTimKiemNCC.SelectedItem.ToString() + " " + txtTimKiemNCC.Text + " hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sql = "DELETE FROM tblNhaCC WHERE " + cboTimKiemNCC.SelectedItem.ToString() + " = '" + txtTimKiemNCC.Text + "'";
                    }
                }
            }

            if (sql != "")
            {
                dal.DoExecute(sql);
            }
            if (btnTimKiemNCC.Enabled == true)
            {
                if (cboTimKiemNCC.SelectedIndex >= 0)
                {
                    sql = "Select * From tblNhaCC Where " + cboTimKiemNCC.SelectedItem.ToString() + " ='" + txtTimKiemNCC.Text + "'";
                    ShowData(sql);
                }
            }
        }

        private void dtgNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dtgNhaCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dtgNhaCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNCC.Text = dtgNhaCC.CurrentRow.Cells[2].Value.ToString();
            txtDienThoaiNCC.Text = dtgNhaCC.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
