using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Repo
{
    public interface IRepository : IDisposable
    {
        object Store { get; }
    }

    public interface IRepository<T> : IRepository
    {
        bool IsDisposed { get; }

        void Add(T entity);

        void Remove(T entity);

        T SingleOrDefault(Func<T, bool> predicate);

        IEnumerable<T> Where(Func<T, bool> predicate);

        bool Any();

        bool Any(Func<T, bool> predicate);

        IEnumerable<T> AsEnumerable { get; }

        void SaveChanges();

    }
}
