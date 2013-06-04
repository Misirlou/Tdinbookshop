using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Warehouse_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWarehouseService" in both code and config file together.
    [ServiceContract]
    public interface IWarehouseService
    {
        [OperationContract]
        Dictionary<Title,int> getShopRequests();
        [OperationContract]
        void deliverRequest(Title t);
    }
    [DataContract(Name = "Title")]
    public enum Title { [EnumMember]LotR, [EnumMember] GoT,[EnumMember] CProgramming,[EnumMember] AIBasicApproach,[EnumMember] RemotingForDummies };

}
