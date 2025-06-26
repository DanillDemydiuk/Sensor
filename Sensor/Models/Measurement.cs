using System.ComponentModel.DataAnnotations;

namespace Sensor.Models
{
    public class Measurement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Value { get; set; }

        public double Converted { get; set; }

        public DateTime Time { get; set; }
    }
}
