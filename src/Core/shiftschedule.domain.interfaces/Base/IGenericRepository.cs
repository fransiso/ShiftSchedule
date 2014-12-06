using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShiftSchedule.Domain.Entities.Base;

namespace ShiftSchedule.Domain.Interfaces.Base
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        TEntity Delete(TEntity entity);
        void Edit(TEntity entity);
        void Save();
    }
}
