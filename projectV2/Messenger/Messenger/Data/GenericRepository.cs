using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data
{
    public abstract class GenericRepository<T> : IDisposable, IRepository<T> where T : class
    {
        protected MessangerContext context;
        protected DbSet<T> dbSet;


        public GenericRepository()
        {
            context = new MessangerContext();
            dbSet = context.Set<T>();
        }

        public virtual void Create(T item)
        {
            dbSet.Add(item);
        }
       
        public virtual void Delete(int id)
        {
            T item = dbSet.Find(id);
            if (item != null)
            {
                dbSet.Remove(item);
            }
        }

        public virtual T GetItem(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetItemList()
        {
            return dbSet.ToList<T>();
        }
        

        public abstract void Update(T item);

        public virtual void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }
    }
}
