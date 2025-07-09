namespace gestion_rendez_vous.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutModificationsModel : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.personnes", "IdRole");
            AddForeignKey("dbo.personnes", "IdRole", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.personnes", "IdRole", "dbo.Roles");
            DropIndex("dbo.personnes", new[] { "IdRole" });
        }
    }
}
