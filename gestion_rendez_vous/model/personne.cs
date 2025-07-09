using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gestion_rendez_vous
{
    public  class personne
    {
        [Key]
         public int IdU { get; set; }
        [Required, MaxLength(160)]
         public string NomPrenom { get; set; }
        [Required, MaxLength(200)]
        public String Adresse { get; set; }
        [Required, MaxLength(80) ,DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required, MaxLength(20)]
        public String Tel { get; set; }
    }
}
