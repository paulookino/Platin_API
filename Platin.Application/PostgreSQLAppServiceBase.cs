using Platin.Application.Interfaces;
using Platin.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Platin.Application
{
    public class PostgreSQLAppServiceBase<TEntity> : IPostgreSQLAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IPostgreSQLServiceBase<TEntity> _serviceBase;

        public PostgreSQLAppServiceBase(IPostgreSQLServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public virtual TEntity Add(TEntity obj)
        {
            return _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity, bool>> consulta)
        {
            return _serviceBase.GetByFilter(consulta);
        }
    }
}
