using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Enums;

namespace PlayerManagement.Data.Context.EntityTypeConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Country)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(a => a.Players)
                .WithOne(a => a.Team)
                .HasForeignKey(a => a.TeamId)
                .IsRequired(false);

            builder.HasData(new List<Team>()
            {
                new Team()
                {
                    Id = 1,
                    Name = "Real Madrid",
                    Country = "Spain",
                    CreatedDate = DateTime.Parse("05.10.2025")
                },
                new Team()
                {
                    Id = 2,
                    Name = "AZ Alkmaar",
                    Country = "Netherlands",
                    CreatedDate = DateTime.Parse("05.10.2025")
                }
            });
        }
    }
}
