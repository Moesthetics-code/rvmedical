using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using gestion_rendez_vous.Helper;
using gestion_rendez_vous.model;

namespace gestion_rendez_vous.view
{
    public partial class frmAgenda : Form

    {
        public int idMedecin;
        Utils utils = new Utils();
        public frmAgenda()
        {
            InitializeComponent();
        }
       // bdRvMedicalContext db = new bdRvMedicalContext();
        ServiceMetier.Service1Client service = new ServiceMetier.Service1Client();
        private void dgMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {

        }

        private void btn_choisir_Click(object sender, EventArgs e)
        {

        }

        private void txt_NumeroOM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Specialite_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_Identifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtx_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nom_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                 ServiceMetier.Agenda a = new ServiceMetier.Agenda();

                // Validation du créneau
                if (int.TryParse(txt_creneau.Text.Trim(), out int creneau))
                {
                    a.Creneau = creneau;
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un nombre valide pour le créneau.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Assignation des autres propriétés de l'agenda
                a.HeureDebut = txt_heuredebut.Text;
                a.HeureFin = txt_heurefin.Text;
                a.IdMedecin = idMedecin;
                a.DatePlanifie = txtDate.Value;
                a.Statut = "brouillon"; // Par défaut, statut est "brouillon"
                a.Lieu = txt_lieu.Text;
                a.Titre = txt_titre.Text;
                service.AddAgenda(a);


            }
            catch (Exception ex)
            {
                utils.WriteDataError("frmAgenda-btn_ajouter_Click", ex.ToString());
            }
            finally
            {
                Resetform();
            }
            
            
           
        }
        private void Resetform()
        {
           
            var agendas = service.GetListeAgenda().Where(a => a.DatePlanifie >= DateTime.Now && a.IdMedecin == idMedecin).ToList();

            dgAgence.DataSource = null; // Réinitialiser la source de données
            dgAgence.DataSource = agendas; // Re-assigner la nouvelle source de données
            dgAgence.Refresh(); // 🌟 Forcer l'actualisation de l'affichage

            // Réinitialiser les champs du formulaire
            txt_creneau.Text = string.Empty;
            txtDate.Value = DateTime.Now;
            txt_heuredebut.Text = string.Empty;
            txt_heurefin.Text = string.Empty;
            txt_lieu.Text = string.Empty;
            txt_titre.Text = string.Empty;

            // Mettre le focus sur le champ "Titre"
            txt_titre.Focus();
        }






        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m = service.GetMedecinbyId(idMedecin);
            lbl_medecin.Text = string.Format("N Ordre:{0},Nom Prenom: {1}", m.NumeroOrdre, m.NomPrenom);
            lbl_idmedecin.Text=m.IdU.ToString();
            lbl_idmedecin.Visible = false;
            Resetform();

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
