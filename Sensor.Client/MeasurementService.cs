using System.Net.Http.Json;
using Sensor.Models;

namespace Sensor.Client.Services
{
    public class MeasurementService
    {
        private readonly HttpClient _http;

        public MeasurementService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Measurement>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Measurement>>("api/measurements");
        }


        public async Task<Measurement> AddAsync(double value)
        {
            var data = new Measurement { Value = value };
            var response = await _http.PostAsJsonAsync("api/Measurements", data);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Measurement>();
        }

        public async Task ClearAsync()
        {
            await _http.DeleteAsync("api/Measurements");
        }
    }
}
