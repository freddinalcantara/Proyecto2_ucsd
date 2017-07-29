namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdentity : DbMigration
    {
        public override void Up()
        {
            Sql("alter table [dbo].[Clientes] ADD newcolumn int identity(1,1)");
            Sql("ALTER TABLE [dbo].[Clientes] DROP COLUMN [Id]");
            Sql("EXEC sp_rename 'Clientes.NewColumn','Id','COLUMN'");
        }
        
        public override void Down()
        {
        }
    }
}
