﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepositoryPattern.Common
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, 
                                 Func<IQueryable<TEntity>, 
                                 IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "");
        TEntity? GetByID(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
