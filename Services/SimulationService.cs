using GardenSense.Data;
using GardenSense.Models;

namespace GardenSense.Services
{
    public class SimulationService
    {
        private readonly GardenContext _db;
        private readonly Random _rand = new();

        public SimulationService(GardenContext db)
        {
            _db = db;
        }

        public async Task GenerateSensorDataAsync()
        {
            var zones = _db.Zones.ToList();

            foreach (var zone in zones)
            {
                var reading = new SensorReading
                {
                    GardenZoneId = zone.Id,
                    Timestamp = DateTime.Now,
                    Temperature = Math.Round(65 + _rand.NextDouble() * 15, 1),   // °F
                    Humidity = Math.Round(30 + _rand.NextDouble() * 40, 1),     // %
                    LightLevel = Math.Round(200 + _rand.NextDouble() * 600, 0), // Lumens
                    SoilMoisture = Math.Round(20 + _rand.NextDouble() * 60, 1)  // %
                };

                _db.SensorReadings.Add(reading);
            }

            await _db.SaveChangesAsync();
        }
    }
}
