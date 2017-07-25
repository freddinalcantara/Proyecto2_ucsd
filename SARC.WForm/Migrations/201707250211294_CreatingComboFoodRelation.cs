namespace SARC.WForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingComboFoodRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "Combo_Id", "dbo.Comboes");
            DropIndex("dbo.Foods", new[] { "Combo_Id" });
            CreateTable(
                "dbo.FoodComboes",
                c => new
                    {
                        Food_Id = c.Int(nullable: false),
                        Combo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Food_Id, t.Combo_Id })
                .ForeignKey("dbo.Foods", t => t.Food_Id, cascadeDelete: true)
                .ForeignKey("dbo.Comboes", t => t.Combo_Id, cascadeDelete: true)
                .Index(t => t.Food_Id)
                .Index(t => t.Combo_Id);
            
            DropColumn("dbo.Foods", "Combo_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "Combo_Id", c => c.Int());
            DropForeignKey("dbo.FoodComboes", "Combo_Id", "dbo.Comboes");
            DropForeignKey("dbo.FoodComboes", "Food_Id", "dbo.Foods");
            DropIndex("dbo.FoodComboes", new[] { "Combo_Id" });
            DropIndex("dbo.FoodComboes", new[] { "Food_Id" });
            DropTable("dbo.FoodComboes");
            CreateIndex("dbo.Foods", "Combo_Id");
            AddForeignKey("dbo.Foods", "Combo_Id", "dbo.Comboes", "Id");
        }
    }
}
