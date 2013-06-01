using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;

namespace Shop_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShopService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
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
            int i = 0;
            try
            {
                Stream stream = File.Open("orders.bin", FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                orders = (List<Order>)bin.Deserialize(stream);

            }
            catch
            {

                orders = new List<Order>();
            }

            try
            {
                Stream stream = File.Open("stock.bin", FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                stocks = (Dictionary<Title, int>)bin.Deserialize(stream);

            }
            catch
            {

                stocks = new Dictionary<Title, int>();
                foreach (Title title in Enum.GetValues(typeof(Title)))
                {
                    stocks.Add(title, i);
                    i++;
                }
            }
            
        }
        ~ShopService()
        {
            using (Stream stream = File.Open("orders.bin", FileMode.Create))
            {

                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, orders);
            }
            using (Stream stream = File.Open("stock.bin", FileMode.Create))
            {

                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, stocks);
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
            if (stocks[t] >= quant)
            {
                stocks[t] -= quant;
                o.state = OrderState.Dispatched;
                o.date = DateTime.Now.AddDays(1);
                sendEmail(o);
            }
            else
            {
                sendRequestToWH(t, quant * 10);
                o.state = OrderState.WaitingExpediton;
            }
        }

        private void sendRequestToWH(Title t, int quant)
        {
            //TODO
        }

        private void sendEmail(Order o)
        {
            //TODO
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


        public void warehouseDispatch(Title t, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void orderArrived(Title t, int quant)
        {
            throw new NotImplementedException();
        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe()
        {
            throw new NotImplementedException();
        }
    }
}
