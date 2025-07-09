using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_rendez_vous.model;

namespace gestion_rendez_vous.Helper
{
    public class Utils
    {
        private bdRvMedicalContext db = new bdRvMedicalContext();

        /// <summary>
        /// Cette méthode enregistre l'erreur dans la base de données.
        /// </summary>
        /// <param name="TitreErreur">Le titre du log</param>
        /// <param name="erreur">Le message du log</param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur
                {
                    DataErreur = DateTime.Now,
                    DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur,
                    TitreErreur = TitreErreur
                };

                db.td_Erreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError"); // Appel à la méthode d'instance
            }
        }

        /// <summary>
        /// Cette méthode enregistre l'erreur dans un fichier.
        /// </summary>
        /// <param name="message">Le message d'erreur</param>
        public static void WriteFileError(string message)
        {
            try
            {
                // Vérification du type d'application (ASP.NET ou Console/Desktop)
                string path;
                if (System.Web.HttpContext.Current != null) // Si ASP.NET
                {
                    path = System.Web.HttpContext.Current.Server.MapPath("~/Error/erreur.txt");
                }
                else // Si Console ou Desktop
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error", "erreur.txt");
                }

                // Création du répertoire s'il n'existe pas
                Directory.CreateDirectory(Path.GetDirectoryName(path));

                using (StreamWriter writerFile = new StreamWriter(path, true))
                {
                    writerFile.WriteLine($"{DateTime.Now}");
                    writerFile.WriteLine(message);
                    writerFile.WriteLine("-----------------------------------------------------------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Utils.WriteLogSystem(ex.ToString(), "WriteFileError"); // Appel à la méthode d'instance
            }
        }

        /// <summary>
        /// Cette méthode permet de logger les erreurs dans le journal d'événements système.
        /// </summary>
        /// <param name="erreur">Le message d'erreur</param>
        /// <param name="libelle">Le titre d'erreur</param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "GestionRvMedical";
                eventLog.WriteEntry(
                    string.Format("Date : {0}, Libellé : {1}, Description : {2}", DateTime.Now, libelle, erreur),
                    EventLogEntryType.Information,
                    101,
                    1
                );
            }
        }
    }
}
