using QuanLyHoSoSinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src.QuanLySinhVien
{
    public partial class ChiTietSV : Form
    {
        private QLHSSV db = new QLHSSV();
        private string maKhoa;
        private string maSV;
        private bool isEdit;
        private SinhVien sv;
        private DienGiaDinh dienGiaDinh;
        private ThongTinBo thongTinBo;
        private ThongTinMe thongTinMe;

        public ChiTietSV()
        {
            InitializeComponent();
            
        }
        public ChiTietSV(string maKhoa, string maSV)
        {
            InitializeComponent();
            this.maKhoa = maKhoa;
            this.maSV = maSV;
        }
        public ChiTietSV(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }
        private void ChiTiet_Load(object sender, EventArgs e)
        {
            isEdit = false;
            sv = db.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
            dienGiaDinh = db.DienGiaDinhs.FirstOrDefault(s => s.MaSV == maSV);
            thongTinBo = db.ThongTinBoes.FirstOrDefault(s => s.MaSV == maSV);
            thongTinMe = db.ThongTinMes.FirstOrDefault(s => s.MaSV == maSV);
            setStatusForm();
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien danhSachSinhVien;
            if (isEdit)
            {
                var rs = MessageBox.Show("Dữ liệu chưa được cập nhật bạn có chắc muốn rời khỏi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }
            }
            Hide();
            if (string.IsNullOrEmpty(maKhoa))
            {
                danhSachSinhVien = new DanhSachSinhVien();
            }
            else
            {
                danhSachSinhVien = new DanhSachSinhVien(maKhoa);
            }
            danhSachSinhVien.ShowDialog();
            Close();
        }

        private void setStatusForm()
        {
            msv_txt.Enabled = false;
            tensv_txt.Enabled = isEdit;
            ngaysv_dtp.Enabled = isEdit;
            nam_rd.Enabled = isEdit;
            nu_rd.Enabled = isEdit;
            cmt_txt.Enabled = isEdit;
            dienthoai_txt.Enabled = isEdit;
            que_txt.Enabled = isEdit;
            quoctich_txt.Enabled = isEdit;
            dantoc_txt.Enabled = isEdit;
            tongiao_txt.Enabled = isEdit;
            trinhdo_txt.Enabled = isEdit;
            khoa_txt.Enabled = false;
            cbKhoaHoc.Enabled = isEdit;
            cbLopHoc.Enabled = isEdit;
            hongheo_co.Enabled = isEdit;
            hongheo_khong.Enabled = isEdit;
            tbls_co.Enabled = isEdit;
            tbls_khong.Enabled = isEdit;
            tenbo_txt.Enabled = isEdit;
            ngaybo_dtp.Enabled = isEdit;
            nghebo_txt.Enabled = isEdit;
            quebo_txt.Enabled = isEdit;
            tenme_txt.Enabled = isEdit;
            ngayme_dtp.Enabled = isEdit;
            ngheme_txt.Enabled = isEdit;
            queme_txt.Enabled = isEdit;
            luu_btn.Enabled = isEdit;
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;
            setStatusForm();
        }

        private void luu_btn_Click(object sender, EventArgs e)
        {
            updateSV();
            updateDienGiaDinh();
            updateThongTinBo();
            updateThongTinMe();

            try
            {
                db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công!");
                isEdit = false;
                setStatusForm();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra! Không cập nhật được sinh viên!");
                return;
            }
        }

        private void khoiTaoKhoaHoc()
        {
            cbKhoaHoc.SelectedText = "";
            db.KhoaHocs.Load();
            cbKhoaHoc.DataSource = db.KhoaHocs.Local;
            cbKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void khoiTaoLop()
        {
            //cbLopHoc.SelectedText = "";
            //var khoaHoc = cbKhoaHoc.SelectedValue.ToString().Trim();
            //cbLopHoc.DataSource = db.Lops.Where(k => k.MaKhoaHoc == khoaHoc && k.MaKhoa == maKhoa).ToList();
            //cbLopHoc.DisplayMember = "TenLop";
            //cbLopHoc.ValueMember = "MaLop";
        }

        private void loadData()
        {
            khoiTaoKhoaHoc();
            khoiTaoLop();

            loadSV();
            loadDienGiaDinh();
            loadThongTinBo();
            loadThongTinMe();
        }

        private void loadSV()
        {
            if (sv != null)
            {
                msv_txt.Text = sv.MaSV;
                tensv_txt.Text = sv.TenSV;
                ngaysv_dtp.Value = sv.NgaySinh;
                if (sv.GioiTinh)
                {
                    nam_rd.Checked = true;
                }
                else
                {
                    nu_rd.Checked = true;
                }
                cmt_txt.Text = sv.CMT;
                dienthoai_txt.Text = sv.DienThoai;
                que_txt.Text = sv.Que;
                quoctich_txt.Text = sv.QuocTich;
                dantoc_txt.Text = sv.DanToc;
                tongiao_txt.Text = sv.TonGiao;
                trinhdo_txt.Text = sv.TrinhDo;
                khoa_txt.Text = sv.MaKhoa;

                //cbKhoaHoc.SelectedItem = sv.MaKhoaHoc;
                cbKhoaHoc.SelectedValue = sv.TenSV;
                string tenLop = db.Lops.FirstOrDefault(l => l.MaKhoaHoc == sv.MaKhoaHoc && l.MaKhoa == sv.MaKhoa).TenLop;
                //cbLopHoc.SelectedItem = sv.MaLop;
                cbLopHoc.SelectedValue = tenLop;
            }
        }

        private void loadDienGiaDinh()
        {
            if (dienGiaDinh != null)
            {
                if (dienGiaDinh.HoNgheo)
                {
                    hongheo_co.Checked = true;
                }
                else
                {
                    hongheo_khong.Checked = true;
                }
                if (dienGiaDinh.TBLS)
                {
                    tbls_co.Checked = true;
                }
                else
                {
                    tbls_khong.Checked = true;
                }
            }
        }

        private void loadThongTinBo()
        {
            if (thongTinBo != null)
            {
                tenbo_txt.Text = thongTinBo.TenBo;
                ngaybo_dtp.Value = thongTinBo.NamSinhBo;
                nghebo_txt.Text = thongTinBo.NgheNghiepBo;
                quebo_txt.Text = thongTinBo.QueQuanBo;
            }
        }

        private void loadThongTinMe()
        {
            if (thongTinMe != null)
            {
                tenme_txt.Text = thongTinMe.TenMe;
                ngayme_dtp.Value = thongTinMe.NamSinhMe;
                ngheme_txt.Text = thongTinMe.NgheNghiepMe;
                queme_txt.Text = thongTinMe.QueQuanMe;
            }
        }

        private void updateSV()
        {
            if (sv != null)
            {
                sv.TenSV = tensv_txt.Text;
                sv.NgaySinh = ngaysv_dtp.Value;
                sv.GioiTinh = nam_rd.Checked ? true : false;
                sv.CMT = cmt_txt.Text;
                sv.DienThoai = dienthoai_txt.Text;
                sv.Que = que_txt.Text;
                sv.TonGiao = tongiao_txt.Text;
                sv.TrinhDo = trinhdo_txt.Text;
            }
        }

        private void updateDienGiaDinh()
        {
            if (dienGiaDinh != null)
            {
                dienGiaDinh.TBLS = tbls_co.Checked ? true : false;
                dienGiaDinh.HoNgheo = hongheo_co.Checked ? true : false;
            }
        }

        private void updateThongTinBo()
        {
            if (thongTinBo != null)
            {
                thongTinBo.TenBo = tenbo_txt.Text;
                thongTinBo.NamSinhBo = ngaybo_dtp.Value;
                thongTinBo.NgheNghiepBo = nghebo_txt.Text;
                thongTinBo.QueQuanBo = quebo_txt.Text;
            }
        }

        private void updateThongTinMe()
        {
            if (thongTinMe != null)
            {
                thongTinMe.TenMe = tenme_txt.Text;
                thongTinMe.NamSinhMe = ngayme_dtp.Value;
                thongTinMe.NgheNghiepMe = ngayme_dtp.Text;
                thongTinMe.QueQuanMe = queme_txt.Text;
            }
        }
    }
}
