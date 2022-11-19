using AriBilgi.TekrarProjesi.Data.Repository;
using AriBilgi.TekrarProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Data.UOW
{
    public interface IUnitOfWork
    {
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<User> Users { get; }

        int SaveChanges();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
