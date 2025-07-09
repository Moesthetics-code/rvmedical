namespace gestion_rendez_vous.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        code = c.String(maxLength: 10, storeType: "nvarchar"),
                        libelle = c.String(maxLength: 30, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.personnes", "IdRole", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personnes", "IdRole");
            DropTable("dbo.Roles");
        }
    }
}
