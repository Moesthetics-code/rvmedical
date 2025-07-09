using System;
using System.Runtime.Serialization; // <--- important
using System.ComponentModel.DataAnnotations;

namespace MetierRvMedical
{
    [DataContract]  // Ajouté ici
    public class personne
    {
        [Key]
        [DataMember]  // Ajouté ici
        public int IdU { get; set; }

        [Required, MaxLength(160)]
        [DataMember]
        public string NomPrenom { get; set; }

        [Required, MaxLength(200)]
        [DataMember]
        public string Adresse { get; set; }

        [Required, MaxLength(80), DataType(DataType.EmailAddress)]
        [DataMember]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        [DataMember]
        public string Tel { get; set; }
    }
}
