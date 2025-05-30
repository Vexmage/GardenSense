namespace GardenSense.Models
{
    public class GardenZone
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public ICollection<SensorReading> SensorReadings { get; set; } = new List<SensorReading>();
        public ICollection<ActuatorStatus> ActuatorStatuses { get; set; } = new List<ActuatorStatus>();
    }
}
