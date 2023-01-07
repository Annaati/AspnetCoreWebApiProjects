using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI.Models
{
    public class Link
    {
        public const string GetMethod = "GET";


        public static Link To(string routeName, object routeValues = null)
               => new Link
               {
                   RouteName = routeName,
                   RouteValues = routeValues,
                   Method = GetMethod,
                   Relations = null
               };

        public static Link ToCollection(string routeName, object routeValues = null)
              => new Link
              {
                  RouteName = routeName,
                  RouteValues = routeValues,
                  Method = GetMethod,
                  Relations = new[] { "collection" }
              };

        [JsonProperty(Order = -4)]
        public string Href { get; set; }


        [JsonProperty(Order = -3, 
                PropertyName = "rel", 
                NullValueHandling = NullValueHandling.Ignore)]
        public string[] Relations { get; set; }


        [JsonProperty(Order = -2, 
                DefaultValueHandling = DefaultValueHandling.Ignore, 
                NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(GetMethod)]
        public string Method { get; set; }


        // stores the route name before being rewritten by the linkRewrittingFilter 
        [JsonIgnore]
        public String RouteName { get; set; }

        // stores the route parameters before being rewritten by the linkRewrittingFilter 
        [JsonIgnore]
        public object RouteValues { get; set; }
    }
}
