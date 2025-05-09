using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayerManagement.Model.Entities;

namespace PlayerManagement.Data.Context.EntityTypeConfigurations
{
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .IsRequired();

            builder.Property(a => a.CreatedDate)
                   .IsRequired();

            builder.Property(a => a.UpdatedDate)
                   .IsRequired(false);
        }
    }
}
