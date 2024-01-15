using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Project;
using Project.Models;
using Project.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var DbPath = System.IO.Path.Join(path, "MedAppDataBase.db");
builder.Services.AddDbContext<Data>(options => options.UseSqlite(DbPath));
builder.Services.AddTransient<DbApi>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
var userState = new UserState();
userState.Initialize();
builder.Services.AddSingleton(userState);

var medService = new MedService();
medService.Initialize();
builder.Services.AddSingleton(medService);

Console.WriteLine(DbPath);
await builder.Build().RunAsync();
