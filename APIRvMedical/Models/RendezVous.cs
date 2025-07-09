using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    [Table("rendezvous")]
    public  class RendezVous
    {
        [Key]
        public int IdRv {  get; set; }

        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public string Statut { get; set; }

        public DateTime? DateDemande { get; set; }

        public int IdSoin { get; set; }
        [ForeignKey("IdSoin")]
        public Soin soin { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public patient Patient { get; set; }
        public int IdMedecin { get; set; }
        [ForeignKey("IdMedecin")]
        public Medecin medecin { get; set; }
        public int IdMoyenPaiement { get; set; }
        [ForeignKey("IdMoyenPaiement")]
        public MoyenPaiement moyenPaiement { get; set; }


    }
}
