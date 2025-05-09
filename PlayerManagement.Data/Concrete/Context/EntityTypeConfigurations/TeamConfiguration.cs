using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Enums;

namespace PlayerManagement.Data.Concrete.Context.EntityTypeConfigurations
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
                .HasForeignKey(a => a.TeamId);

            builder.HasData(new List<Team>()
            {
                new Team()
                {
                    Id = 1,
                    Name = "Real Madrid",
                    Country = "Spain",
                    CreatedDate = DateTime.Now,
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = 1,
                            FullName = "Kylian Mbappe",
                            Height = 178,
                            DateOfBirth = DateTime.Parse("12.20.1998"),
                            Position = Position.CentreForward.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 1
                        },
                        new Player()
                        {
                            Id = 2,
                            FullName = "Luka Modric",
                            Height = 172,
                            DateOfBirth = DateTime.Parse("09.09.1985"),
                            Position = Position.Midfielder.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 1
                        },
                        new Player()
                        {
                            Id = 3,
                            FullName = "Daniel Carvajal",
                            Height = 173,
                            DateOfBirth = DateTime.Parse("01.11.1992"),
                            Position = Position.RightBack.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 1
                        },
                        new Player()
                        {
                            Id = 4,
                            FullName = "Lucas Vazquez",
                            Height = 173,
                            DateOfBirth = DateTime.Parse("07.01.1991"),
                            Position = Position.RightBack.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 1
                        }
                    }
                },

                 new Team()
                {
                    Id = 2,
                    Name = "AZ Alkmaar",
                    Country = "Netherlands",
                    CreatedDate = DateTime.Now,
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = 1,
                            FullName = "Troy Parrott",
                            Height = 185,
                            DateOfBirth = DateTime.Parse("02.04.2002"),
                            Position = Position.CentreForward.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 2
                        },
                        new Player()
                        {
                            Id = 2,
                            FullName = "Mees de Wit",
                            Height = 181,
                            DateOfBirth = DateTime.Parse("04.17.1998"),
                            Position = Position.LeftBack.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 2
                        },
                        new Player()
                        {
                            Id = 3,
                            FullName = "Mexx Meerdink",
                            Height = 182,
                            DateOfBirth = DateTime.Parse("07.24.2003"),
                            Position = Position.CentreForward.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 2
                        },
                        new Player()
                        {
                            Id = 4,
                            FullName = "Zico Buurmeester",
                            Height = 184,
                            DateOfBirth = DateTime.Parse("06.07.2002"),
                            Position = Position.Midfielder.ToString(),
                            CreatedDate = DateTime.Now,
                            TeamId = 2
                        }
                    }
                }
            });
        }
    }
}
