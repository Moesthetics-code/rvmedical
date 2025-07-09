using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MetierRvMedical.model
{
    [DataContract]
    public class Role
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [MaxLength(10)]
        [DataMember]
        public string code { get; set; }

        [MaxLength(30)]
        [DataMember]
        public string libelle { get; set; }
    }
}
