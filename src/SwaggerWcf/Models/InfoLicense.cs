using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace SwaggerWcf.Models
{
    public class InfoLicense
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }


    }
}
