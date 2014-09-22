using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model
{

    [Table("Foreningar")]
    public class Forening
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Namn { get; set; }

        private ICollection<Event> _event;
        public virtual ICollection<Event> Event
        {
            get { return _event ?? (_event = new System.Collections.ObjectModel.Collection<Event>()); }
            set { _event = value; }
        }

        private ICollection<Medlem> _medlemmar;
        public virtual ICollection<Medlem> Medlemmar
        {
            get { return _medlemmar ?? (_medlemmar = new System.Collections.ObjectModel.Collection<Medlem>()); }
            set { _medlemmar = value; }
        }

        // Betalningsinformation
    }
}