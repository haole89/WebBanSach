namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        public int MaMenu { get; set; }

        [StringLength(50)]
        public string TenMenu { get; set; }

        [StringLength(200)]
        public string Link { get; set; }
    }
}
