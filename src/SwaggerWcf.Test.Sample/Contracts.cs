using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SwaggerWcf.Test.Sample
{
    [ServiceContract]
    public interface IService1
    {
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "/getdata?value={value}")]
        [OperationContract]
        string GetData(int value);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "/getdatax")]
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
}
