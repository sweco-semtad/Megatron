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

        private ICollection<Medlem> _medlemmar;

        public virtual ICollection<Medlem> StudyTokens
        {
            get { return _medlemmar ?? (_medlemmar = new System.Collections.ObjectModel.Collection<Medlem>()); }
            set { _medlemmar = value; }
        }
    }
}