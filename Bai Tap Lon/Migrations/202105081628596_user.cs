namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.usders",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.usders");
        }
    }
}
