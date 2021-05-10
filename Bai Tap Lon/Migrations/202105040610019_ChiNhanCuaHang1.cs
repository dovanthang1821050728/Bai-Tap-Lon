namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChiNhanCuaHang1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiNhanhCuaHang",
                c => new
                    {
                        MaCuaHang = c.Int(nullable: false, identity: true),
                        TenCuaHang = c.String(),
                        Tonghangtrongkho = c.Int(nullable: false),
                        SoLuongDaBan = c.Int(nullable: false),
                        SoLuongConLai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaCuaHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChiNhanhCuaHang");
        }
    }
}
