namespace APIRvMedical.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.personnes",
                c => new
                    {
                        IdU = c.Int(nullable: false, identity: true),
                        NomPrenom = c.String(nullable: false, maxLength: 160, storeType: "nvarchar"),
                        Adresse = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        Tel = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        Identifiant = c.String(maxLength: 20, storeType: "nvarchar"),
                        Motdepasse = c.String(maxLength: 250, storeType: "nvarchar"),
                        status = c.Boolean(),
                        IdRole = c.Int(),
                        Idspecialite = c.Int(),
                        NumeroOrdre = c.String(maxLength: 10, storeType: "nvarchar"),
                        GroupeSanguin = c.String(maxLength: 3, storeType: "nvarchar"),
                        Poids = c.Single(),
                        Taille = c.Single(),
                        DateNaissance = c.DateTime(precision: 0),
                        TelephoneFixe = c.String(maxLength: 15, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdU)
                .ForeignKey("dbo.specialites", t => t.Idspecialite)
                .ForeignKey("dbo.Roles", t => t.IdRole, cascadeDelete: true)
                .Index(t => t.IdRole)
                .Index(t => t.Idspecialite);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        code = c.String(maxLength: 10, storeType: "nvarchar"),
                        libelle = c.String(maxLength: 30, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        IdAgenda = c.Int(nullable: false, identity: true),
                        DatePlanifie = c.DateTime(precision: 0),
                        Titre = c.String(unicode: false),
                        HeureDebut = c.String(unicode: false),
                        HeureFin = c.String(unicode: false),
                        Creneau = c.Int(nullable: false),
                        Lieu = c.String(unicode: false),
                        Statut = c.String(unicode: false),
                        IdMedecin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAgenda)
                .ForeignKey("dbo.personnes", t => t.IdMedecin, cascadeDelete: true)
                .Index(t => t.IdMedecin);
            
            CreateTable(
                "dbo.specialites",
                c => new
                    {
                        Idspecialite = c.Int(nullable: false, identity: true),
                        codeSpecialite = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        nomSpecialite = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Idspecialite);
            
            CreateTable(
                "dbo.rendezvous",
                c => new
                    {
                        IdRv = c.Int(nullable: false, identity: true),
                        HeureDebut = c.String(unicode: false),
                        HeureFin = c.String(unicode: false),
                        Statut = c.String(unicode: false),
                        DateDemande = c.DateTime(precision: 0),
                        IdSoin = c.Int(nullable: false),
                        IdPatient = c.Int(nullable: false),
                        IdMedecin = c.Int(nullable: false),
                        IdMoyenPaiement = c.Int(nullable: false),
                        Agenda_IdAgenda = c.Int(),
                    })
                .PrimaryKey(t => t.IdRv)
                .ForeignKey("dbo.personnes", t => t.IdMedecin, cascadeDelete: true)
                .ForeignKey("dbo.MoyenPaiements", t => t.IdMoyenPaiement, cascadeDelete: true)
                .ForeignKey("dbo.personnes", t => t.IdPatient, cascadeDelete: true)
                .ForeignKey("dbo.Soins", t => t.IdSoin, cascadeDelete: true)
                .ForeignKey("dbo.Agenda", t => t.Agenda_IdAgenda)
                .Index(t => t.IdSoin)
                .Index(t => t.IdPatient)
                .Index(t => t.IdMedecin)
                .Index(t => t.IdMoyenPaiement)
                .Index(t => t.Agenda_IdAgenda);
            
            CreateTable(
                "dbo.MoyenPaiements",
                c => new
                    {
                        IdMoyenPaiement = c.Int(nullable: false, identity: true),
                        nomMP = c.String(unicode: false),
                        libelle = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdMoyenPaiement);
            
            CreateTable(
                "dbo.Soins",
                c => new
                    {
                        IdSoin = c.Int(nullable: false, identity: true),
                        nomSoin = c.String(unicode: false),
                        Libelle = c.String(unicode: false),
                        Cout = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdSoin);
            
            CreateTable(
                "dbo.groupesanguins",
                c => new
                    {
                        IdGroupeSanguin = c.Int(nullable: false, identity: true),
                        codegroupesanguin = c.String(nullable: false, maxLength: 3, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdGroupeSanguin);
            
            CreateTable(
                "dbo.Td_Erreur",
                c => new
                    {
                        IdErreur = c.Int(nullable: false, identity: true),
                        DataErreur = c.DateTime(nullable: false, precision: 0),
                        TitreErreur = c.String(maxLength: 200, storeType: "nvarchar"),
                        DescriptionErreur = c.String(maxLength: 2000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdErreur);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.personnes", "IdRole", "dbo.Roles");
            DropForeignKey("dbo.rendezvous", "Agenda_IdAgenda", "dbo.Agenda");
            DropForeignKey("dbo.rendezvous", "IdSoin", "dbo.Soins");
            DropForeignKey("dbo.rendezvous", "IdPatient", "dbo.personnes");
            DropForeignKey("dbo.rendezvous", "IdMoyenPaiement", "dbo.MoyenPaiements");
            DropForeignKey("dbo.rendezvous", "IdMedecin", "dbo.personnes");
            DropForeignKey("dbo.personnes", "Idspecialite", "dbo.specialites");
            DropForeignKey("dbo.Agenda", "IdMedecin", "dbo.personnes");
            DropIndex("dbo.rendezvous", new[] { "Agenda_IdAgenda" });
            DropIndex("dbo.rendezvous", new[] { "IdMoyenPaiement" });
            DropIndex("dbo.rendezvous", new[] { "IdMedecin" });
            DropIndex("dbo.rendezvous", new[] { "IdPatient" });
            DropIndex("dbo.rendezvous", new[] { "IdSoin" });
            DropIndex("dbo.Agenda", new[] { "IdMedecin" });
            DropIndex("dbo.personnes", new[] { "Idspecialite" });
            DropIndex("dbo.personnes", new[] { "IdRole" });
            DropTable("dbo.Td_Erreur");
            DropTable("dbo.groupesanguins");
            DropTable("dbo.Soins");
            DropTable("dbo.MoyenPaiements");
            DropTable("dbo.rendezvous");
            DropTable("dbo.specialites");
            DropTable("dbo.Agenda");
            DropTable("dbo.Roles");
            DropTable("dbo.personnes");
        }
    }
}
