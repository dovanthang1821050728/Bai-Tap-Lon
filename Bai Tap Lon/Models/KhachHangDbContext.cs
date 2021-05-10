namespace Bai_Tap_Lon.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KhachHangDbContext : DbContext
    {
        public KhachHangDbContext()
            : base("name=KhachHangDbContext")
        {
        }
        public virtual DbSet <ThongTinKhachHang> ThongTinKhachHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<usder> usders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<Bai_Tap_Lon.Models.DanhMucSanPham> DanhMucSanPhams { get; set; }

        public System.Data.Entity.DbSet<Bai_Tap_Lon.Models.DanhGia> DanhGias { get; set; }

        public System.Data.Entity.DbSet<Bai_Tap_Lon.Models.ChiNhanhCuaHang> ChiNhanhCuaHangs { get; set; }

      //  public System.Data.Entity.DbSet<Bai_Tap_Lon.Models.TaiKhoan> TaiKhoans { get; set; }
    }
}
