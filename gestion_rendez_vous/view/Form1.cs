using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using gestion_rendez_vous.view;
using gestion_rendez_vous.Helper;
using gestion_rendez_vous.model;
using gestion_rendez_vous.ServiceMetier;

namespace gestion_rendez_vous
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        
        private void fermer()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        // Connexion utilisateur
        private void btn_connecter_Click(object sender, EventArgs e)
        {
            var client = new ServiceMetier.Service1Client();

            string hash = CryptString.GetMd5Hash(txt_mdp.Text);

            var user = client.Connexion(txt_identifiant.Text, hash);

            if (user != null)
            {
                frmMDI f = new frmMDI();
                f.role = user.Role.code;
                f.Show();
                f.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Identifiant ou mot de passe incorrect";
            }
        }


        // Quitter l'application
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Chargement initial
        private void Form1_Load(object sender, EventArgs e)
        {
            // Test log et envoi email si tu veux garder
            Utils.WriteLogSystem("test", "ceci est un test");
            GMailer.senMail("falllama660@gmail.com", "test", "un test");
        }
    }
}
