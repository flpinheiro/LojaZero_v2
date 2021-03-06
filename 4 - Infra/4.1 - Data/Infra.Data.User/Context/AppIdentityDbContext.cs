﻿using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.Infra.Data.User.Mapping;
using LojaZero.UserDomain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaZero.Infra.Data.User.Context
{
    public class AppIdentityDbContext : IdentityDbContext<AppIdentityUser>
    {
        public string ConnectionString { get; set; }
        public AppIdentityDbContext()
        {
        }

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebApplication;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppIdentityUser>(new AppUserMap().Configure);
            builder.Entity<Person>(new PersonMap().Configure);
            builder.Entity<Company>(new CompanyMap().Configure);
            builder.Entity<Address>(new AddressMap().Configure);
            builder.Entity<Phone>(new PhoneMap().Configure);
        }
    }
}
