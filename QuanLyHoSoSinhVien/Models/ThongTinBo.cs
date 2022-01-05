namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinBo")]
    public partial class ThongTinBo
    {
        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [StringLength(30)]
        public string TenBo { get; set; }

        [StringLength(20)]
        public string NgheNghiepBo { get; set; }

        public DateTime NamSinhBo { get; set; }

        [StringLength(30)]
        public string QueQuanBo { get; set; }
    }
}
