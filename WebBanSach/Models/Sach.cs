namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [Key]
        public int MaSach { get; set; }

        [StringLength(100)]
        public string TenSach { get; set; }

        [StringLength(200)]
        public string LoiDan { get; set; }

        public int? MaTacGia { get; set; }

        public int? TinhTrang { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        [StringLength(200)]
        public string Anh { get; set; }
    }
}
