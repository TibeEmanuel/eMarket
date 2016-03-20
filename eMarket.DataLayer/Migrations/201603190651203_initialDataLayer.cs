namespace eMarket.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDataLayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Announcements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PublishDate = c.DateTime(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        ProductCatagoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCatagoryId, cascadeDelete: true)
                .Index(t => t.ProductCatagoryId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProductCatagoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Announcements", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCatagoryId", "dbo.ProductCategories");
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductCatagoryId" });
            DropIndex("dbo.Announcements", new[] { "ProductId" });
            DropTable("dbo.Images");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Announcements");
        }
    }
}
