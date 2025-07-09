using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rendez_vous.model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string code { get; set; }
        [MaxLength(30)]
        public string libelle { get; set; }
    }
}
