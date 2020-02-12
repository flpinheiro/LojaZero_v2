using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaZero.Infra.Data.User.Mapping
{
    public class AddrassMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");
            builder.HasKey(a=> new {a.AppUserId, a.ZipCode, a.Number});

            builder.Property(a => a.AppUserId).HasColumnName("user_id");
            builder.Property(a => a.ZipCode).IsRequired().HasColumnName("zip_code");
            builder.Property(a => a.Number).IsRequired().HasColumnName("number");
            builder.Property(a => a.State).HasColumnName("state");
            builder.Property(a => a.Street).HasColumnName("street");
            builder.Property(a => a.Complement).HasColumnName("complement");
            builder.Property(a => a.Country).HasColumnName("country");
        }
    }
}
