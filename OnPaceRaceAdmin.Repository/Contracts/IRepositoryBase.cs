using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnPaceRaceAdmin.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
{
        IQueryable<TEntity> FindAll();
        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
        void Save();
    }
} 
