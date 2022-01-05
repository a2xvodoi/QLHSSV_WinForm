namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            KhenThuongs = new HashSet<KhenThuong>();
            KyLuats = new HashSet<KyLuat>();
        }

        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(30)]
        public string TenSV { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(12)]
        public string CMT { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(15)]
        public string TonGiao { get; set; }

        [Required]
        [StringLength(15)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(15)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(20)]
        public string Que { get; set; }

        [Required]
        [StringLength(15)]
        public string TrinhDo { get; set; }

        [Required]
        [StringLength(10)]
        public string DanToc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoaHoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhenThuong> KhenThuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KyLuat> KyLuats { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
