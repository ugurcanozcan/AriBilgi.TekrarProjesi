using AriBilgi.TekrarProjesi.Data.Contexts;
using AriBilgi.TekrarProjesi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private DataContext _dataContext;

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        

        public void Add(T entity)
        {
            _dataContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dataContext.Set<T>().Where(predicate);
        }

        public IQueryable<T> Get()
        {
            return _dataContext.Set<T>();
        }
    }
}
