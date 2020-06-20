using BlazorMobile.Common;
using BlazorMobile.Components;
using Ginder.Helpers;
using BlazorMobile.Services;

namespace Ginder
{
	public partial class App : BlazorApplication
    {
        public App()
        {
            InitializeComponent();

            ServiceRegistrationHelper.RegisterServices();
            
#if DEBUG
            //This allow remote debugging features
            WebApplicationFactory.EnableDebugFeatures();
#endif
            WebApplicationFactory.SetHttpPort(8888);

            MainPage = new MainPage();
        }
    }
}
