using QuanLyHoSoSinhVien.src.QuanLyHeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void qlsv_btn_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLySinhVien.QuanLySinhVien quanLySinhVien = new QuanLySinhVien.QuanLySinhVien();
            quanLySinhVien.ShowDialog();
            Close();
        }

        private void dangxuat_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Hide();
                DangNhap.DangNhap dn = new DangNhap.DangNhap();
                dn.ShowDialog();
                Close();
            }
        }

        private void qlht_btn_Click(object sender, EventArgs e)
        {
            Hide();
            HeThong heThong = new HeThong();
            heThong.ShowDialog();
            Close();
        }

        private void tk_btn_Click(object sender, EventArgs e)
        {
        }

        private void repost_Click(object sender, EventArgs e)
        {
        }
    }
}
