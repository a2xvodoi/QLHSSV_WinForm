namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKhoaHoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }

        public virtual Khoa Khoa { get; set; }

        public virtual KhoaHoc KhoaHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
