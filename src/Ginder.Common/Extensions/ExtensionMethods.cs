using System;
using System.Linq;
using System.Web;

namespace Ginder.Common.Extensions
{
    public static class ExtensionMethods {
        public static string GetQueryString(this object obj) {
            var properties = from p in obj.GetType().GetProperties()
                where p.GetValue(obj, null) != null
                select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }

        public static string GetParameters(this object obj) {
            var properties = from p in obj.GetType().GetProperties()
                where p.GetValue(obj, null) != null
                select HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("/", properties.ToArray());
        }
    }
}