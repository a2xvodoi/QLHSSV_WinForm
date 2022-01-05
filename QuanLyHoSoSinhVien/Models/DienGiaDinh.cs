namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienGiaDinh")]
    public partial class DienGiaDinh
    {
        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        public bool HoNgheo { get; set; }

        public bool TBLS { get; set; }
    }
}
