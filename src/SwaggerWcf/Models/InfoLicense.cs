using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class InfoLicense
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
