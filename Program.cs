using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using frontend_survey;
using frontend_survey.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var backendUrl = builder.Configuration["BackendUrl"] ?? builder.HostEnvironment.BaseAddress;
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(backendUrl) });

builder.Services.AddScoped<SurveyService>();

await builder.Build().RunAsync();
