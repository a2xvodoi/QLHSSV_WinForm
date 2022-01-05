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
    public partial class ThemSinhVien : Form
    {
        private QLHSSV db = new QLHSSV();
        private string maKhoa;
        
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        public ThemSinhVien(string maKhoa)
        {
            this.maKhoa = maKhoa;
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            DanhSachSinhVien danhSachSinhVien = new DanhSachSinhVien(maKhoa);
            danhSachSinhVien.ShowDialog();
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sv = db.SinhViens.FirstOrDefault(s => s.MaSV == msv_txt.Text);
            if (sv == null)
            {
                sv = new SinhVien()
                {
                    MaSV = msv_txt.Text,
                    TenSV = ten_txt.Text,
                    GioiTinh = rdNam.Checked ? true : false,
                    NgaySinh = ngaysinh_date.Value,
                    CMT = cmt_txt.Text,
                    DienThoai = dienthoai_txt.Text,
                    QuocTich = quoctich_txt.Text,
                    Que = que_txt.Text,
                    DanToc = dantoc_txt.Text,
                    TonGiao = tongiao_txt.Text,
                    TrinhDo = trinhdo_txt.Text,
                    MaKhoa = maKhoa,
                    MaKhoaHoc = cbKhoaHoc.SelectedValue.ToString(),
                    MaLop = cbLopHoc.SelectedValue.ToString(),
                };
                db.SinhViens.Add(sv);

                var thongTinBo = new ThongTinBo()
                {
                    MaSV = msv_txt.Text,
                    TenBo = tenbo_txt.Text ?? null,
                    NgheNghiepBo = nghenghiepbo_txt.Text ?? null,
                    NamSinhBo = ngaybo_dtp.Value,
                    QueQuanBo = quebo_txt.Text ?? null,
                };
                db.ThongTinBoes.Add(thongTinBo);

                var thongTinMe = new ThongTinMe()
                {
                    MaSV = msv_txt.Text,
                    TenMe = Tenme_txt.Text ?? null,
                    NgheNghiepMe = nghenghiepme_txt.Text ?? null,
                    NamSinhMe = ngayme_dtp.Value,
                    QueQuanMe = queme_txt.Text ?? "",
                };
                db.ThongTinMes.Add(thongTinMe);

                var dienGiaDinh = new DienGiaDinh()
                {
                    MaSV = msv_txt.Text,
                    TBLS = rdTBLST.Checked ? true : false,
                    HoNgheo = rdHNT.Checked ? true : false
                };
                db.DienGiaDinhs.Add(dienGiaDinh);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thêm sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Không thêm được sinh viên!!");
                    return;

                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            khoa_txt.Enabled = false;
            khoa_txt.Text = getNameKhoaByMaKhoa(maKhoa);
            getKhoaKhoc();
            getLopHoc();
        }

        private string getNameKhoaByMaKhoa(string maKhoa)
        {

            return db.Khoas.FirstOrDefault(k => k.MaKhoa == maKhoa).TenKhoa;
        }

        private void getKhoaKhoc()
        {
            cbKhoaHoc.SelectedValue = "";
            db.KhoaHocs.Load();
            cbKhoaHoc.DataSource = db.KhoaHocs.Local;
            cbKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void getLopHoc()
        {
            cbLopHoc.SelectedValue = "";
            var khoaHoc = cbKhoaHoc.SelectedValue.ToString().Trim();
            cbLopHoc.DataSource = db.Lops.Where(k => k.MaKhoaHoc == khoaHoc && k.MaKhoa == maKhoa).ToList();
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLopHoc();
        }

        private void clearText()
        {
            msv_txt.Text = "";
            ten_txt.Text = "";
            cmt_txt.Text = "";
            dienthoai_txt.Text = "";
            quoctich_txt.Text = "";
            que_txt.Text = "";
            dantoc_txt.Text = "";
            tongiao_txt.Text = "";
            trinhdo_txt.Text = "";
            tenbo_txt.Text = "";
            nghenghiepbo_txt.Text = "";
            quebo_txt.Text = "";
            Tenme_txt.Text = "";
            nghenghiepme_txt.Text = "";
            queme_txt.Text = "";
        }
    } 
}
