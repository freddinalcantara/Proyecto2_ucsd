namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingLocationAndSeatsTotand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stands", "StandNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Stands", "Location", c => c.String());
            AddColumn("dbo.Stands", "seats", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stands", "seats");
            DropColumn("dbo.Stands", "Location");
            DropColumn("dbo.Stands", "StandNumber");
        }
    }
}
