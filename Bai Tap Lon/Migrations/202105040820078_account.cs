namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            DropTable("dbo.thongtinkhachhangs");
        }
        
        public override void Down()
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
            
            DropTable("dbo.TaiKhoans");
        }
    }
}
