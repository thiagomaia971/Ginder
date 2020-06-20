//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Ginder.Common.Interfaces;
//using Microsoft.JSInterop;
//using Xamarin.Essentials;

//namespace Ginder.Blazor.Server.Services
//{
//    public class XamarinBridge : IXamarinBridge
//    {
//        private readonly IJSRuntime _jsRuntime;

//        //public XamarinBridge(IJSRuntime jsRuntime) 
//        //    => _jsRuntime = jsRuntime;

//        public async Task<List<string>> DisplayAlert(string title, string msg, string cancel)
//        {
//            await _jsRuntime.InvokeAsync<bool>("alert", msg);
//            return new List<string>();
//        }

//        public Task<Location> GetLocation() 
//            => null;
//    }
//}
