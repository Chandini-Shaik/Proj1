using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestPost1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<Customers> custlist = new List<Customers>();

        public List<Customers> GetDataUsingDataContractXML()
        {
            //throw new NotImplementedException();
            return custlist;
        }

        //public List<IService1.Customers> GetDataUsingDataContractXML()
        //{
        //    throw new NotImplementedException();
        //}

        public void PostDataUsingDataContract(Customers c)
        {
            Customers c1 = new Customers();
            c1.CustName = c.CustName;
            custlist.Add(c1);
            //throw new NotImplementedException();
        }

        //public void PostDataUsingDataContract(IService1.Customers c)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
        