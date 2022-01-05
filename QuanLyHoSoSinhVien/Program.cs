using QuanLyHoSoSinhVien.src;
using QuanLyHoSoSinhVien.src.DangNhap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoSinhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DangNhap dn = new DangNhap();
            Application.Run(dn);
            if (dn.DialogResult == DialogResult.OK)
            Application.Run(new TrangChu());
        }
    }
}
