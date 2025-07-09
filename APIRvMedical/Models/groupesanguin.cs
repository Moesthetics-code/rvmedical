using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical.Models
{
    public class groupesanguin
    {
        [Key]
        public int IdGroupeSanguin { get; set; }
        [Required, MaxLength(3)]
        public string codegroupesanguin { get; set; }

    }
}
