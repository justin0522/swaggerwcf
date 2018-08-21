using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    internal sealed class Service
    {
        public Service()
        {
            Swagger = "2.0";           
            Definitions = new Definitions();
        }

        [JsonProperty("swagger")]
        public string Swagger { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("basePath")]
        public string BasePath { get; set; }

        public List<string> Schemes { get; set; }

        [JsonProperty("paths")]
        public Path Paths { get; set; }

        [JsonProperty("definitions")]
        public Definitions Definitions { get; set; }

        [JsonProperty("securityDefinitions")]
        public SecurityDefinitions SecurityDefinitions { get; set; }

        public void Serialize(JsonWriter writer)
        {
           
        }      

        
    }
}
