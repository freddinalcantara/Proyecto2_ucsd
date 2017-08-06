namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Cliente_Cedula", "dbo.Clientes");
            DropForeignKey("dbo.Reservations", "Client_Cedula", "dbo.Clientes");
            DropIndex("dbo.Orders", new[] { "Cliente_Cedula" });
            DropIndex("dbo.Reservations", new[] { "Client_Cedula" });
            RenameColumn(table: "dbo.Orders", name: "Cliente_Cedula", newName: "Cliente_Id");
            RenameColumn(table: "dbo.Reservations", name: "Client_Cedula", newName: "Client_Id");
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Orders", "Cliente_Id", c => c.Int());
            AlterColumn("dbo.Clientes", "Cedula", c => c.String());
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
            AlterColumn("dbo.Clientes", "Cedula", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Orders", "Cliente_Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Clientes", "Cedula");
            RenameColumn(table: "dbo.Reservations", name: "Client_Id", newName: "Client_Cedula");
            RenameColumn(table: "dbo.Orders", name: "Cliente_Id", newName: "Cliente_Cedula");
            CreateIndex("dbo.Reservations", "Client_Cedula");
            CreateIndex("dbo.Orders", "Cliente_Cedula");
            AddForeignKey("dbo.Reservations", "Client_Cedula", "dbo.Clientes", "Cedula");
            AddForeignKey("dbo.Orders", "Cliente_Cedula", "dbo.Clientes", "Cedula");
        }
    }
}
