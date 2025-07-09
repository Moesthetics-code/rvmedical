using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetierRvMedical.model;

namespace gestion_rendez_vous.model
{
    public class Secretaire:Utilisateur
    {
        [MaxLength(15)]
        public String TelephoneFixe {  get; set; }
    }
}
