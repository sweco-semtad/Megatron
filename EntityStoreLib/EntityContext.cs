using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megatron.DataModels;

namespace Megatron.EntityStoreLib
{
    using Migration;

    internal class EntityContext
        : DbContext
    {
        public EntityContext()
        {

        }

        public EntityContext(string connectionStringName)
            : base(connectionStringName)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TODO: Dispatcher svar
            modelBuilder.Entity<DataModels.Model.Forening>();

            //modelBuilder.Configurations.Add(new ForeningConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void Dispose(bool disposing)
        {

            base.Dispose(disposing);
        }
    }

    public class DbSettings
    {
        private static DbSettings _instance;
        public static DbSettings Current
        {
            get { return _instance ?? (_instance = new DbSettings()); }
        }

        private bool _isInitialized = false;

        public void Initialize(string connectionStringName)
        {
            if (!_isInitialized)
            {
                Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<EntityContext, EntityContextConfiguration>(connectionStringName));
                using (var context = new EntityContext(connectionStringName))
                {
                    context.Database.Initialize(force: true);
                }
                //_isInitialized = true;
            }

        }
    }
}
