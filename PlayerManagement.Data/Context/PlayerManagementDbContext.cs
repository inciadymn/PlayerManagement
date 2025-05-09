using Microsoft.EntityFrameworkCore;
using PlayerManagement.Data.Context.EntityTypeConfigurations;
using PlayerManagement.Model.Entities;

namespace PlayerManagement.Data.Context
{
    public class PlayerManagementDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=PlayerManagementDb; uid=sa; pwd=as");
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
        }
    }
}
