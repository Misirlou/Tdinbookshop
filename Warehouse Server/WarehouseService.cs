using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Warehouse_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WarehouseService" in both code and config file together.
    public class WarehouseService : IWarehouseService
    {

        public Dictionary<Title, int> getShopRequests()
        {
            throw new NotImplementedException();
        }
    }
}
