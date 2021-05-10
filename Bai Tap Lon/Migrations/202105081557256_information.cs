namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class information : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThongTinKhachHangs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(),
                        DiaChi = c.String(),
                        SoDienThoai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThongTinKhachHangs");
        }
    }
}
