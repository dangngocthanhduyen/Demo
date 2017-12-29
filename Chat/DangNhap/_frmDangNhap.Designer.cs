namespace DangNhap
{
    partial class _frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmDangNhap));
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._llblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this._spbtnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this._lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this._spbtnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this._lblDangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtEmail
            // 
            this._txtEmail.BackColor = System.Drawing.Color.White;
            this._txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmail.ForeColor = System.Drawing.Color.Gray;
            this._txtEmail.Location = new System.Drawing.Point(41, 154);
            this._txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtEmail.Multiline = true;
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(281, 44);
            this._txtEmail.TabIndex = 2;
            this._txtEmail.Text = "Nhập Email";
            this._txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtPassword
            // 
            this._txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.ForeColor = System.Drawing.Color.Gray;
            this._txtPassword.Location = new System.Drawing.Point(41, 218);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtPassword.Multiline = true;
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(281, 44);
            this._txtPassword.TabIndex = 3;
            this._txtPassword.Text = "Nhập Password";
            this._txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _llblQuenMatKhau
            // 
            this._llblQuenMatKhau.AutoSize = true;
            this._llblQuenMatKhau.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._llblQuenMatKhau.Location = new System.Drawing.Point(118, 274);
            this._llblQuenMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._llblQuenMatKhau.Name = "_llblQuenMatKhau";
            this._llblQuenMatKhau.Size = new System.Drawing.Size(136, 23);
            this._llblQuenMatKhau.TabIndex = 4;
            this._llblQuenMatKhau.TabStop = true;
            this._llblQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // _spbtnDangNhap
            // 
            this._spbtnDangNhap.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnDangNhap.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnDangNhap.Appearance.Options.UseFont = true;
            this._spbtnDangNhap.Appearance.Options.UseForeColor = true;
            this._spbtnDangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnDangNhap.Location = new System.Drawing.Point(41, 316);
            this._spbtnDangNhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnDangNhap.Name = "_spbtnDangNhap";
            this._spbtnDangNhap.Size = new System.Drawing.Size(281, 44);
            this._spbtnDangNhap.TabIndex = 5;
            this._spbtnDangNhap.Text = "Đăng Nhập";
            // 
            // _lblChuaCoTaiKhoan
            // 
            this._lblChuaCoTaiKhoan.AutoSize = true;
            this._lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblChuaCoTaiKhoan.Location = new System.Drawing.Point(118, 372);
            this._lblChuaCoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblChuaCoTaiKhoan.Name = "_lblChuaCoTaiKhoan";
            this._lblChuaCoTaiKhoan.Size = new System.Drawing.Size(155, 23);
            this._lblChuaCoTaiKhoan.TabIndex = 6;
            this._lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            // 
            // _spbtnDangKy
            // 
            this._spbtnDangKy.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnDangKy.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnDangKy.Appearance.Options.UseFont = true;
            this._spbtnDangKy.Appearance.Options.UseForeColor = true;
            this._spbtnDangKy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnDangKy.Location = new System.Drawing.Point(41, 408);
            this._spbtnDangKy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnDangKy.Name = "_spbtnDangKy";
            this._spbtnDangKy.Size = new System.Drawing.Size(281, 44);
            this._spbtnDangKy.TabIndex = 7;
            this._spbtnDangKy.Text = "Đăng Ký";
            this._spbtnDangKy.Click += new System.EventHandler(this._spbtnDangKy_Click);
            // 
            // _lblDangNhap
            // 
            this._lblDangNhap.AutoSize = true;
            this._lblDangNhap.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._lblDangNhap.ForeColor = System.Drawing.Color.Black;
            this._lblDangNhap.Location = new System.Drawing.Point(110, 96);
            this._lblDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblDangNhap.Name = "_lblDangNhap";
            this._lblDangNhap.Size = new System.Drawing.Size(163, 40);
            this._lblDangNhap.TabIndex = 8;
            this._lblDangNhap.Text = "Đăng Nhập";
            // 
            // _frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this._lblDangNhap);
            this.Controls.Add(this._spbtnDangKy);
            this.Controls.Add(this._lblChuaCoTaiKhoan);
            this.Controls.Add(this._spbtnDangNhap);
            this.Controls.Add(this._llblQuenMatKhau);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtEmail);
            this.Font = new System.Drawing.Font("FontAwesome", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "_frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.LinkLabel _llblQuenMatKhau;
        private DevExpress.XtraEditors.SimpleButton _spbtnDangNhap;
        private System.Windows.Forms.Label _lblChuaCoTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton _spbtnDangKy;
        private System.Windows.Forms.Label _lblDangNhap;
    }
}

