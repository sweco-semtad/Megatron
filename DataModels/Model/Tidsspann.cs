using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model
{

    [Table("Tidsspann")]
    public class Tidsspann
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public DateTime Start { get; set; }
        public DateTime Slut { get; set; }
    }
}
