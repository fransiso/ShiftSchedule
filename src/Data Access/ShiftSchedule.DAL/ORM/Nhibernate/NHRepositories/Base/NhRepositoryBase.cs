using NHibernate;
using NHibernate.Linq;
using ShiftSchedule.DAL.ORM.Nhibernate.UoW;
using ShiftSchedule.Domain.Entities.Base;
using ShiftSchedule.Domain.Interfaces.Base;

namespace ShiftSchedule.DAL.ORM.Nhibernate.NHRepositories.Base
{
    /// <summary>
    /// Base class for all repositories those uses NHibernate.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class NhRepositoryBase<TEntity> : IGenericRepository<TEntity> 
    {
        /// <summary>
        /// Gets the NHibernate session object to perform database operations.
        /// </summary>
        protected ISession Session { get { return NhUnitOfWork.Current.Session; } }

        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        public void Add(TEntity obj)
        {
            Session.Save(obj);
        }

        public TEntity GetById(int id)
        {
            return Session.Get<TEntity>(id);
        }

        System.Collections.Generic.IEnumerable<TEntity> IGenericRepository<TEntity>.GetAll()
        {
            return Session.Query<TEntity>();
        }

        public void Remove(TEntity obj)
        {
            Session.Delete(Session.Load<TEntity>(obj));
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }


        public System.Collections.Generic.IEnumerable<TEntity> FindBy(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        TEntity IGenericRepository<TEntity>.Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}