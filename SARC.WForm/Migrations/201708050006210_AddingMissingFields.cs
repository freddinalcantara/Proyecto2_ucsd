namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMissingFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comboes", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Comboes", new[] { "Order_Id" });
            CreateTable(
                "dbo.OrdenDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.ReservationStands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reservation_Id = c.Int(),
                        StandId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .ForeignKey("dbo.Stands", t => t.StandId_Id)
                .Index(t => t.Reservation_Id)
                .Index(t => t.StandId_Id);
            
            AddColumn("dbo.Orders", "Status", c => c.String());
            AddColumn("dbo.Orders", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "ReservationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "Status", c => c.String());
            DropColumn("dbo.Comboes", "Order_Id");
            DropColumn("dbo.Reservations", "StandId");
            DropColumn("dbo.Reservations", "InitDate");
            DropColumn("dbo.Reservations", "EndDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "EndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "InitDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "StandId", c => c.Int(nullable: false));
            AddColumn("dbo.Comboes", "Order_Id", c => c.Int());
            DropForeignKey("dbo.ReservationStands", "StandId_Id", "dbo.Stands");
            DropForeignKey("dbo.ReservationStands", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.OrdenDetails", "Order_Id", "dbo.Orders");
            DropIndex("dbo.ReservationStands", new[] { "StandId_Id" });
            DropIndex("dbo.ReservationStands", new[] { "Reservation_Id" });
            DropIndex("dbo.OrdenDetails", new[] { "Order_Id" });
            DropColumn("dbo.Reservations", "Status");
            DropColumn("dbo.Reservations", "CreatedAt");
            DropColumn("dbo.Reservations", "ReservationDate");
            DropColumn("dbo.Orders", "CreatedAt");
            DropColumn("dbo.Orders", "Status");
            DropTable("dbo.ReservationStands");
            DropTable("dbo.OrdenDetails");
            CreateIndex("dbo.Comboes", "Order_Id");
            AddForeignKey("dbo.Comboes", "Order_Id", "dbo.Orders", "Id");
        }
    }
}
