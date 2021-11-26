namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tarano1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Lops");
            AddColumn("dbo.Lops", "TenLop", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Lops", "MaLop", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.Lops", "TenLop");
            DropColumn("dbo.Lops", "MaHocPhan");
            DropColumn("dbo.Lops", "TenHocPhan");
            DropColumn("dbo.Lops", "SoTinChi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lops", "SoTinChi", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Lops", "TenHocPhan", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Lops", "MaHocPhan", c => c.String(nullable: false, maxLength: 20));
            DropPrimaryKey("dbo.Lops");
            DropColumn("dbo.Lops", "MaLop");
            DropColumn("dbo.Lops", "TenLop");
            AddPrimaryKey("dbo.Lops", "MaHocPhan");
        }
    }
}
