using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestPost1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //[WebInvoke(UriTemplate = "CustomersJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //void PostDataUsingDataContract(Customer c);
        [OperationContract]
        [WebInvoke(UriTemplate = "CustomersJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void PostDataUsingDataContract(Customers c);

        [OperationContract]
        [WebGet(UriTemplate = "CustomersXml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        List<Customers> GetDataUsingDataContractXML();

    }

        // Use a data contract as illustrated in the sample below to add composite types to service operations.
        [DataContract]
        public class Customers
        {
            string custName;
            [DataMember]
            public string CustName
            {
                get { return custName; }
                set
                {
                    custName =value;
                }
            }
        }
    }






    