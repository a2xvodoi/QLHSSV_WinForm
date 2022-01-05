using QuanLyHoSoSinhVien.Models;
using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLyHoSoSinhVien.src.QuanLySinhVien
{
    public partial class DanhSachSinhVien : Form
    {
        private string maKhoa;
        private QLHSSV db = new QLHSSV();

        public DanhSachSinhVien()
        {
            InitializeComponent();
        }
        public DanhSachSinhVien(string maKhoa)
        {
            this.maKhoa = maKhoa;
            InitializeComponent();
        }

        private void thoat_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            quanLySinhVien.ShowDialog();
            Close();
        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            khoiTaoKhoaHoc();
            khoiTaoLop();

            hienThiDanhSach();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            Hide();
            ThemSinhVien themSV = new ThemSinhVien(maKhoa);
            themSV.ShowDialog();
            Close();
        }

        private void khoiTaoKhoaHoc()
        {
            cbKhoaHoc.SelectedValue = "";
            db.KhoaHocs.Load();
            cbKhoaHoc.DataSource = db.KhoaHocs.Local;
            cbKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void khoiTaoLop()
        {
            cbLopHoc.SelectedValue = "";
            var khoaHoc = cbKhoaHoc.SelectedValue.ToString().Trim();
            cbLopHoc.DataSource = db.Lops.Where(k => k.MaKhoaHoc == khoaHoc && k.MaKhoa == maKhoa).ToList();
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            khoiTaoLop();
        }

        private void chitiet_btn_Click(object sender, EventArgs e)
        {
            var dr = danhsach_dg.CurrentRow;
            if (dr == null)
            {
                MessageBox.Show("Chọn một sinh viên để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maSV = dr.Cells["MaSV"].Value.ToString();
                Hide();
                ChiTietSV chiTietSV = new ChiTietSV(maKhoa, maSV);
                chiTietSV.ShowDialog();
                Close();
            }
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            var dr = danhsach_dg.CurrentRow;
            if (dr == null)
            {
                MessageBox.Show("Chọn một sinh viên để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maSV = dr.Cells["MaSV"].Value.ToString();
                var rs = MessageBox.Show("Bạn có chắc muốn xoá sinh viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    var sv = db.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
                    var dienGiaDinh = db.DienGiaDinhs.FirstOrDefault(s => s.MaSV == maSV);
                    var thongTinBo = db.ThongTinBoes.FirstOrDefault(s => s.MaSV == maSV);
                    var thongTinMe = db.ThongTinMes.FirstOrDefault(s => s.MaSV == maSV);
                    db.SinhViens.Remove(sv);
                    if (dienGiaDinh != null)
                    {
                        db.DienGiaDinhs.Remove(dienGiaDinh);
                    }
                    if (thongTinBo != null)
                    {
                        db.ThongTinBoes.Remove(thongTinBo);
                    }
                    if (thongTinMe != null)
                    {
                        db.ThongTinMes.Remove(thongTinMe);
                    }
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Xoá sinh viên thành công!");
                        hienThiDanhSach();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Không xoá được sinh viên!");
                        throw;
                    }
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhoaHoc = cbKhoaHoc.SelectedValue.ToString().Trim();
                string maLop = cbLopHoc.SelectedValue.ToString().Trim();

                hienThiDanhSach(maKhoaHoc, maLop);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void hienThiDanhSach()
        {
            var sv = (from s in db.SinhViens
                      join k in db.Khoas on s.MaKhoa equals k.MaKhoa
                      where s.MaKhoa == maKhoa
                      select new { s.MaSV, s.TenSV, s.GioiTinh, s.NgaySinh, s.Que, s.QuocTich, s.DienThoai }
                        ).ToList();
            danhsach_dg.DataSource = sv;
        }

        private void hienThiDanhSach(string maKhoaHoc, string maLop)
        {
            var sv = (from s in db.SinhViens
                      join k in db.Khoas on s.MaKhoa equals k.MaKhoa
                      where s.MaKhoa == maKhoa
                      where s.MaKhoaHoc == maKhoaHoc
                      where s.MaLop == maLop
                      select new { s.MaSV, s.TenSV, s.GioiTinh, s.NgaySinh, s.Que, s.QuocTich, s.DienThoai }
                        ).ToList();
            danhsach_dg.DataSource = sv;
        }
    }
}
