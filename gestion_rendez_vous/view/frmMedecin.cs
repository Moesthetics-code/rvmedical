using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_rendez_vous.model;
using gestion_rendez_vous.Helper;

namespace gestion_rendez_vous.view
{
    public partial class frmMedecin : Form
    {
        bdRvMedicalContext db = new bdRvMedicalContext();

        public frmMedecin()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private List<SelectListViewModel> LoadCbbSpecialite()
        {
            var specialites = db.specialites.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel defaut = new SelectListViewModel
            {
                Text = "SELECTIONNEZ ...",
                Value = ""
            };
            liste.Add(defaut);

            foreach (var specialite in specialites)
            {
                SelectListViewModel item = new SelectListViewModel
                {
                    Text = specialite.nomSpecialite,
                    Value = specialite.Idspecialite.ToString()
                };
                liste.Add(item);
            }
            return liste;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification des champs obligatoires
                if (string.IsNullOrWhiteSpace(txt_nom_prenom.Text) ||
                    string.IsNullOrWhiteSpace(txt_email.Text) ||
                    string.IsNullOrWhiteSpace(txt_tel.Text) ||
                    string.IsNullOrWhiteSpace(txt_NumeroOM.Text) ||
                    cbbSpecialite.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Création de l'objet médecin
                Medecin m = new Medecin
                {
                    Adresse = txtx_adresse.Text,
                    NumeroOrdre = txt_NumeroOM.Text,
                    Email = txt_email.Text,
                    NomPrenom = txt_nom_prenom.Text,
                    Tel = txt_tel.Text,
                    Identifiant = txt_Identifiant.Text,
                    Motdepasse = CryptString.GetMd5Hash("Passer1234"),
                    IdRole=db.roles.Where(a=>a.code== "Med").FirstOrDefault().Id,
                    status = false
                };

                // Vérification de la spécialité
                if (int.TryParse(cbbSpecialite.SelectedValue.ToString(), out int idSpecialite))
                {
                    m.Idspecialite = idSpecialite;
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une spécialité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ajout en base de données
                db.medecins.Add(m);
                db.SaveChanges();
                MessageBox.Show("Médecin ajouté avec succès !");

                // Réinitialisation du formulaire
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du médecin : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtx_adresse.Text = String.Empty;
            txt_email.Text = String.Empty;
            txt_Identifiant.Text = String.Empty;
            cbbSpecialite.SelectedValue = String.Empty;
            txt_tel.Text = String.Empty;
            txt_nom_prenom.Text = String.Empty;
            txt_NumeroOM.Text = String.Empty;

            // Remplir la liste des spécialités
            cbbSpecialite.DataSource = LoadCbbSpecialite();
            cbbSpecialite.ValueMember = "Value";
            cbbSpecialite.DisplayMember = "Text";

            // Remplir la DataGridView
            dgMedecin.DataSource = db.medecins.Select(a => new
            {
                a.IdU,
                a.NumeroOrdre,
                a.Identifiant,
                a.specialite.nomSpecialite,
                a.NomPrenom,
                a.Tel,
                a.Email
            }).ToList();

            txt_nom_prenom.Focus();
        }

        private void btn_choisir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMedecin.CurrentRow == null || dgMedecin.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Aucun médecin sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
                var m = db.medecins.Find(id);
                if (m != null)
                {
                    txtx_adresse.Text = m.Adresse;
                    txt_email.Text = m.Email;
                    txt_Identifiant.Text = m.Identifiant;
                    txt_nom_prenom.Text = m.NomPrenom;
                    txt_NumeroOM.Text = m.NumeroOrdre;
                    cbbSpecialite.SelectedValue = m.Idspecialite;
                    txt_tel.Text = m.Tel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sélection du médecin : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMedecin.CurrentRow == null || dgMedecin.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Aucun médecin sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
                var m = db.medecins.Find(id);
                if (m != null)
                {
                    m.Adresse = txtx_adresse.Text;
                    m.NumeroOrdre = txt_NumeroOM.Text;
                    m.Email = txt_email.Text;
                    m.NomPrenom = txt_nom_prenom.Text;
                    m.Tel = txt_tel.Text;

                    // Vérification de la spécialité
                    if (int.TryParse(cbbSpecialite.SelectedValue.ToString(), out int idSpecialite))
                    {
                        m.Idspecialite = idSpecialite;
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une spécialité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    m.Identifiant = txt_Identifiant.Text;
                    m.status = false;

                    // Sauvegarde des modifications
                    db.SaveChanges();
                    MessageBox.Show("Médecin modifié avec succès !");
                }

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification du médecin : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMedecin.CurrentRow == null || dgMedecin.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Aucun médecin sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
                var m = db.medecins.Find(id);
                if (m != null)
                {
                    db.medecins.Remove(m);
                    db.SaveChanges();
                    MessageBox.Show("Médecin supprimé avec succès !");
                }

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du médecin : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMedecin.CurrentRow == null || dgMedecin.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Aucun médecin sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmAgenda a = new frmAgenda();
                a.idMedecin = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
                var m = db.medecins.Find(a.idMedecin);
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture de l'agenda : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
