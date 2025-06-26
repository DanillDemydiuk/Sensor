using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Sensor.Client;
using Sensor.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Важно: BaseAddress с https://localhost:7132/
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7132/") });


// Сервис для работы с API
builder.Services.AddScoped<MeasurementService>();

await builder.Build().RunAsync();
