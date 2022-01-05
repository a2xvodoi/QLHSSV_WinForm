using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src.TimKiem
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void thoat_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }
    }
}
