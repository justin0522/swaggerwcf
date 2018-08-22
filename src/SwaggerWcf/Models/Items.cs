using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    internal class Items
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("collectionFormat")]
        public string CollectionFormat { get; set; }

        // TODO: other properties

    }
}
