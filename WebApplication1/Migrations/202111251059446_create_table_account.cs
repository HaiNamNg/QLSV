namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        MaHocPhan = c.String(nullable: false, maxLength: 20),
                        TenHocPhan = c.String(nullable: false, maxLength: 20),
                        SoTinChi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.MaHocPhan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HocPhans");
            DropTable("dbo.Accounts");
        }
    }
}
