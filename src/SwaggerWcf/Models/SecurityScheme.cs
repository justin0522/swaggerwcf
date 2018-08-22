using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwaggerWcf.Models
{
    public class SecurityScheme
    {
        /// <summary>
        /// (Required) The type of the security scheme. Valid values are "basic", "apiKey" or "oauth2".
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A short description for security scheme.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// (Required) The name of the header or query parameter to be used.
        /// WARNING: Use only, when <see cref="Type"/> equals "apiKey"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (Required) The location of the API key. Valid values are "query" or "header".
        /// WARNING: Use only, when <see cref="Type"/> equals "apiKey"
        /// </summary>
        [JsonProperty("in")]
        public string _in { get; set; }

        /// <summary>
        /// (Required) The flow used by the OAuth2 security scheme. Valid values are "implicit", "password", "application" or "accessCode".
        /// WARNING: Use only, when <see cref="Type"/> equals "oauth2"
        /// </summary>
        [JsonProperty("flow")]
        public string Flow { get; set; }

        /// <summary>
        /// (Required) The authorization URL to be used for this flow. This SHOULD be in the form of a URL.
        /// WARNING: Use only, when <see cref="Type"/> equals "oauth2" and <see cref="Flow"/> equals "implicit" or "accessCode"
        /// </summary>
        [JsonProperty("authorizationUrl")]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// (Required) The token URL to be used for this flow. This SHOULD be in the form of a URL.
        /// WARNING: Use only, when <see cref="Type"/> equals "oauth2" and <see cref="Flow"/> equals "password" or "application" or "accessCode"
        /// </summary>
        [JsonProperty("tokenUrl")]
        public string TokenUrl { get; set; }

        /// <summary>
        /// (Required) The available scopes for the OAuth2 security scheme.
        /// This maps between a name of a scope to a short description of it (as the value of the property).
        /// WARNING: Use only, when <see cref="Type"/> equals "oauth2"
        /// </summary>
        [JsonProperty("scopes")]
        public Dictionary<string, string> Scopes { get; set; }

    }
}
