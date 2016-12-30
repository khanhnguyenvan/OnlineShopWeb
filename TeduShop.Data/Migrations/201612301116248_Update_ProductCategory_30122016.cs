namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_ProductCategory_30122016 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.ProductCategories", "Description", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "Description", c => c.String());
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
