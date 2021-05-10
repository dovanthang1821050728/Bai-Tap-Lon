namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thongtinkhachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.thongtinkhachhangs",
                c => new
                    {
                        makhachhang = c.Int(nullable: false, identity: true),
                        hovatenkhachhang = c.String(),
                        sodienthoaikhachhang = c.Int(nullable: false),
                        diachikhachhang = c.String(),
                    })
                .PrimaryKey(t => t.makhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.thongtinkhachhangs");
        }
    }
}
