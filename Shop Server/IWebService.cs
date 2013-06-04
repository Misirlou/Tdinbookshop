using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Shop_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebService" in both code and config file together.
    [ServiceContract]
    public interface IWebService
    {
        [OperationContract]
        void addOrder(string name, string addr, string email, int quant, Title t);
        
    }

    [DataContract(Name = "testeMex")]
    public enum TesteMex{ [EnumMember]Funciona}; 
    
}
