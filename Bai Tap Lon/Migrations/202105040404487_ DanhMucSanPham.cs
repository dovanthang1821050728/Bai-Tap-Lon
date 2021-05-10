namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DanhMucSanPham : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhMucSanPhams",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        Tongsoluongbandau = c.Int(nullable: false),
                        SoLuongDaBan = c.Int(nullable: false),
                        SoLuongConLai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DanhMucSanPhams");
        }
    }
}
