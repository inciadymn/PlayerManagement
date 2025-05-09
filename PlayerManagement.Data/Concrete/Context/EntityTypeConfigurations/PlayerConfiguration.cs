using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayerManagement.Model.Entities;

namespace PlayerManagement.Data.Concrete.Context.EntityTypeConfigurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(a => a.FullName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.DateOfBirth)
                   .IsRequired();

            builder.Property(a => a.Height)
                   .IsRequired();

            builder.Property(a => a.Position)
               .HasMaxLength(50)
               .IsRequired();
        }
    }
}
