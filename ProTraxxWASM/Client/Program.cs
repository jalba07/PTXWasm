using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProTraxxWASM.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//add local storage
builder.Services.AddSingleton<Utilities.ILocalStorage, Utilities.LocalStorage>();

builder.Services.AddScoped(sp =>
   new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



await builder.Build().RunAsync();
