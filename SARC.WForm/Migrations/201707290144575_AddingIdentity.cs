namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes");
            DropIndex("dbo.Orders", new[] { "Cliente_Id" });
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            RenameColumn(table: "dbo.Orders", name: "Cliente_Id", newName: "Cliente_Cedula");
            RenameColumn(table: "dbo.Reservations", name: "Client_Id", newName: "Client_Cedula");
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Orders", "Cliente_Cedula", c => c.String(maxLength: 128));
            AlterColumn("dbo.Clientes", "Cedula", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Reservations", "Client_Cedula", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Clientes", "Cedula");
            CreateIndex("dbo.Orders", "Cliente_Cedula");
            CreateIndex("dbo.Reservations", "Client_Cedula");
            AddForeignKey("dbo.Orders", "Cliente_Cedula", "dbo.Clientes", "Cedula");
            AddForeignKey("dbo.Reservations", "Client_Cedula", "dbo.Clientes", "Cedula");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_Cedula", "dbo.Clientes");
            DropForeignKey("dbo.Orders", "Cliente_Cedula", "dbo.Clientes");
            DropIndex("dbo.Reservations", new[] { "Client_Cedula" });
            DropIndex("dbo.Orders", new[] { "Cliente_Cedula" });
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Reservations", "Client_Cedula", c => c.Int());
            AlterColumn("dbo.Clientes", "Cedula", c => c.String());
            AlterColumn("dbo.Orders", "Cliente_Cedula", c => c.Int());
            AddPrimaryKey("dbo.Clientes", "Id");
            RenameColumn(table: "dbo.Reservations", name: "Client_Cedula", newName: "Client_Id");
            RenameColumn(table: "dbo.Orders", name: "Cliente_Cedula", newName: "Cliente_Id");
            CreateIndex("dbo.Reservations", "Client_Id");
            CreateIndex("dbo.Orders", "Cliente_Id");
            AddForeignKey("dbo.Reservations", "Client_Id", "dbo.Clientes", "Id");
            AddForeignKey("dbo.Orders", "Cliente_Id", "dbo.Clientes", "Id");
        }
    }
}
