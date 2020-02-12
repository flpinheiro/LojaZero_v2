using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.Infra.Data.User.Mapping;
using LojaZero.UserDomain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaZero.Infra.Data.User.Context
{
    public class UserDbContext : IdentityDbContext<AppUser>
    {
        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(new AppUserMap().Configure);
            builder.Entity<Person>(new PersonMap().Configure);
            builder.Entity<Company>(new CompanyMap().Configure);
            builder.Entity<Address>(new AddrassMap().Configure);
            builder.Entity<Phone>(new PhoneMap().Configure);
        }
    }
}
