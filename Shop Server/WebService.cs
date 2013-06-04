using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Shop_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WebService : IWebService
    {
        public ShopService shopSrv;
        public void addOrder(string name, string addr, string email, int quant, Title t)
        {
            shopSrv.addOrder(name, addr, email, quant, t);
        }
    }
}
