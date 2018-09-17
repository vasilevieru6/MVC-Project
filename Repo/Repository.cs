using Models;
using Models.Domain;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repo
{
    public class Repository : IRepository
    {
        protected readonly ShopDbContext context;

        public Repository(ShopDbContext context)
        {
            this.context = context;
        }

        public void Add<T>(T entity) where T : Entity
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : Entity
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<T> GetAll<T>() where T : Entity
        {
            return context.Set<T>();
        }

        public T GetById<T>(long id) where T : Entity
        {
            return context.Set<T>().Find(id);
        }

        public void Update<T>(T entity) where T : Entity
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        
    }
}
