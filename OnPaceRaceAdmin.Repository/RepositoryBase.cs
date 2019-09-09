
using OnPaceRaceAdmin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnPaceRaceAdmin.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationContext context { get; set; }
        public RepositoryBase(ApplicationContext context)
        {
            this.context = context;
        }
        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
        }
        public void Delete(int id)
        {
            var entity = this.context.Set<T>().Find(id);
            if(entity != null)
            {
                this.context.Set<T>().Remove(entity);
            }
        }
        public IQueryable<T> FindAll()
        {
            return this.context.Set<T>();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>()
                .Where(expression);
        }
        public void Save()
        {
            this.context.SaveChanges();
        }
        public void Update(int id, T entity)
        {
            this.context.Set<T>().Update(entity);           
        }
    }
}
