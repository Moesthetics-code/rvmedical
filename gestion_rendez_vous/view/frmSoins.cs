using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using gestion_rendez_vous.model;
using Newtonsoft.Json;

namespace gestion_rendez_vous.view
{
    public partial class frmSoins : Form
    {
        public frmSoins()
        {
            InitializeComponent();
        }

        private void frmSoins_Load(object sender, EventArgs e)
        {
            // Charger les soins au chargement du formulaire
            var soins = servGetListProduit();

            // Afficher les données dans une DataGridView (ex: dgvSoins)
            if (soins != null && soins.Count > 0)
           {
                dgSoins.DataSource = soins;
            }
        }

        public List<Soin> servGetListProduit()
        {
            List<Soin> services = new List<Soin>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Récupération de l'URL de l'API depuis app.config
                    string baseUrl = ConfigurationManager.AppSettings["ServeurApiURL"];
                    client.BaseAddress = new Uri(baseUrl);

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Appel HTTP GET à l’API PHP
                    HttpResponseMessage response = client.GetAsync("soins").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = response.Content.ReadAsStringAsync().Result;

                        // Désérialisation JSON avec Newtonsoft
                        services = JsonConvert.DeserializeObject<List<Soin>>(responseData);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des soins : " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return services;
        }
        public bool AddSoin(Soin soin)
        {
            bool rep = false;
            string id = soin.IdSoin > 0 ? soin.IdSoin.ToString() : "0";

            var values = new Dictionary<string, string>
    {
        
        { "nomSoin", soin.nomSoin.ToString() },
        { "cout", soin.Cout.ToString() },
        { "libelle", soin.Libelle }  
    };

            var content = new FormUrlEncodedContent(values);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string baseUrl = ConfigurationManager.AppSettings["ServeurApiURL"];
                    client.BaseAddress = new Uri(baseUrl);

                    // Appel POST vers l’API PHP
                    var response = client.PostAsync("create.php", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        rep = true;
                    }
                    else
                    {
                        MessageBox.Show("Erreur HTTP : " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return rep;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Soin soin = new Soin
            {
                nomSoin = txt_nomSoin.Text,
                Cout = double.Parse(txt_coutSoin.Text),
                Libelle = txt_libelleSoin.Text
            };

            if (AddSoin(soin))
            {
                MessageBox.Show("Soin ajouté avec succès !");

                var soins = servGetListProduit();
                dgSoins.DataSource = null;
                dgSoins.DataSource = soins;
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du soin.");
            }
        }

    }
}
