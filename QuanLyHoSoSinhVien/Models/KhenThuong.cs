namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhenThuong")]
    public partial class KhenThuong
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKy { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSV { get; set; }

        public bool HocBong { get; set; }

        public virtual KyHoc KyHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
