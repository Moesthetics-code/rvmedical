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
using gestion_rendez_vous.Report;

namespace gestion_rendez_vous.view
{
    public partial class impressionticket : Form
    {
        public impressionticket()
        {
            InitializeComponent();
        }
        bdRvMedicalContext db = new bdRvMedicalContext();

        private void impressionticket_Load(object sender, EventArgs e)
        {
            rptReportTicketRv objRpt = new rptReportTicketRv();
            objRpt.SetDataSource(GetTableTicket(0));
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
        private void frmPrintTicket_Load(object sender, EventArgs e)
        {
            

        }

        public DataTable GetTableTicket(int? idrv = 0 )
        {
             DataTable table = new DataTable();
            table.Columns.Add("NomPrenom",typeof(string));
            table.Columns.Add("DateNaissance",typeof (DateTime));
            table.Columns.Add("DateRv",typeof(DateTime));
            table.Columns.Add("Medecin", typeof(string));
            table.Columns.Add("HeureRv", typeof(string));
            table.Columns.Add("DataQr", typeof(byte));
            var leRv = db.rendezVous.Where(a =>a.IdRv == idrv).FirstOrDefault();
            if (leRv != null)
            {
                table.Rows.Add(leRv.Patient.NomPrenom, leRv.Patient.DateNaissance,
                    leRv.DateDemande, leRv.medecin.NomPrenom,new byte[0]);
            }
            else
            {
                table.Rows.Add("NomPrenom", DateTime.Now,
                    DateTime.Now, "NomPrenom", new byte[0]);
            }
            return table;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
