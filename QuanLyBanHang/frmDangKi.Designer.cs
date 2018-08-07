namespace QuanLyBanHang
{
    partial class frmDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKi));
            this.lblQuyen = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMatKhai = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errDangKi = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDangKi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Nina", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(170, 202);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(43, 13);
            this.lblQuyen.TabIndex = 20;
            this.lblQuyen.Text = "Quyền:";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnHuyBo.Location = new System.Drawing.Point(313, 238);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(78, 46);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.Location = new System.Drawing.Point(126, 238);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 46);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Kí";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(292, 151);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(99, 21);
            this.txtNhapLaiMatKhau.TabIndex = 2;
            // 
            // lblNhapLaiMatKhai
            // 
            this.lblNhapLaiMatKhai.AutoSize = true;
            this.lblNhapLaiMatKhai.Font = new System.Drawing.Font("Nina", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMatKhai.Location = new System.Drawing.Point(170, 155);
            this.lblNhapLaiMatKhai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapLaiMatKhai.Name = "lblNhapLaiMatKhai";
            this.lblNhapLaiMatKhai.Size = new System.Drawing.Size(105, 13);
            this.lblNhapLaiMatKhai.TabIndex = 16;
            this.lblNhapLaiMatKhai.Text = "Nhập lại Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(292, 101);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(99, 21);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nina", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(292, 57);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(99, 21);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nina", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tài Khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // errDangKi
            // 
            this.errDangKi.ContainerControl = this;
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Guest"});
            this.cboQuyen.Location = new System.Drawing.Point(292, 195);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(99, 21);
            this.cboQuyen.TabIndex = 3;
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 321);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.lblNhapLaiMatKhai);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí Tài Khoản";
            this.Load += new System.EventHandler(this.frmDangKi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDangKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label lblNhapLaiMatKhai;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errDangKi;
        private System.Windows.Forms.ComboBox cboQuyen;
    }
}