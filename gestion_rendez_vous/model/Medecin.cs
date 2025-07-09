using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rendez_vous.model
{
    public class Medecin: Utilisateur
    {
        //[MaxLength(100)]
        //public String Specialite {  get; set; }
         public int? Idspecialite {  get; set; }
        [ForeignKey("Idspecialite ")]
        public virtual specialite specialite { get; set; }
        [MaxLength(10)] 
        public String NumeroOrdre { get; set; }

         public virtual ICollection<Agenda> agenda { get; set; }
    }
}