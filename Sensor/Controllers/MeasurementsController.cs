using Microsoft.AspNetCore.Mvc;
using Sensor.Data;

[ApiController]
[Route("api/[controller]")]
public class MeasurementsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MeasurementsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var measurements = await _context.Measurements.ToListAsync();
        return Ok(measurements);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Measurement measurement)
    {
        _context.Measurements.Add(measurement);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = measurement.Id }, measurement);
    }
}
