namespace QuanLyBanHang
{
    partial class frmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgNhaCC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnTimKiemNCC = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHuyNCC = new System.Windows.Forms.Button();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.gpbNhap = new System.Windows.Forms.GroupBox();
            this.txtTimKiemNCC = new System.Windows.Forms.TextBox();
            this.cboTimKiemNCC = new System.Windows.Forms.ComboBox();
            this.lblDienThoaiNCC = new System.Windows.Forms.Label();
            this.lblDiaChiNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtDienThoaiNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.errNCC = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhaCC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgNhaCC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 206);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // dtgNhaCC
            // 
            this.dtgNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNhaCC.Location = new System.Drawing.Point(3, 16);
            this.dtgNhaCC.Name = "dtgNhaCC";
            this.dtgNhaCC.Size = new System.Drawing.Size(775, 187);
            this.dtgNhaCC.TabIndex = 0;
            this.dtgNhaCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhaCC_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoaNCC);
            this.groupBox2.Controls.Add(this.btnSuaNCC);
            this.groupBox2.Controls.Add(this.btnThemNCC);
            this.groupBox2.Controls.Add(this.btnTimKiemNCC);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(625, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 179);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThoat.Image = global::QuanLyBanHang.Properties.Resources.exit;
            this.btnThoat.Location = new System.Drawing.Point(671, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.Image")));
            this.btnXoaNCC.Location = new System.Drawing.Point(523, 19);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(75, 41);
            this.btnXoaNCC.TabIndex = 11;
            this.btnXoaNCC.Text = "Xoá";
            this.btnXoaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSuaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.Image")));
            this.btnSuaNCC.Location = new System.Drawing.Point(373, 19);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(75, 41);
            this.btnSuaNCC.TabIndex = 10;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThemNCC.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.btnThemNCC.Location = new System.Drawing.Point(210, 19);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(75, 41);
            this.btnThemNCC.TabIndex = 9;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnTimKiemNCC
            // 
            this.btnTimKiemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTimKiemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemNCC.Image")));
            this.btnTimKiemNCC.Location = new System.Drawing.Point(54, 19);
            this.btnTimKiemNCC.Name = "btnTimKiemNCC";
            this.btnTimKiemNCC.Size = new System.Drawing.Size(75, 41);
            this.btnTimKiemNCC.TabIndex = 8;
            this.btnTimKiemNCC.Text = "Tìm kiếm";
            this.btnTimKiemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiemNCC.UseVisualStyleBackColor = true;
            this.btnTimKiemNCC.Click += new System.EventHandler(this.btnTimKiemNCC_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHuyNCC);
            this.groupBox4.Controls.Add(this.btnLuuNCC);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(625, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 178);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnHuyNCC
            // 
            this.btnHuyNCC.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnHuyNCC.Location = new System.Drawing.Point(46, 99);
            this.btnHuyNCC.Name = "btnHuyNCC";
            this.btnHuyNCC.Size = new System.Drawing.Size(75, 48);
            this.btnHuyNCC.TabIndex = 1;
            this.btnHuyNCC.Text = "Huỷ Bỏ";
            this.btnHuyNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuyNCC.UseVisualStyleBackColor = true;
            this.btnHuyNCC.Click += new System.EventHandler(this.btnHuyNCC_Click);
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNCC.Image")));
            this.btnLuuNCC.Location = new System.Drawing.Point(46, 19);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(75, 51);
            this.btnLuuNCC.TabIndex = 0;
            this.btnLuuNCC.Text = "Lưu Lại";
            this.btnLuuNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuuNCC.UseVisualStyleBackColor = true;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCC_Click);
            // 
            // gpbNhap
            // 
            this.gpbNhap.Controls.Add(this.txtTimKiemNCC);
            this.gpbNhap.Controls.Add(this.cboTimKiemNCC);
            this.gpbNhap.Controls.Add(this.lblDienThoaiNCC);
            this.gpbNhap.Controls.Add(this.lblDiaChiNCC);
            this.gpbNhap.Controls.Add(this.lblTenNCC);
            this.gpbNhap.Controls.Add(this.lblMaNCC);
            this.gpbNhap.Controls.Add(this.txtDienThoaiNCC);
            this.gpbNhap.Controls.Add(this.txtTenNCC);
            this.gpbNhap.Controls.Add(this.txtDiaChiNCC);
            this.gpbNhap.Controls.Add(this.txtMaNCC);
            this.gpbNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbNhap.Location = new System.Drawing.Point(0, 78);
            this.gpbNhap.Name = "gpbNhap";
            this.gpbNhap.Size = new System.Drawing.Size(625, 178);
            this.gpbNhap.TabIndex = 0;
            this.gpbNhap.TabStop = false;
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiemNCC.Location = new System.Drawing.Point(323, 86);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.Size = new System.Drawing.Size(125, 20);
            this.txtTimKiemNCC.TabIndex = 5;
            this.txtTimKiemNCC.Visible = false;
            // 
            // cboTimKiemNCC
            // 
            this.cboTimKiemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboTimKiemNCC.FormattingEnabled = true;
            this.cboTimKiemNCC.Items.AddRange(new object[] {
            "MaNCC",
            "TenNCC",
            "DiaChi",
            "DienThoai"});
            this.cboTimKiemNCC.Location = new System.Drawing.Point(151, 86);
            this.cboTimKiemNCC.Name = "cboTimKiemNCC";
            this.cboTimKiemNCC.Size = new System.Drawing.Size(121, 21);
            this.cboTimKiemNCC.TabIndex = 4;
            this.cboTimKiemNCC.Visible = false;
            // 
            // lblDienThoaiNCC
            // 
            this.lblDienThoaiNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDienThoaiNCC.AutoSize = true;
            this.lblDienThoaiNCC.Location = new System.Drawing.Point(316, 120);
            this.lblDienThoaiNCC.Name = "lblDienThoaiNCC";
            this.lblDienThoaiNCC.Size = new System.Drawing.Size(62, 13);
            this.lblDienThoaiNCC.TabIndex = 7;
            this.lblDienThoaiNCC.Text = "Điện Thoại:";
            // 
            // lblDiaChiNCC
            // 
            this.lblDiaChiNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDiaChiNCC.AutoSize = true;
            this.lblDiaChiNCC.Location = new System.Drawing.Point(29, 120);
            this.lblDiaChiNCC.Name = "lblDiaChiNCC";
            this.lblDiaChiNCC.Size = new System.Drawing.Size(44, 13);
            this.lblDiaChiNCC.TabIndex = 6;
            this.lblDiaChiNCC.Text = "Địa Chỉ:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(310, 45);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(102, 13);
            this.lblTenNCC.TabIndex = 5;
            this.lblTenNCC.Text = "Tên Nhà Cung Cấp:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(29, 48);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(98, 13);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // txtDienThoaiNCC
            // 
            this.txtDienThoaiNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDienThoaiNCC.Location = new System.Drawing.Point(432, 115);
            this.txtDienThoaiNCC.Name = "txtDienThoaiNCC";
            this.txtDienThoaiNCC.Size = new System.Drawing.Size(137, 20);
            this.txtDienThoaiNCC.TabIndex = 3;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenNCC.Location = new System.Drawing.Point(432, 41);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(137, 20);
            this.txtTenNCC.TabIndex = 1;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(151, 117);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(146, 20);
            this.txtDiaChiNCC.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaNCC.Location = new System.Drawing.Point(151, 45);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(146, 20);
            this.txtMaNCC.TabIndex = 0;
            // 
            // errNCC
            // 
            this.errNCC.ContainerControl = this;
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 462);
            this.Controls.Add(this.gpbNhap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhaCC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gpbNhap.ResumeLayout(false);
            this.gpbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgNhaCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnTimKiemNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gpbNhap;
        private System.Windows.Forms.Label lblDienThoaiNCC;
        private System.Windows.Forms.Label lblDiaChiNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtDienThoaiNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Button btnHuyNCC;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.ComboBox cboTimKiemNCC;
        private System.Windows.Forms.TextBox txtTimKiemNCC;
        private System.Windows.Forms.ErrorProvider errNCC;
    }
}