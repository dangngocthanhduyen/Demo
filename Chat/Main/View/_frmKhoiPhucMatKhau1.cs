using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Main.View
{
    public partial class _frmKhoiPhucMatKhau1 : DevExpress.XtraEditors.XtraForm
    {
        private LinkLabel _llblGuiLaiMaXacNhan;
        private SimpleButton _spbtnXacNhan;
        private TextBox _txtNhapMaXacNhan;
        private Label _lblMaXacNhan;
        private Label _lblKhoiPhucMatKhau;

        public _frmKhoiPhucMatKhau1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmKhoiPhucMatKhau1));
            this._llblGuiLaiMaXacNhan = new System.Windows.Forms.LinkLabel();
            this._spbtnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this._txtNhapMaXacNhan = new System.Windows.Forms.TextBox();
            this._lblMaXacNhan = new System.Windows.Forms.Label();
            this._lblKhoiPhucMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _llblGuiLaiMaXacNhan
            // 
            this._llblGuiLaiMaXacNhan.AutoSize = true;
            this._llblGuiLaiMaXacNhan.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._llblGuiLaiMaXacNhan.Location = new System.Drawing.Point(106, 422);
            this._llblGuiLaiMaXacNhan.Name = "_llblGuiLaiMaXacNhan";
            this._llblGuiLaiMaXacNhan.Size = new System.Drawing.Size(163, 23);
            this._llblGuiLaiMaXacNhan.TabIndex = 21;
            this._llblGuiLaiMaXacNhan.TabStop = true;
            this._llblGuiLaiMaXacNhan.Text = "Gửi lại Mã Xác Nhận";
            this._llblGuiLaiMaXacNhan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._llblGuiLaiMaXacNhan_LinkClicked);
            // 
            // _spbtnXacNhan
            // 
            this._spbtnXacNhan.Appearance.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spbtnXacNhan.Appearance.ForeColor = System.Drawing.Color.Black;
            this._spbtnXacNhan.Appearance.Options.UseFont = true;
            this._spbtnXacNhan.Appearance.Options.UseForeColor = true;
            this._spbtnXacNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this._spbtnXacNhan.Location = new System.Drawing.Point(45, 348);
            this._spbtnXacNhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._spbtnXacNhan.Name = "_spbtnXacNhan";
            this._spbtnXacNhan.Size = new System.Drawing.Size(281, 44);
            this._spbtnXacNhan.TabIndex = 20;
            this._spbtnXacNhan.Text = "Xác Nhận";
            // 
            // _txtNhapMaXacNhan
            // 
            this._txtNhapMaXacNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtNhapMaXacNhan.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNhapMaXacNhan.ForeColor = System.Drawing.Color.Gray;
            this._txtNhapMaXacNhan.Location = new System.Drawing.Point(45, 272);
            this._txtNhapMaXacNhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._txtNhapMaXacNhan.Multiline = true;
            this._txtNhapMaXacNhan.Name = "_txtNhapMaXacNhan";
            this._txtNhapMaXacNhan.Size = new System.Drawing.Size(281, 44);
            this._txtNhapMaXacNhan.TabIndex = 19;
            this._txtNhapMaXacNhan.Text = "Nhập Mã Xác Nhận";
            this._txtNhapMaXacNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _lblMaXacNhan
            // 
            this._lblMaXacNhan.AutoSize = true;
            this._lblMaXacNhan.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMaXacNhan.Location = new System.Drawing.Point(134, 222);
            this._lblMaXacNhan.Name = "_lblMaXacNhan";
            this._lblMaXacNhan.Size = new System.Drawing.Size(107, 23);
            this._lblMaXacNhan.TabIndex = 18;
            this._lblMaXacNhan.Text = "Mã xác nhận";
            // 
            // _lblKhoiPhucMatKhau
            // 
            this._lblKhoiPhucMatKhau.AutoSize = true;
            this._lblKhoiPhucMatKhau.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._lblKhoiPhucMatKhau.ForeColor = System.Drawing.Color.Black;
            this._lblKhoiPhucMatKhau.Location = new System.Drawing.Point(38, 165);
            this._lblKhoiPhucMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblKhoiPhucMatKhau.Name = "_lblKhoiPhucMatKhau";
            this._lblKhoiPhucMatKhau.Size = new System.Drawing.Size(283, 40);
            this._lblKhoiPhucMatKhau.TabIndex = 17;
            this._lblKhoiPhucMatKhau.Text = "Khôi Phục Mật Khẩu";
            // 
            // _frmKhoiPhucMatKhau1
            // 
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this._llblGuiLaiMaXacNhan);
            this.Controls.Add(this._spbtnXacNhan);
            this.Controls.Add(this._txtNhapMaXacNhan);
            this.Controls.Add(this._lblMaXacNhan);
            this.Controls.Add(this._lblKhoiPhucMatKhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "_frmKhoiPhucMatKhau1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi Phục Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _llblGuiLaiMaXacNhan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new _frmKhoiPhucMatKhau();
            frm.ShowDialog();
        }
    }
}