using Microsoft.EntityFrameworkCore;
using GardenSense.Models;

namespace GardenSense.Data
{
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> options) : base(options) { }

        public DbSet<GardenZone> Zones => Set<GardenZone>();
        public DbSet<SensorReading> SensorReadings => Set<SensorReading>();
        public DbSet<ActuatorStatus> ActuatorStatuses => Set<ActuatorStatus>();
    }
}
