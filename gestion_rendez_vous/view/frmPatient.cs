using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_rendez_vous.model;

namespace gestion_rendez_vous.view
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }
        bdRvMedicalContext db = new bdRvMedicalContext();
        private void ResetForm()
        {
            txtx_adresse.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_gsangin.Text = string.Empty;
            txt_nom_prenom.Text = string.Empty;
            txt_poids.Text = string.Empty;
            txt_taille.Text = string.Empty;
            txt_tel.Text = string.Empty;
            txtdatenaissance.Value=DateTime.Now;
            dgPatient.DataSource = db.patients.ToList();
            txt_nom_prenom.Focus();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.NomPrenom = txt_nom_prenom.Text;
            p.Adresse= txtx_adresse.Text;
            p.Tel= txt_tel.Text;
            p.Email= txt_email.Text;
            p.DateNaissance=DateTime.Parse(txtdatenaissance.Text);
            p.Poids = float.Parse(txt_poids.Text);
            p.Taille=float.Parse(txt_taille.Text);
            p.GroupeSanguin=txt_gsangin.Text;
            db.patients.Add(p);
            db.SaveChanges();
            ResetForm();

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int? id= int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if (id.HasValue)
            {
                var p = db.patients.Find(id);
                p.NomPrenom = txt_nom_prenom.Text;
                p.Adresse = txtx_adresse.Text;
                p.Tel = txt_tel.Text;
                p.Email = txt_email.Text;
                p.Poids = float.Parse(txt_poids.Text);
                p.Taille = float.Parse(txt_taille.Text);
                p.GroupeSanguin = txt_gsangin.Text;
                p.DateNaissance = DateTime.Parse(txtdatenaissance.Text);
                db.SaveChanges();
                ResetForm();

            }

        }

        private void btn_choisir_Click(object sender, EventArgs e)
        {
            txt_nom_prenom.Text=dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtx_adresse.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txt_email.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
            txt_tel.Text=dgPatient.CurrentRow.Cells[8].Value.ToString();
            txt_gsangin.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txt_poids.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txt_taille.Text= dgPatient.CurrentRow.Cells[2].Value.ToString();
            //txtdatenaissance.Value= DateTime.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if (id.HasValue)
            {
                var p = db.patients.Find(id);
               db.patients.Remove(p);
                db.SaveChanges();
                ResetForm();

            }
        }

        private void telephone_rch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            var liste =db.patients.ToList();
            if(!String.IsNullOrEmpty(email_rch.Text))
            {
               liste = liste.Where(a=> a.Email.ToUpper() == email_rch.Text.ToUpper()).ToList();
            }
            if (!String.IsNullOrEmpty(telephone_rch.Text))
            {
                liste = liste.Where(a => a.Tel.ToUpper() == telephone_rch.Text.ToUpper()).ToList();
            }
            dgPatient.DataSource = liste.ToList();
        }
        private void fermer()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnRV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnfemer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
