namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KyLuat")]
    public partial class KyLuat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKy { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Column("KyLuat")]
        public bool KyLuat1 { get; set; }

        [Required]
        [StringLength(50)]
        public string MucKyLuat { get; set; }

        public virtual KyHoc KyHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
