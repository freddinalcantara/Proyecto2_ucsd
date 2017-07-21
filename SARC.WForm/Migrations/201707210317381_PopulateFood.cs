namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFood : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Foods (name,numberinstock) values ('Arroz','10')");
            Sql("Insert into dbo.Foods (name,numberinstock) values ('Carne Cerdo','5')");
            Sql("Insert into dbo.Foods (name,numberinstock) values ('Habichuela','7')");
            Sql("Insert into dbo.Foods (name,numberinstock) values ('Berengena','10')");
            Sql("Insert into dbo.Foods (name,numberinstock) values ('Pasteles en hoja','20')");
        }

        
        public override void Down()
        {
        }
    }
}
