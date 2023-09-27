using CitiesManager.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace CitiesManager.WebAPI.Data
{
    public class MsSqlDbContext : DbContext
    {

        public MsSqlDbContext(DbContextOptions options) : base(options) { }

        public MsSqlDbContext()
        {

        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuring Default Values
            modelBuilder.Entity<City>().Property(c => c.RegAt).HasDefaultValue(DateTime.Now);

            //Seed Data
            SeedCitiesWithSomeDefaultSampleData(modelBuilder);
        }

        private static void SeedCitiesWithSomeDefaultSampleData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City { 
                                                            CityId = Guid.Parse("A32054F2-54C9-4A95-91E6-1B24558573A6"),
                                                            CityCode = "MGQ",
                                                            CityName="Mogadishu",
                                                            Latitude= decimal.Parse("2.05368398776368"),
                                                            Longitude=decimal.Parse("45.31820111676328")
                                                         });
        }


    }
}
