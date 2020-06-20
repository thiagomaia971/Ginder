﻿//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Ginder.Common.Extensions;
//using Ginder.Common.Interfaces;
//using Newtonsoft.Json;

//namespace Ginder.Services.Repositories
//{
//    public abstract class Repository : IRepository
//    {
//        public string BaseApi => "http://8f8f322f4b78.ngrok.io";
//        public abstract string Action { get; }

//        public async Task<T> Get<T>(object parameters = null, object queryString = null)
//        {
//            using (var httpClient = CreateHttpClient())
//            {
//                var action = BuildAction(parameters, queryString);
//                var result = await httpClient.GetAsync(action);
//                var resultObj = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
//                return resultObj;
//            }
//        }

//        private string BuildAction(object parameters, object queryString)
//        {
//            var action = Action;

//            if (parameters != null)
//                action += $"/{parameters.GetParameters()}";

//            if (queryString != null)
//                action += $"/{parameters.GetQueryString()}";

//            return action;
//        }

//        private HttpClient CreateHttpClient() 
//            => new HttpClient() {BaseAddress = new Uri(BaseApi)};
//    }
//}