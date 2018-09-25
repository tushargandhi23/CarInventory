using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CarInventory.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //Here DBEntities is out context  
        protected readonly CarInventoryEntities db;
        public Repository(CarInventoryEntities context)
        {
            db = context;
        }
        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }
        
        public void Remove(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }
      
        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }
     
        public TEntity Edit(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}