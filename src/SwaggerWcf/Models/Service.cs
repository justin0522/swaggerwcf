using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwaggerWcf.Models
{
    public sealed class Service
    {
        public Service()
        {
            Swagger = "2.0";
            Definitions = new Definitions();
        }

        [JsonProperty("swagger", Required = Required.Always)]
        public string Swagger { get; set; }

        [JsonProperty("info", Required = Required.Always)]
        public Info Info { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("basePath")]
        public string BasePath { get; set; }

        [JsonProperty("schemes")]
        public List<string> Schemes { get; set; }

        [JsonProperty("consumes")]
        public List<string> Consumes { get; set; }

        [JsonProperty("produces")]
        public List<string> Produces { get; set; }

        [JsonProperty("paths", Required = Required.Always)]
        public Path Paths { get; set; }

        [JsonProperty("definitions")]
        public Definitions Definitions { get; set; }

        [JsonProperty("parameters")]
        public Dictionary<string, Parameter> Parameters { get; set; }

        [JsonProperty("responses")]
        public Responses Responses { get; set; }

        [JsonProperty("securityDefinitions")]
        public SecurityDefinitions SecurityDefinitions { get; set; }

        [JsonProperty("security")]
        public SecurityRequirement Security { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("externalDocs")]
        public ExternalDocumentation ExternalDocs { get; set; }
    }
}
