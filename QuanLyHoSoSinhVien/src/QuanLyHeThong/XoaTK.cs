using QuanLyHoSoSinhVien.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src.QuanLyHeThong
{
    public partial class XoaTK : Form
    {
        private QLHSSV db = new QLHSSV();

        public XoaTK()
        {
            InitializeComponent();
        }

        //Start Xóa Click
        private void xoa_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string s = Properties.Settings.Default.tk;
                if (xtk_txt.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Không có tài khoản để xóa!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (xtk_txt.Text.Trim().Equals(s))
                {
                    MessageBox.Show("Không thể xóa tài khoản đang hoạt động!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    xtk_txt.Clear();
                }
            }
        }
        //End Xóa Click

        //Start XoaAcc Load
        private void XoaAcc_Load(object sender, EventArgs e)
        {
            var user = (from lg in db.TaiKhoans
                            select new { lg.MaTK, lg.UserName }
                         ).ToList();

            danhsach_dg.DataSource = user;
        }
        private void danhsach_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var vt = e.RowIndex;
            ////lấy dữ liệu trên dòng
            //string taikhoan = danhsach_dg.Rows[vt].Cells[0].Value.ToString();
            //xtk_txt.Text = taikhoan;
        }

        private void huybo2_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy không?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Hide();
                HeThong heThong = new HeThong();
                heThong.ShowDialog();
                Close();
            }
        }

        private void danhsach_dg_SelectionChanged(object sender, EventArgs e)
        {
            var dr = danhsach_dg.CurrentRow;

            xtk_txt.Text = dr.Cells["UserName"].Value.ToString();
        }
    }
}
