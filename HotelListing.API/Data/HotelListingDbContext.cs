using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext (DbContextOptions options) : base(options)
        {
                    
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "Ind",
                },
                new Country
                {
                    Id = 2,
                    Name = "Russia",
                    ShortName = "Rus",
                },
                new Country
                {
                    Id = 3,
                    Name = "China",
                    ShortName = "Ch",
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Tata",
                    Address = "Bangalore",
                    CountryId = 1,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Atoz",
                    Address = "Bejing",
                    CountryId = 3,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Trump",
                    Address = "Moscow",
                    CountryId = 2,
                    Rating = 4.5
                }
                );
        }
    }
}
