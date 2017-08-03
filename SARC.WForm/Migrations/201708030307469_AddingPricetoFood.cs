namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPricetoFood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Price");
        }
    }
}
