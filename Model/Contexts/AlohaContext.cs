using Aloha.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aloha.Models.Contexts
{
    public class AlohaContext : DbContext
    {
        public AlohaContext(DbContextOptions<AlohaContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Workstation> Workstations { get; set; }

        public DbSet<Floor> Floors { get; set; }

        public DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Worker>()
                .HasIndex(u => u.UserId)
                .IsUnique();
        }
    }
}