using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityStoreLib.Migration
{
    using Megatron.DataModels.Model;

    public class EntityConfigurations
    {

        internal sealed class ForeningConfiguration : EntityTypeConfiguration<Forening>
        {
            public ForeningConfiguration()
            {
                //HasMany(a => a.Event).WithRequired(s => s. Owner).WillCascadeOnDelete(true);
            }
        }

    }
}
