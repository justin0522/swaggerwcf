﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerWcf.Models
{
    internal class Header
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("collectionFormat")]
        public string CollectionFormat { get; set; }

        // TODO: other properties

    }
}
