using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_GUI.ShopService;
using Warehouse_GUI.WarehouseService;


namespace Warehouse_GUI
{
    public partial class WarehouseGUI : Form ,IShopServiceCallback
    {
        ShopServiceClient proxyShop;
        WarehouseServiceClient proxyWH;

        public WarehouseGUI()
        {
            InitializeComponent();

            proxyShop = new ShopServiceClient(new InstanceContext(this));
            proxyShop.SetClientBaseAddress(); 
            proxyWH = new WarehouseServiceClient();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            Dictionary<WarehouseService.Title, int> dic = proxyWH.getShopRequests();
            listBox1.Items.Clear();
            foreach (WarehouseService.Title key in dic.Keys)
            {
                listBox1.Items.Add(Enum.GetName(typeof(WarehouseService.Title), key) + ":" + dic[key].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string[] item=((string)listBox1.SelectedItem).Split(':');
                ShopService.Title t = (ShopService.Title)Enum.Parse(typeof(ShopService.Title), item[0]);
                WarehouseService.Title t2 = (WarehouseService.Title)Enum.Parse(typeof(WarehouseService.Title), item[0]);
                
                int quant = int.Parse(item[1]);
                proxyShop.warehouseDispatch(t,quant);
                proxyWH.deliverRequest(t2);
                actualizar();
            }
        }



       

        void IShopServiceCallback.OrderUpdated(List<Order> orders, Dictionary<ShopService.Title, int> stocks)
        {
            return;
        }

        void IShopServiceCallback.OrderCompleted(Order o)
        {
            return;
        }
    }
}
