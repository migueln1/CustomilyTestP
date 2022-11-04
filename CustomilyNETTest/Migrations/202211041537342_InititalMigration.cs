namespace CustomilyNETTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InititalMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                        X = c.String(),
                        Y = c.String(),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        ModifiedDate = c.DateTime(),
                        Page_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pages", t => t.Page_Id)
                .Index(t => t.Page_Id);
            
            CreateTable(
                "dbo.Texts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        X = c.String(),
                        Y = c.String(),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        ModifiedDate = c.DateTime(),
                        Page_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pages", t => t.Page_Id)
                .Index(t => t.Page_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Texts", "Page_Id", "dbo.Pages");
            DropForeignKey("dbo.Images", "Page_Id", "dbo.Pages");
            DropIndex("dbo.Texts", new[] { "Page_Id" });
            DropIndex("dbo.Images", new[] { "Page_Id" });
            DropTable("dbo.Texts");
            DropTable("dbo.Images");
            DropTable("dbo.Pages");
        }
    }
}
