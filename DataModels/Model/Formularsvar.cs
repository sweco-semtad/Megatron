using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model
{

    [Table("Formularsvar")]
    public class Formularsvar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public DateTime Tidsstampel { get; set; }

        // Betalning

        private ICollection<Fragor.Svar> _svar;
        public virtual ICollection<Fragor.Svar> Svar
        {
            get { return _svar ?? (_svar = new System.Collections.ObjectModel.Collection<Fragor.Svar>()); }
            set { _svar = value; }
        }
    }
}
