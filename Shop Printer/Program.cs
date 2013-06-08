using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Shop_Printer.ShopService;

namespace Shop_Printer
{
    class Program
    {
        static Printer printer;
        static void Main(string[] args)
        {
           printer=new Printer();
            Console.WriteLine("Press <Enter> to terminate.");
            Console.ReadLine();
            printer = null;
        }

        class Printer : IShopServiceCallback
        {
            ShopServiceClient proxy;
            public Printer()
            {
                proxy = new ShopServiceClient(new InstanceContext(this));
                proxy.SetClientBaseAddress();
                proxy.Subscribe();
            }
            ~Printer()
            {
                proxy.Unsubscribe();
            }

            void IShopServiceCallback.OrderUpdated(Order[] orders, Dictionary<Title, int> stocks)
            {
                return;
            }

            void IShopServiceCallback.OrderCompleted(Order o)
            {
                Console.WriteLine("Receipt: " + o.id.ToString() +" "+o.date.ToShortDateString()+"\n\t" + o.name + " \n\t" + Enum.GetName(typeof(Title), o.title) + "x" + o.quant.ToString() + "\n\tPrice:" + o.price.ToString("C")+"\n");
                
            }
        }
    }

   
}
