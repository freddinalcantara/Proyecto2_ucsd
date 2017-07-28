namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes");
            DropIndex("dbo.Orders", new[] { "Cliente_Id" });
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropPrimaryKey("dbo.Clientes");
            AddColumn("dbo.Clientes", "Cedula", c => c.String());
            AlterColumn("dbo.Orders", "Cliente_Id", c => c.Int());
            AlterColumn("dbo.Clientes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Reservations", "Client_Id", c => c.Int());
            AddPrimaryKey("dbo.Clientes", "Id");
            CreateIndex("dbo.Orders", "Cliente_Id");
            CreateIndex("dbo.Reservations", "Client_Id");
            AddForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes", "Id");
            AddForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes");
            DropForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropIndex("dbo.Orders", new[] { "Cliente_Id" });
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Reservations", "Client_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Clientes", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Orders", "Cliente_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Clientes", "Cedula");
            AddPrimaryKey("dbo.Clientes", "Id");
            CreateIndex("dbo.Reservations", "Client_Id");
            CreateIndex("dbo.Orders", "Cliente_Id");
            AddForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes", "Id");
            AddForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes", "Id");
        }
    }
}
