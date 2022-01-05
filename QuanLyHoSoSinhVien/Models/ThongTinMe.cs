namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinMe")]
    public partial class ThongTinMe
    {
        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [StringLength(30)]
        public string TenMe { get; set; }

        [StringLength(20)]
        public string NgheNghiepMe { get; set; }

        public DateTime NamSinhMe { get; set; }

        [StringLength(30)]
        public string QueQuanMe { get; set; }
    }
}
