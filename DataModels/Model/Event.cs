using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model
{

    [Table("Event")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Namn { get; set; }

        public string Noteringar { get; set; }

        public Tidsspann AktivPeriod { get; set; }

        private ICollection<Formular> _formular;

        public virtual ICollection<Formular> Formular
        {
            get { return _formular ?? (_formular = new System.Collections.ObjectModel.Collection<Formular>()); }
            set { _formular = value; }
        }
    }
}
