using System;
using System.Collections.Generic;

namespace Platin.Application.Interfaces
{
    public interface IPostgreSQLAppServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByFilter(System.Linq.Expressions.Expression<Func<TEntity, bool>> consulta);
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
