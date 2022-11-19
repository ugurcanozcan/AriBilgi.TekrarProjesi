using AriBilgi.TekrarProjesi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=EGITMEN; Initial Catalog=TekrarProjesi; Integrated Security=True");
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
