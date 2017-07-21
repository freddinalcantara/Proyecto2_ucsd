namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ComboCount = c.Int(nullable: false),
                        Orden_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Orden_Id)
                .Index(t => t.Orden_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoOrden = c.String(),
                        Cliente_Id = c.String(maxLength: 128),
                        Stand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Stands", t => t.Stand_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Stand_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Celphone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comboes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberInStock = c.Int(nullable: false),
                        Combo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comboes", t => t.Combo_Id)
                .Index(t => t.Combo_Id);
            
            CreateTable(
                "dbo.Stands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Chairs = c.Int(nullable: false),
                        StandId = c.Int(nullable: false),
                        Details = c.String(),
                        InitDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Client_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes");
            DropForeignKey("dbo.Bills", "Orden_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Stand_Id", "dbo.Stands");
            DropForeignKey("dbo.Comboes", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Foods", "Combo_Id", "dbo.Comboes");
            DropForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropIndex("dbo.Foods", new[] { "Combo_Id" });
            DropIndex("dbo.Comboes", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "Stand_Id" });
            DropIndex("dbo.Orders", new[] { "Cliente_Id" });
            DropIndex("dbo.Bills", new[] { "Orden_Id" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Stands");
            DropTable("dbo.Foods");
            DropTable("dbo.Comboes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Orders");
            DropTable("dbo.Bills");
        }
    }
}
