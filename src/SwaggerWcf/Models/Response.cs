using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    internal class Response
    {
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        [JsonProperty("headers")]
        public Dictionary<string, Header> Headers { get; set; }

        [JsonProperty("examples")]
        public Example Example { get; set; }


    }
}
