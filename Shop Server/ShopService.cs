using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Shop_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShopService" in both code and config file together.
    public class ShopService : IShopService
    {
        List<Order> orders;
        Dictionary<Title,int> stocks;
        int id;

        public List<Order> getOrders()
        {
            return orders;
        }

        public ShopService()
        {
            id = 0;
            orders = new List<Order>();
            stocks = new Dictionary<Title, int>();
            int i = 0;
            foreach (Title title in Enum.GetValues(typeof(Title)))
            {
                stocks.Add(title, i);
                i++;
            }
        }


        public Dictionary<Title, int> getStocks()
        {
            return stocks;
        }



        public void addOrder(string name, string addr, string email, int quant, Title t)
        {
            Order o = new Order();
            o.email = email;
            o.name = name;
            o.address = addr;
            o.quant = quant;
            o.title = t;
            o.id = id;
            o.price=calcPrice(quant,t);
            id++;
            orders.Add(o);
            //TODO verificar se existe stock e mandar;

        }

        private double calcPrice(int quant, Title t)
        {
            double price=0;
            switch (t)
            {
                case Title.GoT: price = 1; break;
                case Title.LotR: price = 1.5; break;
                case Title.RemotingForDummies: price = 2; break;
                case Title.CProgramming: price = 2.5; break;
                case Title.AIBasicApproach: price = 3; break;
            }

            return price*quant;
        }
    }
}
