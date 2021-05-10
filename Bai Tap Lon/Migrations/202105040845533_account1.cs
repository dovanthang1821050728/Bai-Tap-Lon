namespace Bai_Tap_Lon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class account1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaiKhoans", "MatKhau", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaiKhoans", "MatKhau", c => c.String());
        }
    }
}
