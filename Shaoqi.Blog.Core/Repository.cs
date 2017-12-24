using Microsoft.EntityFrameworkCore;
using Shaoqi.Blog.Api;
using System;

namespace Shaoqi.Blog.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DbContext unitofdata = null;
        protected readonly DbSet<T> dbSet;


        public DbContext DataContext
        {
            get
            {
                return unitofdata;
            }
        }

        public DbSet<T> Dbset
        {
            get
            {
                return this.dbSet;
            }
        }

        public Repository(DbContext unitofdata)
        {
            this.unitofdata = unitofdata;
            this.dbSet = this.DataContext.Set<T>();
        }

        public void Add(T entity)
        {
            this.dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            this.dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            this.dbSet.Update(entity);
        }
    }
}
