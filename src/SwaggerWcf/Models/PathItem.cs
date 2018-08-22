using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    internal class PathItem
    {
        [JsonProperty("$ref")]
        public string _ref { get; set; }

#if V3
        /// <summary>
        /// v3
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }
#endif
        [JsonProperty("get")]
        public Operation Get { get; set; }

        [JsonProperty("put")]
        public Operation Put { get; set; }

        [JsonProperty("post")]
        public Operation Post { get; set; }

        [JsonProperty("delete")]
        public Operation Delete { get; set; }

        [JsonProperty("options")]
        public Operation Options { get; set; }

        [JsonProperty("head")]
        public Operation Head { get; set; }

        [JsonProperty("patch")]
        public Operation Patch { get; set; }
#if V3
        /// <summary>
        /// v3
        /// </summary>
        [JsonProperty("trace")]
        public Operation Trace { get; set; }
#endif
        //TODO:        
        //Servers //v3
        //Parameters

    }
}
