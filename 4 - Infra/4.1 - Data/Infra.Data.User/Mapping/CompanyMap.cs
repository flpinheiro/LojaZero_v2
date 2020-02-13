using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaZero.Infra.Data.User.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasBaseType<AppIdentityUser>();
            builder.Property(a => a.CNPJ).IsRequired().HasColumnName("cnpj").HasMaxLength(14);
            builder.Property(a => a.CompanyName).IsRequired().HasColumnName("company_name");
        }
    }
}
