using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    internal class Schema
    {
        [JsonProperty("$ref")]
        public string _ref { get; set; } // for references

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("required")]
        public List<string> Required { get; set; }

        [JsonProperty("enum")]
        public List<string> _enum { get; set; }

        [JsonProperty("type")]
        public string _type { get; set; }

        [JsonProperty("xml")]
        public Xml xml { get; set; }

        [JsonProperty("schema")]
        public Schema Items { get; set; } //TODO: Composition and Polymorphism Support

        [JsonProperty("externalDocumentation")]
        public ExternalDocumentation ExternalDocumentation { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, Schema> Properties { get; set; }

        [JsonProperty("example")]
        public object Example { get; set; }

        [JsonProperty("maximum")]
        public object Maximum { get; set; }

        [JsonProperty("exclusiveMaximum")]
        public object ExclusiveMaximum { get; set; }

        [JsonProperty("minimum")]
        public object Minimum { get; set; }

        [JsonProperty("exclusiveMinimum")]
        public object ExclusiveMinimum { get; set; }

        [JsonProperty("maxLength")]
        public object MaxLength { get; set; }

        [JsonProperty("minLength")]
        public object MinLength { get; set; }

        [JsonProperty("pattern")]
        public object Pattern { get; set; }

        [JsonProperty("maxItems")]
        public object MaxItems { get; set; }

        [JsonProperty("minItems")]
        public object MinItems { get; set; }

        [JsonProperty("uniqueItems")]
        public object UniqueItems { get; set; }

        [JsonProperty("multipleOf")]
        public object MultipleOf { get; set; }

        // TODO: other properties

        public TypeFormat TypeFormat { get; set; }
    }
}
