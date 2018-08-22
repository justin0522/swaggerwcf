using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwaggerWcf.Models
{
    public class Schema
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
        public string Type { get; set; }

        [JsonProperty("xml")]
        public Xml Xml { get; set; }

        [JsonProperty("schema")]
        public Schema Items { get; set; } //TODO: Composition and Polymorphism Support

        [JsonProperty("externalDocumentation")]
        public ExternalDocumentation ExternalDocumentation { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, Schema> Properties { get; set; }

        [JsonProperty("example")]
        public object Example { get; set; } // TODO: return type

        [JsonProperty("maximum")]
        public double? Maximum { get; set; }

        [JsonProperty("exclusiveMaximum")]
        public bool? ExclusiveMaximum { get; set; }

        [JsonProperty("minimum")]
        public double? Minimum { get; set; }

        [JsonProperty("exclusiveMinimum")]
        public bool? ExclusiveMinimum { get; set; }

        [JsonProperty("maxLength")]
        public int? MaxLength { get; set; }

        [JsonProperty("minLength")]
        public int? MinLength { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("maxItems")]
        public int? MaxItems { get; set; }

        [JsonProperty("minItems")]
        public int? MinItems { get; set; }

        [JsonProperty("uniqueItems")]
        public bool UniqueItems { get; set; }

        [JsonProperty("multipleOf")]
        public float MultipleOf { get; set; }

        // TODO: other properties

        private TypeFormat tf;
        [JsonIgnore]
        public TypeFormat TypeFormat
        {
            get { return tf; }
            set
            {
                tf = value;
                this.Type = value.Type.ToString().ToLower();
                if (this.Format != null)
                {
                    this.Format = value.Format.ToLower();
                }
            }
        }
    }
}
