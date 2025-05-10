using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Enums;

namespace PlayerManagement.Data.Context.EntityTypeConfigurations
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

            builder.HasData(new List<Player>
            {
                new Player()
                {
                    Id = 1,
                    FullName = "Kylian Mbappe",
                    Height = 178,
                    DateOfBirth = DateTime.Parse("20.12.1998"),
                    Position = Position.CentreForward.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 1,
                },
                new Player()
                {
                    Id = 2,
                    FullName = "Luka Modric",
                    Height = 172,
                    DateOfBirth = DateTime.Parse("09.09.1985"),
                    Position = Position.Midfielder.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 1,
                },
                new Player()
                {
                    Id = 3,
                    FullName = "Daniel Carvajal",
                    Height = 173,
                    DateOfBirth = DateTime.Parse("11.01.1992"),
                    Position = Position.RightBack.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 1,
                },
                new Player()
                {
                    Id = 4,
                    FullName = "Lucas Vazquez",
                    Height = 173,
                    DateOfBirth = DateTime.Parse("01.07.1991"),
                    Position = Position.RightBack.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 1,
                },

                new Player()
                {
                    Id = 5,
                    FullName = "Troy Parrott",
                    Height = 185,
                    DateOfBirth = DateTime.Parse("04.02.2002"),
                    Position = Position.CentreForward.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 2,
                },
                new Player()
                {
                    Id = 6,
                    FullName = "Mees de Wit",
                    Height = 181,
                    DateOfBirth = DateTime.Parse("17.04.1998"),
                    Position = Position.LeftBack.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 2,
                },
                new Player()
                {
                    Id = 7,
                    FullName = "Mexx Meerdink",
                    Height = 182,
                    DateOfBirth = DateTime.Parse("24.07.2003"),
                    Position = Position.CentreForward.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 2,
                },
                new Player()
                {
                    Id = 8,
                    FullName = "Zico Buurmeester",
                    Height = 184,
                    DateOfBirth = DateTime.Parse("07.06.2002"),
                    Position = Position.Midfielder.ToString(),
                    CreatedDate = DateTime.Parse("05.10.2025"),
                    TeamId = 2,
                }
            });
        }
    }
}
