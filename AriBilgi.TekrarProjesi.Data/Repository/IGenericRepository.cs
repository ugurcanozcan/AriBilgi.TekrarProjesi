using AriBilgi.TekrarProjesi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Data.Repository
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        void Add(T entity);
        void Delete(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> Get();
    }
}
