using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaZero.Infra.Data.User.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppIdentityUser>
    {
        public void Configure(EntityTypeBuilder<AppIdentityUser> builder)
        {
            builder
                .HasMany(a => a.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasMany(a => a.Phones)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        }
    }
}
