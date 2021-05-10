namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SanPham : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        SoLuongMua = c.Int(nullable: false),
                        NgayMua = c.Int(nullable: false),
                        Diachicuahang = c.String(),
                    })
                .PrimaryKey(t => t.MaSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
        }
    }
}
