using Megatron.DataModels.Model.Repo;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megatron.EntityStoreLib
{
    public class RepositoryFactory : IDisposable
    {
        private static RepositoryFactory _instance;
        public static RepositoryFactory Current
        {
            get { return _instance ?? (_instance = new RepositoryFactory()); }
        }

        private RepositoryFactory()
        {

        }

        /// <summary>
        /// Create repository instance
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public IRepository<TEntity> Create<TEntity>() where TEntity : class
        {
            using (var container = new UnityContainer())
            {
                //container.RegisterType<IRepository<TEntity>, EntityStoreLib.EntityRepository<TEntity>>(new InjectionConstructor(Properties.Settings.Default.DBConnectionName));
                return container.Resolve<IRepository<TEntity>>();
            }
        }

        public IRepository<TEntity> CreateFromReference<TEntity>(IRepository repo) where TEntity : class
        {
            using (var container = new UnityContainer())
            {
                container.RegisterType<IRepository<TEntity>, EntityStoreLib.EntityRepository<TEntity>>(new InjectionConstructor(repo));
                return container.Resolve<IRepository<TEntity>>();
            }
        }

        public void Dispose()
        {

        }

        public void Init(string connectionStringName)
        {
            //EntityStoreLib.DbSettings.Current.Initialize(Properties.Settings.Default.DBConnectionName);
        }
    }
}
