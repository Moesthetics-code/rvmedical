using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.ServiceProcess;
using System.Timers;

namespace ServiceEmvoiMail
{
    public partial class ServiceL3GLg2 : ServiceBase
    {
        private Timer atimer;

        public ServiceL3GLg2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteLogSystem("Service démarré", "Initialisation du service.");

            atimer = new Timer(1000); // 10 secondes
            atimer.Elapsed += OnTimerEvent;
            atimer.AutoReset = true;
            atimer.Enabled = true;

            WriteLogSystem("Minuterie activée", "Tâche automatique toutes les 1 secondes.");
        }

        private void OnTimerEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                string horodatage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                WriteLogSystem("Tâche exécutée", $"Email envoyé à {horodatage}");

                EnvoyerEmail("Service de test", $"Ceci est un message automatique envoyé à {horodatage}.");
            }
            catch (Exception ex)
            {
                WriteLogSystem("Erreur pendant la tâche", ex.ToString(), EventLogEntryType.Error);
            }
        }

        protected override void OnStop()
        {
            WriteLogSystem("Service arrêté", "Fin du service.");
        }

        private void WriteLogSystem(string titre, string details, EventLogEntryType type = EventLogEntryType.Information)
        {
            try
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    if (!EventLog.SourceExists("ServiceEmvoiMail"))
                    {
                        EventLog.CreateEventSource("ServiceEmvoiMail", "Application");
                    }

                    eventLog.Source = "ServiceEmvoiMail";
                    eventLog.WriteEntry($"{titre} - {details}", type);
                }
            }
            catch
            {
                // Ignorer toute erreur de journal
            }
        }

        private void EnvoyerEmail(string sujet, string contenu)
        {
            // ⚠️ Personnalise avec ton propre compte mail
            string from = "falllama660@gmail.com";
            string to = "lamafall308@icloud.com";
            string smtp = "smtp.gmail.com";
            string mdp = "emup nvkr ytyz irzh"; 

            MailMessage mail = new MailMessage(from, to, sujet, contenu);
            SmtpClient client = new SmtpClient(smtp, 587)
            {
                Credentials = new NetworkCredential(from, mdp),
                EnableSsl = true
            };

            client.Send(mail);
        }
    }
}
