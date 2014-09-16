using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model
{

    [Table("Personer")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Fornamn { get; set; }
        public string Efternamn { get; set; }

        private ICollection<Kontaktuppgift> _kontaktuppgifter;

        public virtual ICollection<Kontaktuppgift> Kontaktuppgifter
        {
            get { return _kontaktuppgifter ?? (_kontaktuppgifter = new System.Collections.ObjectModel.Collection<Kontaktuppgift>()); }
            set { _kontaktuppgifter = value; }
        }
    }
}
