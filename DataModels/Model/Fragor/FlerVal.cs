﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megatron.DataModels.Model.Fragor
{
    [Table("Flerval")]
    public class Flerval : Fraga
    {
        public string Fraga { get; set; }

        private ICollection<ValAlternativ> _alternativ;
        public virtual ICollection<ValAlternativ> Alternativ
        {
            get { return _alternativ ?? (_alternativ = new System.Collections.ObjectModel.Collection<ValAlternativ>()); }
            set { _alternativ = value; }
        }
    }
}
