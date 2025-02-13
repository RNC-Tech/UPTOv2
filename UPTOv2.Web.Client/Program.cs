using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UPTOv2.Shared.Services;
using UPTOv2.Web.Client.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the UPTOv2.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
await builder.Build().RunAsync();
