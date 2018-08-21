using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerWcf.Test.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:9000/wcf";
            try
            {
                WebHost(uri);

                SetupSwagger(uri);

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void WebHost(string uri)
        {
            var host = new WebServiceHost(typeof(Service1), new Uri(uri));
            var endpoint = host.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "");
            endpoint.Behaviors.Add(new WebHttpBehavior() { HelpEnabled = true });

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
    }

    [ServiceContract]
    public interface IService1
    {
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "/getdata?value={value}")]
        [OperationContract]
        string GetData(int value);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "/getdatax")]
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember(Name = "BoolValueX")]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [SwaggerWcf("wcf")]
    [SwaggerWcfServiceInfo(title: "Service1", version: "1.0.0")]
    public class Service1 : IService1
    {
        [SwaggerWcfTag("MyService")]
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        [SwaggerWcfTag("MyService")]
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
