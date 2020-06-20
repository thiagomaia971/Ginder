using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorMobile.Common;
using Ginder.Common.Interfaces;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace Ginder.Services
{
    public class XamarinBridge : IXamarinBridge
    {
        public async Task<List<string>> DisplayAlert(string title, string msg, string cancel)
        {
            await App.Current.MainPage.DisplayAlert(title, msg, cancel);

            List<string> result = new List<string>()
                    {
                        "Lorem",
                        "Ipsum",
                        "Dolorem",
                    };

            return result;
        }

        public async Task<Location> GetLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                return await Geolocation.GetLocationAsync(request);
            }
            catch (Exception ex)
            {
                // Unable to get location
                DisplayAlert("Erro ao pegar Geolocalização", JsonConvert.SerializeObject(ex), "Ok");
            }

            return null;
        }
    }
}
