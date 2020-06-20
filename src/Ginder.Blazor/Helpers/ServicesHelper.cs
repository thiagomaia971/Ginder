using Ginder.Blazor.Repositories;
using Ginder.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ginder.Blazor.Helpers
{
    public static class ServicesHelper
    {
        public static void ConfigureCommonServices(IServiceCollection services)
        {
            //Add services shared between multiples project here
            services.AddBlazorMobileNativeServices<Program>();
            services.AddTransient<ILoginRepository, LoginRepository>();
        }
    }
}
