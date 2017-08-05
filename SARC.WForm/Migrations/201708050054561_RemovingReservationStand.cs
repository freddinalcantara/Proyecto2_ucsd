namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingReservationStand : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReservationStands", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.ReservationStands", "StandId_Id", "dbo.Stands");
            DropIndex("dbo.ReservationStands", new[] { "Reservation_Id" });
            DropIndex("dbo.ReservationStands", new[] { "StandId_Id" });
            AddColumn("dbo.Reservations", "Stand_Id", c => c.Int());
            CreateIndex("dbo.Reservations", "Stand_Id");
            AddForeignKey("dbo.Reservations", "Stand_Id", "dbo.Stands", "Id");
            DropTable("dbo.ReservationStands");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReservationStands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reservation_Id = c.Int(),
                        StandId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Reservations", "Stand_Id", "dbo.Stands");
            DropIndex("dbo.Reservations", new[] { "Stand_Id" });
            DropColumn("dbo.Reservations", "Stand_Id");
            CreateIndex("dbo.ReservationStands", "StandId_Id");
            CreateIndex("dbo.ReservationStands", "Reservation_Id");
            AddForeignKey("dbo.ReservationStands", "StandId_Id", "dbo.Stands", "Id");
            AddForeignKey("dbo.ReservationStands", "Reservation_Id", "dbo.Reservations", "Id");
        }
    }
}
