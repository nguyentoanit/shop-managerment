namespace QuanLyBanHang
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoatKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.cboTimKiemKH = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.errKhachHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoatKH);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Controls.Add(this.btnSuaKH);
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.btnTimKiemKH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoatKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatKH.Image")));
            this.btnThoatKH.Location = new System.Drawing.Point(690, 19);
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.Size = new System.Drawing.Size(80, 45);
            this.btnThoatKH.TabIndex = 4;
            this.btnThoatKH.Text = "Thoát";
            this.btnThoatKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoatKH.UseVisualStyleBackColor = true;
            this.btnThoatKH.Click += new System.EventHandler(this.btnThoatKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.Image")));
            this.btnXoaKH.Location = new System.Drawing.Point(546, 19);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(81, 45);
            this.btnXoaKH.TabIndex = 3;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.Image")));
            this.btnSuaKH.Location = new System.Drawing.Point(381, 19);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(86, 45);
            this.btnSuaKH.TabIndex = 2;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemKH.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.btnThemKH.Location = new System.Drawing.Point(207, 19);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(87, 45);
            this.btnThemKH.TabIndex = 1;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemKH.Image")));
            this.btnTimKiemKH.Location = new System.Drawing.Point(53, 19);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(88, 45);
            this.btnTimKiemKH.TabIndex = 0;
            this.btnTimKiemKH.Text = "Tìm Kiếm";
            this.btnTimKiemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgKhachHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 158);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKhachHang.Location = new System.Drawing.Point(3, 16);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.Size = new System.Drawing.Size(793, 139);
            this.dtgKhachHang.TabIndex = 0;
            this.dtgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKetQua_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHuyBo);
            this.groupBox3.Controls.Add(this.btnLuuKH);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(640, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 199);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyBo.Image = global::QuanLyBanHang.Properties.Resources.delete1;
            this.btnHuyBo.Location = new System.Drawing.Point(38, 103);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(73, 56);
            this.btnHuyBo.TabIndex = 9;
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.Image")));
            this.btnLuuKH.Location = new System.Drawing.Point(38, 18);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(73, 54);
            this.btnLuuKH.TabIndex = 8;
            this.btnLuuKH.Text = "Lưu Lại";
            this.btnLuuKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTaiKhoan);
            this.groupBox4.Controls.Add(this.cboTaiKhoan);
            this.groupBox4.Controls.Add(this.txtTimKiemKH);
            this.groupBox4.Controls.Add(this.cboTimKiemKH);
            this.groupBox4.Controls.Add(this.txtDienThoai);
            this.groupBox4.Controls.Add(this.dtpNgaySinh);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.txtTenKH);
            this.groupBox4.Controls.Add(this.txtMaKH);
            this.groupBox4.Controls.Add(this.lblDienThoai);
            this.groupBox4.Controls.Add(this.lblDiaChi);
            this.groupBox4.Controls.Add(this.lblTenKH);
            this.groupBox4.Controls.Add(this.lblNgaySinh);
            this.groupBox4.Controls.Add(this.lblMaKH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(640, 199);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(453, 102);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(56, 13);
            this.lblTaiKhoan.TabIndex = 13;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Items.AddRange(new object[] {
            "MaKH",
            "TenKH",
            "DiaChi",
            "DienThoai"});
            this.cboTaiKhoan.Location = new System.Drawing.Point(518, 97);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(97, 21);
            this.cboTaiKhoan.TabIndex = 5;
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiemKH.Location = new System.Drawing.Point(367, 77);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiemKH.TabIndex = 7;
            // 
            // cboTimKiemKH
            // 
            this.cboTimKiemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboTimKiemKH.FormattingEnabled = true;
            this.cboTimKiemKH.Items.AddRange(new object[] {
            "MaKH",
            "TenKH",
            "DiaChi",
            "DienThoai",
            "TaiKhoan"});
            this.cboTimKiemKH.Location = new System.Drawing.Point(185, 76);
            this.cboTimKiemKH.Name = "cboTimKiemKH";
            this.cboTimKiemKH.Size = new System.Drawing.Size(121, 21);
            this.cboTimKiemKH.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDienThoai.Location = new System.Drawing.Point(318, 98);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(518, 42);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(97, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDiaChi.Location = new System.Drawing.Point(106, 98);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenKH.Location = new System.Drawing.Point(318, 42);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaKH.Location = new System.Drawing.Point(106, 41);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 0;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(220, 103);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(62, 13);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện Thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 103);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(44, 13);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(220, 44);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(92, 13);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên Khách Hàng:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(453, 45);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.lblNgaySinh.TabIndex = 1;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(12, 44);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(88, 13);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã Khách Hàng:";
            // 
            // errKhachHang
            // 
            this.errKhachHang.ContainerControl = this;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý  Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoatKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.ComboBox cboTimKiemKH;
        private System.Windows.Forms.ErrorProvider errKhachHang;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
    }
}