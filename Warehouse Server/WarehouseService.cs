using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;

namespace Warehouse_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WarehouseService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WarehouseService : IWarehouseService
    {
        public Dictionary<Title, int> requests;
        public WarehouseService()
        {
            try
            {
                Stream stream = File.Open("requests.bin", FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                requests = (Dictionary<Title, int>)bin.Deserialize(stream);
                
            }
            catch
            {
                requests = new Dictionary<Title, int>();
            }
        }

        ~WarehouseService()
        {
            using (Stream stream = File.Open("requests.bin", FileMode.Create))
            {

                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, requests);
            }
        }

        class Obj { public Title t; public int quant;} ;
        public Dictionary<Title, int> getShopRequests()
        {

            throw new NotImplementedException();
        }
    }
}
