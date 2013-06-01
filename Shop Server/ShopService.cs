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

        public List<Order> getOrders()
        {
            return orders;
        }

        public ShopService()
        {
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

    }
}
