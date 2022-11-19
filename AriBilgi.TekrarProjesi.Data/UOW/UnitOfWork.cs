using AriBilgi.TekrarProjesi.Data.Contexts;
using AriBilgi.TekrarProjesi.Data.Repository;
using AriBilgi.TekrarProjesi.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext _dataContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork()
        {
            _dataContext = new DataContext();
        }


        private IGenericRepository<Company> _companies { get; set; }
        private IGenericRepository<User> _user { get; set; }


        public IGenericRepository<Company> Companies => _companies ?? new GenericRepository<Company>(_dataContext);
        public IGenericRepository<User> Users => _user ?? new GenericRepository<User>(_dataContext);

        public void BeginTransaction()
        {
            if (_transaction == null)
                _transaction = _dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }
    }
}
