//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 2022/5/19 17:14:38
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using BaseDB;
using IRepository_DB;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository_DB
{
    public partial class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        protected DbContext context = null;

        private IRepository<菜单> _菜单;

        private IRepository<角色_菜单> _角色_菜单s;

        private IRepository<用户_组织> _用户_组织s;

        private IRepository<组织> _组织;

        public EntityFrameworkUnitOfWork()
            : this(new BaseDB.BaseDbContext())
        {
        }

        public EntityFrameworkUnitOfWork(DbContext context)
        {
            this.context = context ?? throw new ArgumentNullException("context");
        }

        public DbContext Context => context;

        protected virtual void CloseContext()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        #region IDisposable Methods

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    CloseContext();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Methods

        #region IUnitOfWork Members

        public IRepository<菜单> 菜单
        {
            get
            {
                if (_菜单 == null)
                {
                    _菜单 = new EntityFrameworkRepository<菜单>(context);
                }

                return _菜单;
            }
        }

        public IRepository<角色_菜单> 角色_菜单s
        {
            get
            {
                if (_角色_菜单s == null)
                {
                    _角色_菜单s = new EntityFrameworkRepository<角色_菜单>(context);
                }

                return _角色_菜单s;
            }
        }

        public IRepository<用户_组织> 用户_组织s
        {
            get
            {
                if (_用户_组织s == null)
                {
                    _用户_组织s = new EntityFrameworkRepository<用户_组织>(context);
                }

                return _用户_组织s;
            }
        }

        public IRepository<组织> 组织
        {
            get
            {
                if (_组织 == null)
                {
                    _组织 = new EntityFrameworkRepository<组织>(context);
                }

                return _组织;
            }
        }

        public virtual void Save()
        {
            if (context == null)
            {
                throw new InvalidOperationException("Context has not been initialized.");
            }

            context.SaveChanges();
        }

        #endregion IUnitOfWork Members
    }
}