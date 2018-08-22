using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class Parameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        #region _in is "body"
        [JsonProperty("schema")]
        public Schema Schema { get; set; }
        #endregion

        #region _in is any value other than "body"
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("allowEmptyValue")]
        public bool AllowEmptyValue { get; set; }

        /// <summary>
        /// Required if type is "array".
        /// Describes the type of items in the array.
        /// </summary>
        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("collectionFormat")]
        public string CollectionFormat { get; set; }

        [JsonProperty("default")]
        public string _default { get; set; }

        [JsonProperty("maximum")]
        public float Maximum { get; set; }

        [JsonProperty("exclusiveMaximum")]
        public bool ExclusiveMaximum { get; set; }

        [JsonProperty("minimum")]
        public float Minimum { get; set; }

        [JsonProperty("exclusiveMinimum")]
        public bool ExclusiveMinimum { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("minLength")]
        public int MinLength { get; set; }

        #endregion
    }
}
