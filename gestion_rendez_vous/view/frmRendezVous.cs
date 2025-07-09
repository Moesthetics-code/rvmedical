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
    public partial class frmRendezVous : Form
    {
        public frmRendezVous()
        {
            InitializeComponent();
        }
        bdRvMedicalContext db = new bdRvMedicalContext();

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }

        private void frmRendezVous_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            RendezVous r =new RendezVous();
            
            
            r.IdSoin = int.Parse(cbbSoin.SelectedValue.ToString());
            r.IdMedecin = int.Parse(cbbMedecin.SelectedValue.ToString());
            r.IdMoyenPaiement=int.Parse(cbbModepaiement.SelectedValue.ToString());

            db.rendezVous.Add(r);
            db.SaveChanges();
            ResetForm();


        }
        private void ResetForm()
        {
           
            cbbSoin.DataSource = LoadCbbSoin();
            cbbSoin.ValueMember = "Value";
            cbbSoin.DisplayMember = "Text";
            cbbMedecin.DataSource = LoadCbbMedecin();
            cbbMedecin.ValueMember = "Value";
            cbbMedecin.DisplayMember = "Text";
            cbbModepaiement.DataSource = LoadCbbmoyenPaiement();
            cbbModepaiement.ValueMember = "Value";
            cbbModepaiement.DisplayMember = "Text";
            dglisteRV.DataSource = db.rendezVous.Select(r => new { r.IdSoin,r.IdMedecin,}).ToList();
            //txt_nom_prenom.Focus();
        }




        private List<SelectListViewModel> LoadCbbSoin()
        {
            var m = db.soins.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "SELECTIONNEZ ...";
            b.Value = "";
            liste.Add(b);

            foreach (var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.nomSoin;
                a.Value = c.IdSoin.ToString();
                liste.Add(a);
            }
            return liste;
        }
        private List<SelectListViewModel> LoadCbbMedecin()
        {
            var m = db.medecins.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "SELECTIONNEZ ...";
            b.Value = "";
            liste.Add(b);

            foreach (var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.NomPrenom;
                a.Value = c.IdU.ToString();
                liste.Add(a);
            }
            return liste;
        }
        private List<SelectListViewModel> LoadCbbmoyenPaiement()
        {
            var m = db.moyenPaiements.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "SELECTIONNEZ ...";
            b.Value = "";
            liste.Add(b);

            foreach (var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.nomMP;
                a.Value = c.IdMoyenPaiement.ToString();
                liste.Add(a);
            }
            return liste;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRendezVous_Load_1(object sender, EventArgs e)
        {

        }
    }
}
