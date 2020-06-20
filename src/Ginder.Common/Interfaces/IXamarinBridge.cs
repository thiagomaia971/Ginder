using BlazorMobile.Common.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Ginder.Common.Interfaces
{
    [ProxyInterface]
    public interface IXamarinBridge
    {
        Task<List<string>> DisplayAlert(string title, string msg, string cancel);
        Task<Location> GetLocation();
    }
}
