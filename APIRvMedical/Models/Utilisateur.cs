using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    public class Utilisateur :personne
    {
        [MaxLength(20)]
        public String Identifiant {  get; set; }
        [MaxLength(250)]
        public String Motdepasse { get; set; }

        public bool status { get; set; }
        public int IdRole { get; set; }
        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }
    }
}
