using Microsoft.EntityFrameworkCore;
using PlayerManagement.Data.Context.EntityTypeConfigurations;
using PlayerManagement.Model.Entities;

namespace PlayerManagement.Data.Context
{
    public class PlayerManagementDbContext : DbContext
    {
        public PlayerManagementDbContext(DbContextOptions<PlayerManagementDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
