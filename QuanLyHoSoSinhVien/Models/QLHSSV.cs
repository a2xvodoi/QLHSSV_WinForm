using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyHoSoSinhVien.Models
{
    public partial class QLHSSV : DbContext
    {
        public QLHSSV()
            : base("name=QLHSSV")
        {
        }

        public virtual DbSet<DienGiaDinh> DienGiaDinhs { get; set; }
        public virtual DbSet<KhenThuong> KhenThuongs { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<KyHoc> KyHocs { get; set; }
        public virtual DbSet<KyLuat> KyLuats { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongTinBo> ThongTinBoes { get; set; }
        public virtual DbSet<ThongTinMe> ThongTinMes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DienGiaDinh>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhenThuong>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.Lops)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.MaKhoaHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.NamBatDau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.NamKetThuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhoaHoc>()
                .HasMany(e => e.Lops)
                .WithRequired(e => e.KhoaHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KyHoc>()
                .HasMany(e => e.KhenThuongs)
                .WithRequired(e => e.KyHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KyHoc>()
                .HasMany(e => e.KyLuats)
                .WithRequired(e => e.KyHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KyLuat>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoaHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Lop)
                .HasForeignKey(e => new { e.MaKhoaHoc, e.MaKhoa, e.MaLop })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.CMT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaKhoaHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.KhenThuongs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.KyLuats)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinBo>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinMe>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
