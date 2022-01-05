namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KyHoc")]
    public partial class KyHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KyHoc()
        {
            KhenThuongs = new HashSet<KhenThuong>();
            KyLuats = new HashSet<KyLuat>();
        }

        [Key]
        public int MaKy { get; set; }

        public int TenKy { get; set; }

        public int NamHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhenThuong> KhenThuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KyLuat> KyLuats { get; set; }
    }
}
