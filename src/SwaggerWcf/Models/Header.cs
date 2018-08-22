using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class Header
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("collectionFormat")]
        public string CollectionFormat { get; set; }

        [JsonProperty("default")]
        public string _default { get; set; }

        // TODO: other properties

    }
}
