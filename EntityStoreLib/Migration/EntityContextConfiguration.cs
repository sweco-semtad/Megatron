using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megatron.EntityStoreLib.Migration
{
    internal sealed class EntityContextConfiguration
        : DbMigrationsConfiguration<EntityContext>
    {
        public EntityContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EntityContext context)
        {
            base.Seed(context);
        }
    }
}
