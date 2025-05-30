namespace GardenSense.Models
{
    public class ActuatorStatus
    {
        public int Id { get; set; }
        public int GardenZoneId { get; set; }
        public GardenZone Zone { get; set; } = default!;
        public DateTime Timestamp { get; set; }

        public bool HeaterOn { get; set; }
        public bool FanOn { get; set; }
        public bool GrowLightsOn { get; set; }
    }
}
