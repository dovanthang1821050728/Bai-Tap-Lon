namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DanhGia1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhGias",
                c => new
                    {
                        Sosao = c.Int(nullable: false, identity: true),
                        Danhgiachatluong = c.String(),
                        PhanHoiKhachHang = c.String(),
                    })
                .PrimaryKey(t => t.Sosao);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DanhGias");
        }
    }
}
