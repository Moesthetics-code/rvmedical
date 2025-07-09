using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    public class specialite
    {
        [Key]
        public int Idspecialite {  get; set; }
        [Required, MaxLength(10)] 
        public String codeSpecialite { get; set; }
        [Required, MaxLength(100  )]
        public String nomSpecialite { get; set; }



    }
}
