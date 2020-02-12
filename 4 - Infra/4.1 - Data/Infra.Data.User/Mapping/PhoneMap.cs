using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaZero.Infra.Data.User.Mapping
{
    public class PhoneMap : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(a=> new{ a.AppUserId, a.Number, a.CountryCode, a.AreaCode});
            builder.Property(a => a.AppUserId).HasColumnName("user_id");
            builder.Property(a => a.AreaCode).IsRequired().HasColumnName("area_code");
            builder.Property(a => a.CountryCode).IsRequired().HasColumnName("country_code").HasDefaultValue("55");
            builder.Property(a => a.Number).IsRequired().HasColumnName("number");
        }
    }
}
