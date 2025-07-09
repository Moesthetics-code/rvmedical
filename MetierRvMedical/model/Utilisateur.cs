using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;



namespace MetierRvMedical.model
{
    [DataContract]
    public class Utilisateur : personne
    {
        [DataMember]
        [MaxLength(20)]
        public string Identifiant { get; set; }

        [DataMember]
        [MaxLength(250)]
        public string Motdepasse { get; set; }

        [DataMember]
        public bool status { get; set; }

        [DataMember]
        public int IdRole { get; set; }

        [DataMember]
        public Role Role { get; set; } // ⚠️ Assure-toi aussi que `Role` est bien décoré avec [DataContract]
    }
}
