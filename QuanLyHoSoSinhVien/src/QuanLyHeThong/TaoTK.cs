using QuanLyHoSoSinhVien.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src.QuanLyHeThong
{
    public partial class TaoTK : Form
    {
        private QLHSSV db = new QLHSSV();

        public TaoTK()
        {
            InitializeComponent();
        }

        private void tao_btn_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản bỏ trống
            if (ttk_txt.Text.Trim().Equals("") == false)
            {
                //So sánh dữ liệu với Database
                var user = db.TaiKhoans.ToList().FirstOrDefault(u => u.UserName.Trim() == ttk_txt.Text.Trim());
                if (user == null)
                {
                    //Kiểm tra mật khẩu bỏ trống
                    if (mk2_txt.Text.Trim().Equals("") == false)
                    {
                        //Kiểm tra mật khẩu trùng khớp
                        if (mk2_txt.Text.Trim().Equals(remk2_txt.Text.Trim()) == true)
                        {
                            user = new TaiKhoan() { UserName = ttk_txt.Text.Trim(), Password = mk2_txt.Text.Trim() };
                            db.TaiKhoans.Add(user);
                            try
                            {
                                db.SaveChanges();
                                mk2_txt.Clear();
                                remk2_txt.Clear();
                            }
                            catch
                            {
                                MessageBox.Show("Không thêm được tài khoản!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else //Nếu mật khẩu không khớp
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mk2_txt.Clear();
                            remk2_txt.Clear();
                        }
                    }
                    else //nếu mật khẩu bỏ trống
                        MessageBox.Show("Mật khẩu không được bỏ trống!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttk_txt.Clear();
                    mk2_txt.Clear();
                    remk2_txt.Clear();
                }
            }
            else //nếu tài khoản bỏ trống
                MessageBox.Show("Tài khoản không được bỏ trống!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void huy_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                HeThong heThong = new HeThong();
                heThong.ShowDialog();
                Close();
            }
        }
    }
}
