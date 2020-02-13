using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaZero.Infra.Data.User.Mapping
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasBaseType<AppIdentityUser>();
            builder.Property(a => a.CPF).IsRequired().HasColumnName("cpf");
            builder.Property(a => a.BirthDay).IsRequired().HasColumnName("birth_day");
            builder.Property(a => a.FirstName).IsRequired().HasColumnName("first_name");
            builder.Property(a => a.LastName).IsRequired().HasColumnName("last_name");
            builder.Property(a => a.Gender).IsRequired().HasColumnName("gender");
        }
    }
}
