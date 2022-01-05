namespace QuanLyHoSoSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        [Key]
        public int MaTK { get; set; }
    }
}
