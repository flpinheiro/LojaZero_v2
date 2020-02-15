using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.Domain.Entity;
using LojaZero.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LojaZero.Infra.Data.Context
{
    public class DomainDbContext : DbContext
    {
        public DomainDbContext()
        {
        }

        public DomainDbContext(DbContextOptions<DomainDbContext> options) 
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(new ProductMap().Configure);
        }
    }
}
