namespace WebBanSach.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BanSachDBContext : DbContext
    {
        public BanSachDBContext()
            : base("name=BanSachDBContext")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Sach_LoaiSach> Sach_LoaiSach { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
