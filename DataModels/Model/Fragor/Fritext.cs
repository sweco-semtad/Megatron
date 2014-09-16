using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model.Fagor
{
    [Table("Fritext")]
    public class Fritext : Fraga
    {
        public string FrageText { get; set; }
    }
}
