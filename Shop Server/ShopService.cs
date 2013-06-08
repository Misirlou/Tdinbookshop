using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;
using System.Messaging;



namespace Shop_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShopService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ShopService : IShopService
    {
        List<Order> orders;
        Dictionary<Title,int> stocks;
        int id;
        public string mail, pass;
        MessageQueue msq;

        public List<Order> getOrders()
        {
            return orders;
        }

        public ShopService()
        {

            msq = new MessageQueue(".\\private$\\tdin");
            id = 1;
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

                int i = 0;
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
            msq.Close();
            msq = null;
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
        public class Obj { public Title t; public int quant;} ;
        private void sendRequestToWH(Title t, int quant)
        {
            Obj obj=new Obj();
            obj.t = t;
            obj.quant = quant;

            msq.Formatter = new XmlMessageFormatter(new Type[] { typeof(Obj) });
            msq.Send(obj,"bookrequest");
		    

        }

        private void sendEmail(Order o)
        {
            if (mail == "") return; //se nao inserir email, retornar para nao spamar a google

            var fromAddress = new MailAddress(mail, "From Name");
            var toAddress = new MailAddress(o.email, "To Name");
            string fromPassword = pass;
            const string subject = "Book Order";
            string body = "Your order for "+o.quant.ToString()+" "+System.Enum.GetName(typeof(Title),o.title)+" is supposed to arrive at "+o.date.ToShortDateString()+". The price is "+o.price.ToString("C")+".";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
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


        public void warehouseDispatch(Title t,int quant)
        {
            foreach (Order o in orders)
            {
                if (o.state == OrderState.WaitingExpediton && o.title == t)
                {
                    o.state = OrderState.DispatchWillOccur;
                        o.date = DateTime.Now.AddDays(2);
                   

                }
            }
        }

        public void orderArrived(Title t, int quant)
        {
            stocks[t] += quant;
            foreach (Order o in orders)
            {
                if (o.state == OrderState.DispatchWillOccur && o.title == t)
                {
                    if (stocks[t] >= o.quant)
                    {
                        o.state = OrderState.Dispatched;
                        o.date = DateTime.Now;
                        stocks[t] -= o.quant;
                        sendEmail(o);
                    }

                }
            }
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
