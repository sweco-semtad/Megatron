using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model
{

    [Table("Formular")]
    public class Formular
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Namn { get; set; }

        public decimal Grundpris { get; set; }

        public Tidsspann Oppettider { get; set; }

        private ICollection<Fragor.Fraga> _fragor;
        public virtual ICollection<Fragor.Fraga> Fragor
        {
            get { return _fragor ?? (_fragor = new System.Collections.ObjectModel.Collection<Fragor.Fraga>()); }
            set { _fragor = value; }
        }
                   
        private ICollection<Fragor.Svar> _formularsvar;
        public virtual ICollection<Fragor.Svar> Formularsvar
        {
            get { return _formularsvar ?? (_formularsvar = new System.Collections.ObjectModel.Collection<Fragor.Svar>()); }
            set { _formularsvar = value; }
        }

        // Betalning
    }
}
