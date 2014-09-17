using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model.Fragor
{
    [Table("ValAlternativ")]
    public class ValAlternativ
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Varde { get; set; }

        public long? ValId { get; set; }

        [ForeignKey("ValId")]
        public virtual Val Val { get; set; }

        public decimal Pris { get; set; }

        public long? FlerValsId { get; set; }

        public int Index { get; set; }

        [ForeignKey("FlerValsId")]
        public virtual Flerval Flerval { get; set; }
    }
}
