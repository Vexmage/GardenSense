using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using GardenSense.Models;

namespace GardenSense.Data
{
    public class GardenContextFactory : IDesignTimeDbContextFactory<GardenContext>
    {
        public GardenContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GardenContext>();
            optionsBuilder.UseSqlite("Data Source=gardensense.db");

            return new GardenContext(optionsBuilder.Options);
        }
    }
}
