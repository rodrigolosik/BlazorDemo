using BlazorDemo;
using BlazorDemo.Core.Configuration;
using BlazorDemo.Core.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var appSettings = new AppSettings();
builder.Configuration.Bind(appSettings);
builder.Services.AddServices();
builder.Services.AddHttpClients(builder);
builder.Services.AddRefit(appSettings);

await builder.Build().RunAsync();
