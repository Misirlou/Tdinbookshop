using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Shop_Server
{
    [ServiceContract(CallbackContract = typeof(ICallback))]
    public interface IShopService
    {
        [OperationContract]
        List<Order> getOrders();
        [OperationContract]
        Dictionary<Title,int> getStocks();
        [OperationContract] 
        void addOrder(string name,string addr,string email,int quant,Title t);
        [OperationContract]
        void warehouseDispatch(Title t,int quant);
        [OperationContract]
        void orderArrived(Title t,int quant);
        [OperationContract]
        void Subscribe();
        [OperationContract]
        void Unsubscribe();
    }

    

    [Serializable]
    [DataContract]
    public class Order
    {
        [DataMember]
        public Title title;
        [DataMember]
        public double price;
        [DataMember]
        public int quant;
        [DataMember]
        public string name;
        [DataMember]
        public string address;
        [DataMember]
        public string email;
        [DataMember]
        public int id;
        [DataMember]
        public OrderState state;
        [DataMember]
        public DateTime date;
        /*[DataMember]
        public string stateStr
        {
            get
            {
                string s = "";
                switch (state)
                {
                    case OrderState.WaitingExpediton: s = "Waiting expedition";
                        break;
                    case OrderState.DispatchWillOccur: s = "Dispatch Will Occur at " + date.ToShortDateString();
                        break;
                    case OrderState.Dispatched: s = "Dispatched at " + date.ToShortDateString();
                        break;
                }
                return s;
            }
        }*/
    }

    [DataContract(Name = "Title")]
    public enum Title { [EnumMember]LotR, [EnumMember] GoT,[EnumMember] CProgramming,[EnumMember] AIBasicApproach,[EnumMember] RemotingForDummies };

    [DataContract(Name = "OrderState")]
    public enum OrderState { [EnumMember]WaitingExpediton,  [EnumMember] Dispatched, [EnumMember] DispatchWillOccur };


    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void OrderUpdated(List<Order> orders, Dictionary<Title, int> stocks);
        [OperationContract(IsOneWay = true)]
        void OrderCompleted(Order o);
    }

}
