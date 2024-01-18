using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Project;
using Project.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
var userState = new UserState();
userState.Initialize();
builder.Services.AddSingleton(userState);

var medService = new MedService();
medService.Initialize();
builder.Services.AddSingleton(medService);

await builder.Build().RunAsync();
