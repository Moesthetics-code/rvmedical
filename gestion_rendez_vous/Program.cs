using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_rendez_vous.model;
using gestion_rendez_vous.view;

namespace gestion_rendez_vous
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSoins());  
        }
        static void CreateAdmin()
        {
            bdRvMedicalContext db = new bdRvMedicalContext();
            var AdminExist = db.admins.Count();
            if (AdminExist == 0)
            {
                // Vérifier si le rôle 'admin' existe
                var roleAdmin = db.roles.FirstOrDefault(a => a.code.ToLower() == "admin");

                // S'il n'existe pas, on le crée
                if (roleAdmin == null)
                {
                    roleAdmin = new Role
                    {
                        code = "admin",
                        libelle = "Administrateur"
                    };
                    db.roles.Add(roleAdmin);
                    db.SaveChanges(); // Sauvegarde pour générer l'ID
                }

                // Création de l'admin
                Admin admin = new Admin
                {
                    Adresse = "Admin Adresse",
                    Identifiant = "Admin",
                    status = true,
                    Tel = "tel-Admin",
                    Motdepasse = Helper.CryptString.GetMd5Hash("Passer1234"),
                    NomPrenom = "Nom-Prenom",
                    Email = "l3gl@yopmail.com",
                    IdRole = roleAdmin.Id
                };

                db.admins.Add(admin);
                db.SaveChanges();
            }

        }
    }
}
