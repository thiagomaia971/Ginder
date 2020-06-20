using BlazorMobile.Common;
using BlazorMobile.Common.Services;
using Ginder.Blazor.Helpers;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ginder.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            #region Services registration

            ServicesHelper.ConfigureCommonServices(builder.Services);

            #endregion


            BlazorMobileService.OnBlazorMobileLoaded += (object source, BlazorMobileOnFinishEventArgs eventArgs) =>
            {
                Console.WriteLine($"Initialization success: {eventArgs.Success}");
                Console.WriteLine("Device is: " + BlazorDevice.RuntimePlatform);
            };

            builder.RootComponents.Add<MobileApp>("app");

            await builder.Build().RunAsync();
        }
    }
}
