namespace eMarket.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expireDateProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ExpireDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ExpireDate");
        }
    }
}
