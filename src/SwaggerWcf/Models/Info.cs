using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class Info
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("termsOfService")]
        public string TermsOfService { get; set; }

        [JsonProperty("contact")]
        public InfoContact Contact { get; set; }

        [JsonProperty("license")]
        public InfoLicense License { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        
    }
}
