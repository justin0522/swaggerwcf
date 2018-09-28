using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class Info
    {
        [JsonProperty("title", Required = Required.Always)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("termsOfService")]
        public string TermsOfService { get; set; }

        [JsonProperty("contact")]
        public InfoContact Contact { get; set; }

        [JsonProperty("license")]
        public InfoLicense License { get; set; }

        [JsonProperty("version", Required = Required.Always)]
        public string Version { get; set; }
    }
}
