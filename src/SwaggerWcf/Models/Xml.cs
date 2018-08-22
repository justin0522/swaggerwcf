using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class Xml
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("attribute")]
        public bool Attribute { get; set; }

        [JsonProperty("wrapped")]
        public bool Wrapped { get; set; }

    }
}
