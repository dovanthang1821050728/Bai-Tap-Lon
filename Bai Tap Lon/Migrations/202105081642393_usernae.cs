namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usernae : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.usders");
            AddColumn("dbo.usders", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.usders", "TenDangNhap", c => c.String(nullable: false));
            AddPrimaryKey("dbo.usders", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.usders");
            AlterColumn("dbo.usders", "TenDangNhap", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.usders", "ID");
            AddPrimaryKey("dbo.usders", "TenDangNhap");
        }
    }
}
