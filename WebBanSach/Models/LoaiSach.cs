namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSach")]
    public partial class LoaiSach
    {
        [Key]
        public int MaLoai { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        [StringLength(200)]
        public string Link { get; set; }
    }
}
