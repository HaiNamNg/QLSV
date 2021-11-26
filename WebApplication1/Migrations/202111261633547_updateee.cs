namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lops", "MaKhoa", c => c.String(maxLength: 20));
            CreateIndex("dbo.Lops", "MaKhoa");
            AddForeignKey("dbo.Lops", "MaKhoa", "dbo.Khoas", "MaKhoa");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lops", "MaKhoa", "dbo.Khoas");
            DropIndex("dbo.Lops", new[] { "MaKhoa" });
            DropColumn("dbo.Lops", "MaKhoa");
        }
    }
}
