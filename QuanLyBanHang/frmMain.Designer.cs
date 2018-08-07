namespace QuanLyBanHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabQuanLy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDangKiTK = new System.Windows.Forms.Button();
            this.btnDangNhapTK = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnQuanLyKH = new System.Windows.Forms.Button();
            this.btnQuanLyNCC = new System.Windows.Forms.Button();
            this.btnQuanLyMH = new System.Windows.Forms.Button();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnTroGiup = new System.Windows.Forms.Button();
            this.btnThongTinSP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabQuanLy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.tabPage1);
            this.tabQuanLy.Controls.Add(this.tabPage2);
            this.tabQuanLy.Controls.Add(this.tabBaoCao);
            this.tabQuanLy.Controls.Add(this.tabPage6);
            this.tabQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQuanLy.Font = new System.Drawing.Font("Minion Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLy.Location = new System.Drawing.Point(3, 16);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.SelectedIndex = 0;
            this.tabQuanLy.Size = new System.Drawing.Size(968, 114);
            this.tabQuanLy.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDangXuat);
            this.tabPage1.Controls.Add(this.btnDangKiTK);
            this.tabPage1.Controls.Add(this.btnDangNhapTK);
            this.tabPage1.Font = new System.Drawing.Font("Minion Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.Image = global::QuanLyBanHang.Properties.Resources.thoat;
            this.btnDangXuat.Location = new System.Drawing.Point(649, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(102, 66);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKiTK
            // 
            this.btnDangKiTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangKiTK.Image = global::QuanLyBanHang.Properties.Resources.doimatkhau;
            this.btnDangKiTK.Location = new System.Drawing.Point(405, 12);
            this.btnDangKiTK.Name = "btnDangKiTK";
            this.btnDangKiTK.Size = new System.Drawing.Size(102, 66);
            this.btnDangKiTK.TabIndex = 1;
            this.btnDangKiTK.Text = "Đăng Kí";
            this.btnDangKiTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangKiTK.UseVisualStyleBackColor = true;
            this.btnDangKiTK.Click += new System.EventHandler(this.btnDangKiTK_Click);
            // 
            // btnDangNhapTK
            // 
            this.btnDangNhapTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhapTK.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhapTK.Image")));
            this.btnDangNhapTK.Location = new System.Drawing.Point(173, 12);
            this.btnDangNhapTK.Name = "btnDangNhapTK";
            this.btnDangNhapTK.Size = new System.Drawing.Size(98, 66);
            this.btnDangNhapTK.TabIndex = 0;
            this.btnDangNhapTK.Text = "Đăng Nhập";
            this.btnDangNhapTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangNhapTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangNhapTK.UseVisualStyleBackColor = true;
            this.btnDangNhapTK.Click += new System.EventHandler(this.btnDangNhapTK_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnQuanLyKH);
            this.tabPage2.Controls.Add(this.btnQuanLyNCC);
            this.tabPage2.Controls.Add(this.btnQuanLyMH);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyKH
            // 
            this.btnQuanLyKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyKH.Image = global::QuanLyBanHang.Properties.Resources.dsgiaovien1;
            this.btnQuanLyKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyKH.Location = new System.Drawing.Point(528, 6);
            this.btnQuanLyKH.Name = "btnQuanLyKH";
            this.btnQuanLyKH.Size = new System.Drawing.Size(109, 66);
            this.btnQuanLyKH.TabIndex = 5;
            this.btnQuanLyKH.Text = "Khách Hàng";
            this.btnQuanLyKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuanLyKH.UseVisualStyleBackColor = true;
            this.btnQuanLyKH.Click += new System.EventHandler(this.btnQuanLyKH_Click);
            // 
            // btnQuanLyNCC
            // 
            this.btnQuanLyNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyNCC.Image = global::QuanLyBanHang.Properties.Resources.nhacc;
            this.btnQuanLyNCC.Location = new System.Drawing.Point(293, 6);
            this.btnQuanLyNCC.Name = "btnQuanLyNCC";
            this.btnQuanLyNCC.Size = new System.Drawing.Size(102, 66);
            this.btnQuanLyNCC.TabIndex = 4;
            this.btnQuanLyNCC.Text = "Nhà Cung Cấp";
            this.btnQuanLyNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuanLyNCC.UseVisualStyleBackColor = true;
            this.btnQuanLyNCC.Click += new System.EventHandler(this.btnQuanLyNCC_Click);
            // 
            // btnQuanLyMH
            // 
            this.btnQuanLyMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyMH.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyMH.Image")));
            this.btnQuanLyMH.Location = new System.Drawing.Point(60, 6);
            this.btnQuanLyMH.Name = "btnQuanLyMH";
            this.btnQuanLyMH.Size = new System.Drawing.Size(102, 66);
            this.btnQuanLyMH.TabIndex = 3;
            this.btnQuanLyMH.Text = "Mặt Hàng";
            this.btnQuanLyMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuanLyMH.UseVisualStyleBackColor = true;
            this.btnQuanLyMH.Click += new System.EventHandler(this.btnQuanLyMH_Click);
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Location = new System.Drawing.Point(4, 24);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(960, 86);
            this.tabBaoCao.TabIndex = 2;
            this.tabBaoCao.Text = "Báo cáo";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnTroGiup);
            this.tabPage6.Controls.Add(this.btnThongTinSP);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(960, 86);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Trợ giúp";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("btnTroGiup.Image")));
            this.btnTroGiup.Location = new System.Drawing.Point(221, 11);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(102, 66);
            this.btnTroGiup.TabIndex = 3;
            this.btnTroGiup.Text = "Trợ giúp";
            this.btnTroGiup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTroGiup.UseVisualStyleBackColor = true;
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // btnThongTinSP
            // 
            this.btnThongTinSP.Image = global::QuanLyBanHang.Properties.Resources.thongtinphanmem;
            this.btnThongTinSP.Location = new System.Drawing.Point(24, 10);
            this.btnThongTinSP.Name = "btnThongTinSP";
            this.btnThongTinSP.Size = new System.Drawing.Size(102, 66);
            this.btnThongTinSP.TabIndex = 2;
            this.btnThongTinSP.Text = "Thông Tin Sản Phẩm";
            this.btnThongTinSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThongTinSP.UseVisualStyleBackColor = true;
            this.btnThongTinSP.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabQuanLy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 537);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabQuanLy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDangNhapTK;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDangKiTK;
        private System.Windows.Forms.Button btnQuanLyNCC;
        private System.Windows.Forms.Button btnQuanLyMH;
        private System.Windows.Forms.Button btnTroGiup;
        private System.Windows.Forms.Button btnThongTinSP;
        private System.Windows.Forms.Button btnQuanLyKH;
    }
}

