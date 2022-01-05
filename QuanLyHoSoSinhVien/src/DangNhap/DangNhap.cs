using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyHoSoSinhVien.Models;

namespace QuanLyHoSoSinhVien.src.DangNhap
{
    public partial class DangNhap : Form
    {
        private QLHSSV db = new QLHSSV();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tk.Length > 0)
            {
                remember.Checked = true;
            }
            //Hiển thị tài khỏan đã nhớ
            tk_txt.Text = Properties.Settings.Default.tk.Trim();
            //Hiern thị mật khẩu đã nhớ
            mk_txt.Text = Properties.Settings.Default.pass.Trim();
        }

        //Click đăng nhập
        private void dangnhap_btn_Click(object sender, EventArgs e)
        {
            var user = db.TaiKhoans.ToList().FirstOrDefault(u => u.UserName.Trim() == tk_txt.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Người sử dụng không tồn tại");
            }
            else
                if (user.Password.Trim() != mk_txt.Text.Trim())
                MessageBox.Show("Sai mật khẩu");
            else
            {
                DialogResult = DialogResult.OK;
                rememberUser();
                Close();
            }
        }

        //Hiên mật khẩu
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
                mk_txt.UseSystemPasswordChar = false;
            else
                mk_txt.UseSystemPasswordChar = true;
        }

        private void rememberUser()
        {
            if (remember.Checked)
            {
                Properties.Settings.Default.tk = tk_txt.Text.Trim();
                Properties.Settings.Default.pass = mk_txt.Text.Trim();
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();
            }

        }

        private void thoat_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
