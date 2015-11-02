using MLP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MLP.Data
{
    public class GenericRepository<T>:IRepository<T> where T : class
    {
        private MLPContext db = null;
        private DbSet<T> table = null;
        protected MLPContext DataContext
        {
            get { return db ?? (db = new MLPContext()); }
        }

        public GenericRepository()
        {
            this.db = DataContext;
            table = db.Set<T>();
        }
        public GenericRepository(MLPContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }

        public T SelectByID(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update (T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    
}

