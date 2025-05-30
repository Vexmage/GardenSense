namespace GardenSense.Models
{
    public class SensorReading
    {
        public int Id { get; set; }
        public int GardenZoneId { get; set; }
        public GardenZone Zone { get; set; } = default!;
        public DateTime Timestamp { get; set; }

        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double LightLevel { get; set; }
        public double SoilMoisture { get; set; }
    }
}
