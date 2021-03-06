//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 2022/5/19 17:14:38
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using IRepository_DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Repository_DB
{
    public partial class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;
        protected DbSet<T> objectSet;

        public EntityFrameworkRepository(DbContext context)
        {
            this.context = context ?? throw new ArgumentNullException("context");
            objectSet = context.Set<T>();
        }

        public virtual IQueryable<T> All()
        {
            return objectSet;
        }

        public virtual void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            objectSet.Add(entity);
        }

        public virtual void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            objectSet.Remove(entity);
        }

        public DbContext Context => context;
    }
}