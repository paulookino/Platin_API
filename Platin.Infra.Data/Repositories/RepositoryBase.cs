﻿using Platin.Domain.Interfaces.Repositories;
using Platin.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Platin.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected PlatinContext db = new PlatinContext();

        public TEntity Add(TEntity obj)
        {
            var entity = db.Set<TEntity>().Add(obj);

            db.SaveChanges();

            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetByFilter(System.Linq.Expressions.Expression<Func<TEntity, bool>> consulta)
        {
            return db.Set<TEntity>().Where(consulta).ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {


            db.Set<TEntity>().Attach(obj);
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            db.Set<TEntity>().AddOrUpdate(obj);
            db.SaveChanges();
        }
    }
}
