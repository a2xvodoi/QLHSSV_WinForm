using System;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src.QuanLyHeThong
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
        }

        private void taottk_btn_Click(object sender, EventArgs e)
        {
            Close();
            TaoTK taoTK = new TaoTK();
            taoTK.ShowDialog();
            Hide();
        }

        private void xoatk_btn_Click(object sender, EventArgs e)
        {
            Close();
            XoaTK xoaTK = new XoaTK();
            xoaTK.ShowDialog();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            Close();
        }
    }
}
