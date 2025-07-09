using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rendez_vous.model
{
    public class groupesanguin
    {
        [Key]
        public int IdGroupeSanguin { get; set; }
        [Required, MaxLength(3)]
        public string codegroupesanguin { get; set; }

    }
}
