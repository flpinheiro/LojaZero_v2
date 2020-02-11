using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.Domain.Entity;
using LojaZero.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LojaZero.Infra.Data.Context
{
    public class DomainDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(new ProductMap().Configure);
        }
    }
}
