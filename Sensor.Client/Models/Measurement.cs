namespace Sensor.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public double Converted { get; set; }
        public DateTime Time { get; set; }
    }
}
