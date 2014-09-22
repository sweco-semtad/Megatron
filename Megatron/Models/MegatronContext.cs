using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Megatron.Models
{
    public class MegatronContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MegatronContext() : base("name=MegatronContext")
        {
        }

        public System.Data.Entity.DbSet<Megatron.DataModels.Model.Forening> Forenings { get; set; }

        public System.Data.Entity.DbSet<Megatron.DataModels.Model.Event> Events { get; set; }

        public System.Data.Entity.DbSet<Megatron.DataModels.Model.Formular> Formulars { get; set; }
    
    }
}
