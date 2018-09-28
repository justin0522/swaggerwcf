using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    [JsonObject]
    public class Items
    {
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("collectionFormat")]
        public string CollectionFormat { get; set; }

        // TODO: other properties

    }
}
