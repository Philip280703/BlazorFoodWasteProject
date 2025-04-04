using BlazorFoodWasteProject.Client;
using BlazorFoodWasteProject.Client.Services.Interfaces;
using BlazorFoodWasteProject.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// DI for FoodWasteService
builder.Services.AddScoped<IFoodWasteService, FoodWasteService>();


await builder.Build().RunAsync();
