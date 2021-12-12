using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace YourStory.BusinessLayer
{
    public class Repository<T> : RepositoryBase  where T : class
    {
        
        private DbSet<T> objectSet;
        public Repository()
        {
            objectSet = db.Set<T>();
        }
        public List<T> List()
        {
            return objectSet.ToList();

        }
        public List<T> List(Expression<Func<T,bool>>where)
        {
            return objectSet.Where(where).ToList();
        }
        
        public int Insert(T obj)
        {
            objectSet.Add(obj);
            return Save();
        }
        public int update(T obj)
        {
            return Save();
        }
        public int Delete(T obj)
        {
            objectSet.Remove(obj);
            return Save();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return objectSet.FirstOrDefault(where);
        }
    }
}
