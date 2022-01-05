using QuanLyHoSoSinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien.src.QuanLySinhVien
{
    public partial class QuanLySinhVien : Form
    {
        private QLHSSV db = new QLHSSV();

        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void thoat_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát??", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            Close();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            hienThiDanhSach();
            loadTree();
        }

        private void hienThiDanhSach()
        {
            var sv = (from s in db.SinhViens
                      select new { s.MaSV, s.TenSV, s.GioiTinh, s.NgaySinh, s.Que, s.QuocTich, s.DienThoai }
                        ).ToList();
            danhsachtong_dg.DataSource = sv;
        }

        private void loadTree()
        {
            createNodeRoot();
        }

        private void createNodeRoot()
        {
            trvKhoa.Nodes.Add("0", "Danh sách khoa");
            createNodeItems();
        }

        private void createNodeItems()
        {
            var tn = trvKhoa.Nodes.Find("0", true);
            var khoas = db.Khoas.AsNoTracking().ToList();

            khoas.ForEach(k =>
            {
                tn[0].Nodes.Add(k.MaKhoa, k.TenKhoa);
            });
        }

        private void trvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string nodeSelectedName = trvKhoa.SelectedNode.Name.Trim();
                string nodeSelectedText = trvKhoa.SelectedNode.Text.Trim();
                if (!nodeSelectedName.Equals("0"))
                {
                    Hide();
                    DanhSachSinhVien danhSachSinhVien = new DanhSachSinhVien(nodeSelectedName);
                    danhSachSinhVien.Text = nodeSelectedText;
                    danhSachSinhVien.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
                return;
            }
        }
    }
}
