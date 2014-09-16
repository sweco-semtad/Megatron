using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model.Fagor
{
    [Table("Fragor")]
    public class Fraga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long Id { get; set; }

        public string Kortnamn { get; set; }

        public bool Obligatorisk { get; set; }

        public int Index { get; set; }
    }
}
