namespace QuanLyBanHang
{
    partial class frmMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemMH = new System.Windows.Forms.Button();
            this.btnThoatMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgMatHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiemMH = new System.Windows.Forms.TextBox();
            this.cboTimKiemMH = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnHuyMH = new System.Windows.Forms.Button();
            this.btnLuuMH = new System.Windows.Forms.Button();
            this.cboNhaCC = new System.Windows.Forms.ComboBox();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.errMatHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemMH);
            this.groupBox1.Controls.Add(this.btnThoatMH);
            this.groupBox1.Controls.Add(this.btnXoaMH);
            this.groupBox1.Controls.Add(this.btnSuaMH);
            this.groupBox1.Controls.Add(this.btnThemMH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // btnTimKiemMH
            // 
            this.btnTimKiemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTimKiemMH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemMH.Image")));
            this.btnTimKiemMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemMH.Location = new System.Drawing.Point(65, 19);
            this.btnTimKiemMH.Name = "btnTimKiemMH";
            this.btnTimKiemMH.Size = new System.Drawing.Size(86, 31);
            this.btnTimKiemMH.TabIndex = 11;
            this.btnTimKiemMH.Text = "Tìm kiếm";
            this.btnTimKiemMH.UseVisualStyleBackColor = true;
            this.btnTimKiemMH.Click += new System.EventHandler(this.btnTimKiemMH_Click);
            // 
            // btnThoatMH
            // 
            this.btnThoatMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThoatMH.Image = global::QuanLyBanHang.Properties.Resources.exit;
            this.btnThoatMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatMH.Location = new System.Drawing.Point(779, 19);
            this.btnThoatMH.Name = "btnThoatMH";
            this.btnThoatMH.Size = new System.Drawing.Size(87, 31);
            this.btnThoatMH.TabIndex = 15;
            this.btnThoatMH.Text = "Thoát";
            this.btnThoatMH.UseVisualStyleBackColor = true;
            this.btnThoatMH.Click += new System.EventHandler(this.btnThoatMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXoaMH.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnXoaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMH.Location = new System.Drawing.Point(604, 19);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(91, 31);
            this.btnXoaMH.TabIndex = 14;
            this.btnXoaMH.Text = "Xoá";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSuaMH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMH.Image")));
            this.btnSuaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMH.Location = new System.Drawing.Point(440, 19);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(83, 31);
            this.btnSuaMH.TabIndex = 13;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThemMH.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.btnThemMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMH.Location = new System.Drawing.Point(244, 19);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(86, 31);
            this.btnThemMH.TabIndex = 12;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgMatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 170);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // dtgMatHang
            // 
            this.dtgMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMatHang.Location = new System.Drawing.Point(3, 16);
            this.dtgMatHang.Name = "dtgMatHang";
            this.dtgMatHang.Size = new System.Drawing.Size(946, 151);
            this.dtgMatHang.TabIndex = 0;
            this.dtgMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMatHang_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgayNhap);
            this.groupBox3.Controls.Add(this.txtTimKiemMH);
            this.groupBox3.Controls.Add(this.cboTimKiemMH);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.lblSoLuong);
            this.groupBox3.Controls.Add(this.btnHuyMH);
            this.groupBox3.Controls.Add(this.btnLuuMH);
            this.groupBox3.Controls.Add(this.cboNhaCC);
            this.groupBox3.Controls.Add(this.lblNhaCC);
            this.groupBox3.Controls.Add(this.lblNgayNhap);
            this.groupBox3.Controls.Add(this.txtGiaNhap);
            this.groupBox3.Controls.Add(this.lblGiaNhap);
            this.groupBox3.Controls.Add(this.txtTenMH);
            this.groupBox3.Controls.Add(this.lblTenMH);
            this.groupBox3.Controls.Add(this.txtGiaBan);
            this.groupBox3.Controls.Add(this.lblGiaBan);
            this.groupBox3.Controls.Add(this.txtMaMH);
            this.groupBox3.Controls.Add(this.lblMaMH);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(952, 164);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(610, 16);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(120, 20);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // txtTimKiemMH
            // 
            this.txtTimKiemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiemMH.Location = new System.Drawing.Point(417, 47);
            this.txtTimKiemMH.Name = "txtTimKiemMH";
            this.txtTimKiemMH.Size = new System.Drawing.Size(125, 20);
            this.txtTimKiemMH.TabIndex = 8;
            this.txtTimKiemMH.Visible = false;
            // 
            // cboTimKiemMH
            // 
            this.cboTimKiemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboTimKiemMH.FormattingEnabled = true;
            this.cboTimKiemMH.Items.AddRange(new object[] {
            "MaMH",
            "TenMH",
            "GiaNhap",
            "GiaBan",
            "SoLuong",
            "MaNCC"});
            this.cboTimKiemMH.Location = new System.Drawing.Point(245, 47);
            this.cboTimKiemMH.Name = "cboTimKiemMH";
            this.cboTimKiemMH.Size = new System.Drawing.Size(121, 21);
            this.cboTimKiemMH.TabIndex = 7;
            this.cboTimKiemMH.Visible = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoLuong.Location = new System.Drawing.Point(834, 16);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(95, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(747, 19);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 34;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // btnHuyMH
            // 
            this.btnHuyMH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuyMH.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnHuyMH.Location = new System.Drawing.Point(521, 105);
            this.btnHuyMH.Name = "btnHuyMH";
            this.btnHuyMH.Size = new System.Drawing.Size(74, 53);
            this.btnHuyMH.TabIndex = 10;
            this.btnHuyMH.Text = "Huỷ Bỏ";
            this.btnHuyMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuyMH.UseVisualStyleBackColor = true;
            this.btnHuyMH.Click += new System.EventHandler(this.btnHuyMH_Click);
            // 
            // btnLuuMH
            // 
            this.btnLuuMH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuuMH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuMH.Image")));
            this.btnLuuMH.Location = new System.Drawing.Point(210, 105);
            this.btnLuuMH.Name = "btnLuuMH";
            this.btnLuuMH.Size = new System.Drawing.Size(76, 53);
            this.btnLuuMH.TabIndex = 9;
            this.btnLuuMH.Text = "Lưu lại";
            this.btnLuuMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuuMH.UseVisualStyleBackColor = true;
            this.btnLuuMH.Click += new System.EventHandler(this.btnLuuMH_Click);
            // 
            // cboNhaCC
            // 
            this.cboNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboNhaCC.FormattingEnabled = true;
            this.cboNhaCC.Location = new System.Drawing.Point(610, 68);
            this.cboNhaCC.Name = "cboNhaCC";
            this.cboNhaCC.Size = new System.Drawing.Size(107, 21);
            this.cboNhaCC.TabIndex = 6;
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Location = new System.Drawing.Point(518, 72);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(77, 13);
            this.lblNhaCC.TabIndex = 29;
            this.lblNhaCC.Text = "Nhà Cung Cấp";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(518, 19);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(61, 13);
            this.lblNgayNhap.TabIndex = 28;
            this.lblNgayNhap.Text = "Ngày Nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGiaNhap.Location = new System.Drawing.Point(378, 68);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtGiaNhap.TabIndex = 5;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Location = new System.Drawing.Point(281, 71);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(52, 13);
            this.lblGiaNhap.TabIndex = 26;
            this.lblGiaNhap.Text = "Giá Nhập";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenMH.Location = new System.Drawing.Point(378, 19);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(100, 20);
            this.txtTenMH.TabIndex = 1;
            // 
            // lblTenMH
            // 
            this.lblTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(281, 22);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(76, 13);
            this.lblTenMH.TabIndex = 24;
            this.lblTenMH.Text = "Tên Mặt Hàng";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGiaBan.Location = new System.Drawing.Point(104, 67);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 4;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(30, 70);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(45, 13);
            this.lblGiaBan.TabIndex = 22;
            this.lblGiaBan.Text = "Giá Bán";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaMH.Location = new System.Drawing.Point(104, 19);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 0;
            // 
            // lblMaMH
            // 
            this.lblMaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(30, 22);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(72, 13);
            this.lblMaMH.TabIndex = 20;
            this.lblMaMH.Text = "Mã Mặt Hàng";
            // 
            // errMatHang
            // 
            this.errMatHang.ContainerControl = this;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mặt Hàng";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoatMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnTimKiemMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgMatHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnHuyMH;
        private System.Windows.Forms.Button btnLuuMH;
        private System.Windows.Forms.ComboBox cboNhaCC;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.TextBox txtTimKiemMH;
        private System.Windows.Forms.ComboBox cboTimKiemMH;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ErrorProvider errMatHang;
    }
}