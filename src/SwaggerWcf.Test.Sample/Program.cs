using Newtonsoft.Json;
using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace SwaggerWcf.Test.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:9000/wcf";
            try
            {
                //string path = @"C:\Users\hfjia\Downloads\swagger.json";
                //ReadSwaggerJson(path);

                WebHost(uri);

                SetupSwagger(uri);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void WebHost(string uri)
        {
            var host = new ServiceHost(typeof(Service1), new Uri(uri));
            var endpoint = host.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "rest");
            endpoint.Behaviors.Add(new WebHttpBehavior() { HelpEnabled = true });

            host.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), "soap");

            host.Opened += delegate { Console.WriteLine("host open"); };
            host.Open();
        }

        static void SetupSwagger(string uri)
        {
            var host = new WebServiceHost(typeof(SwaggerWcfEndpoint), new Uri(uri));
            host.AddServiceEndpoint(typeof(ISwaggerWcfEndpoint), new WebHttpBinding(), "docs");

            host.Opened += delegate { Console.WriteLine("host open"); };
            host.Open();
        }

        static void ReadSwaggerJson(string path)
        {
            string content = File.ReadAllText(path);
            var swaggerObject = JsonConvert.DeserializeObject<SwaggerWcf.Models.Service>(content, new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore
            });

            var abcdef = swaggerObject.Definitions;
        }
    }

}
