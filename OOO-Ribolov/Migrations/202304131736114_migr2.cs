namespace OOO_Ribolov.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Catalog", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Catalog", "Image");
        }
    }
}
