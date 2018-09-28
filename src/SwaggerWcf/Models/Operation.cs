using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwaggerWcf.Models
{
    public class Operation
    {
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("externalDocs")]
        public ExternalDocumentation ExternalDocs { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// v2
        /// </summary>
        [JsonProperty("consumes")]
        public List<string> Consumes { get; set; }

        /// <summary>
        /// v2
        /// </summary>
        [JsonProperty("produces")]
        public List<string> Produces { get; set; }

        [JsonProperty("parameters")]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// v2
        /// </summary>
        [JsonProperty("responses", Required = Required.Always)]
        public Responses Responses { get; set; }

        /// <summary>
        /// v2
        /// </summary>
        [JsonProperty("schemes")]
        public string Schemes { get; set; }

        [JsonProperty("deprecated")]
        public bool Deprecated { get; set; }

        [JsonProperty("security")]
        public SecurityRequirement Security { get; set; }

        //Servers //v3
    }
}
