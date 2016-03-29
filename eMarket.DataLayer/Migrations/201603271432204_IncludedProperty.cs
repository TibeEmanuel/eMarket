namespace eMarket.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludedProperty : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Images", "ProductId");
            AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductId" });
        }
    }
}
