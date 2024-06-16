using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Workplace.Client;
using Workplace.Client.Data.Schedule;
using Workplace.Client.Data.Tasks;
using Workplace.Shared.Schedule;
using Workplace.Shared.Tasks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IDataService, MockData>();
builder.Services.AddSingleton<IScheduleDataService, ScheduleMockData>();

await builder.Build().RunAsync();
