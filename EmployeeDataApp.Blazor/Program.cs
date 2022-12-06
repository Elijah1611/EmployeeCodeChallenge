using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmployeeDataApp.Blazor;
using EmployeeDataApp.Blazor.Services;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client => client.BaseAddress = new Uri("https://localhost:7250/"));

builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();