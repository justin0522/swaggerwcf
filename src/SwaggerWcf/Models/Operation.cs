using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerWcf.Models
{
    internal class Operation
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
        [JsonProperty("responses")]
        public Dictionary<string, Response> Responses { get; set; }

        /// <summary>
        /// v2
        /// </summary>
        [JsonProperty("schemes")]
        public string Schemes { get; set; }

        [JsonProperty("deprecated")]
        public bool Deprecated { get; set; }

        [JsonProperty("security")]
        public List<KeyValuePair<string, string[]>> Security { get; set; }

        //Servers //v3
    }
}
