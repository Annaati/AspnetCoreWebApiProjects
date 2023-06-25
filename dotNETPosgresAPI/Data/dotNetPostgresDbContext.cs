using dotNETPosgresAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotNETPosgresAPI.Data
{
    public class dotNetPostgresDbContext : DbContext
    {

        protected readonly IConfiguration _config;

        public dotNetPostgresDbContext(DbContextOptions<dotNetPostgresDbContext> options) : base(options)
        {
        }


        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config.GetConnectionString("POSTGRES_CONNSTR"));
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Roles>()
        //        .HasMany(u => u.Users)
        //        .WithOne(r => r.Role)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}

    }
}
