using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megatron.EntityStoreLib
{
    using Megatron.DataModels.Model.Repo;
    using log4net;
    using System.Data.Entity;
    public class EntityRepository<T> : IRepository<T> where T : class
    {
        private bool _canDisposeContext = true;
        internal readonly DbContext _context;
        private static readonly ILog Logger = LogManager.GetLogger("EntityRepository");

        public EntityRepository(string connectionStringName)
        {
            _context = new EntityContext(connectionStringName);
        }

        public EntityRepository(IRepository repo)
        {
            _canDisposeContext = false;
            _context = (DbContext)repo.Store;
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T SingleOrDefault(Func<T, bool> predicate)
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }

        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public bool Any()
        {
            return _context.Set<T>().Any();
        }

        public bool Any(Func<T, bool> predicate)
        {
            return _context.Set<T>().Any(predicate);
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }


        public IEnumerable<T> AsEnumerable
        {
            get { return _context.Set<T>(); }
        }

        public object Store { get { return _context; } }

        public virtual void Dispose()
        {
            if (_canDisposeContext)
                _context.Dispose();
            _isDisposed = true;
        }
        private bool _isDisposed;
        public bool IsDisposed
        {
            get { return _isDisposed; }
        }
    }
}
