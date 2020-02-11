using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.UserDomain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaZero.Infra.Data.User.Context
{
    public class UserDbContext : IdentityDbContext
    {
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

            builder.Entity<Address>().HasKey(a => new { a.PersonId, a.ZipCode, a.Number });
            builder.Entity<Phone>().HasKey(a => new {a.PersonId, a.Number, a.AreaCode, a.CountryCode});

            builder.Entity<Person>()
                .HasMany(a => a.Addresses)
                .WithOne(a => a.Person)
                .HasForeignKey(a => a.PersonId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder.Entity<Person>()
                .HasMany(a => a.Phones)
                .WithOne(a => a.Person)
                .HasForeignKey(a => a.PersonId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        }
    }
}
