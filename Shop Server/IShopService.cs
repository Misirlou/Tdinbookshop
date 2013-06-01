using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Shop_Server
{
    [ServiceContract]
    public interface IShopService
    {
        [OperationContract]
        List<Order> getOrders();
        [OperationContract]
        Dictionary<Title,int> getStocks();
        [OperationContract]
        void addOrder(string name,string addr,string email,int quant,Title t);
    }


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
        [DataMember]
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
        }
    }

    [DataContract(Name = "Title")]
    public enum Title { [EnumMember]LotR, [EnumMember] GoT,[EnumMember] CProgramming,[EnumMember] AIBasicApproach,[EnumMember] RemotingForDummies };

    [DataContract(Name = "OrderState")]
    public enum OrderState { [EnumMember]WaitingExpediton,  [EnumMember] Dispatched, [EnumMember] DispatchWillOccur };

}

/*
public class Order
{
    public Title title;
    public int quant;
    public string name;
    public string address;
    public string email;
    public int id;
    public OrderState state;
    public DateTime date;

    public Order(Title t, int quant, string name, string address, string email)
    {
        this.title = t;
        this.quant = quant;
        this.email = email;
        this.address = address;
        this.name = name;
        id = 0;
    }

    public string State()
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

}


public enum Title { LotR1, LotR2, LotR3, GoT1, GoT2, GoT3, GoT4, GoT5, HP1, HP2, HP3, HP4, HP5, HP6, HP7, CProgramming, AIBasicApproach, RemotingForDummies };

public enum OrderState { WaitingExpediton, Dispatched, DispatchWillOccur };

public delegate void AlterDelegate(OrderState os, Order or);

public interface IOrders
{
    event AlterDelegate alterEvent;

    void Add(Order o);


    List<Order> GetOrdersByState(OrderState state);
    List<Order> GetOrdersByState(OrderState state, string equipa);

    List<Order> GetOrders(string name);
    void ModifyOrder(int num, OrderState state);
    void ModifyOrder(int num, OrderState state, String equipa);

}
*/