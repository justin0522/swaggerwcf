using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using SwaggerWcf.Models;

namespace SwaggerWcf.Support
{
    public class Serializer
    {
        internal static string Process(Service service)
        {
            var json = JsonConvert.SerializeObject(service,
                new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            return json;
        }
    }
}
