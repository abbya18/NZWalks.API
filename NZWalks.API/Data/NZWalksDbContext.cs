using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext: DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions) 
        { 
                               
            
        }

        // All these properties represent collection inside our database --> these three will make tables inside our database in the future
        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data from Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("f70ccf97-acc0-4e11-b00a-2f3cba06ab75"),
                    Name = "Easy"
                },

                new Difficulty()
                {
                    Id = Guid.Parse("4528a864-e1dc-4ca1-9137-89eaca2a2f5b"),
                    Name = "Medium"
                },

                new Difficulty()
                {
                    Id = Guid.Parse("49bf7e61-c270-4696-bc73-c99e65cdb2ab"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("462ad8fc-16d1-4012-9a6f-a35ccb1c900b"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },

                new Region
                {
                    Id = Guid.Parse("d4095cb5-5d90-4f0f-9daa-ae70f3d7bab4"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = "null"
                },

                new Region
                {
                    Id = Guid.Parse("2f6a9dcc-3521-4051-8ede-3287f9f4329c"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = "null"
                },

                new Region
                {
                    Id = Guid.Parse("5df0ecf3-4591-4586-986e-1f36a5951f1e"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "a_wellington_image.png"
                },

                new Region
                {
                    Id = Guid.Parse("a0fb25ed-c44b-4484-93ac-d876f642cfce"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },

                new Region
                {
                    Id = Guid.Parse("2e341708-e99a-4e0b-b7e3-361858456129"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = "null"
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
