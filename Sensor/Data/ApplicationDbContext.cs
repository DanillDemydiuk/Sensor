using Microsoft.EntityFrameworkCore;
using Sensor.Models;

namespace Sensor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Measurement> Measurements { get; set; }
    }
}
