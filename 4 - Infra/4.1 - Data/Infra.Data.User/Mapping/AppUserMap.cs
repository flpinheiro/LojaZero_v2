using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaZero.Infra.Data.User.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder
                .HasMany(a => a.Addresses)
                .WithOne(a => a.AppUser)
                .HasForeignKey(a => a.AppUserId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasMany(a => a.Phones)
                .WithOne(a => a.AppUser)
                .HasForeignKey(a => a.AppUserId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        }
    }
}
