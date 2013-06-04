using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_GUI.ShopService;
using Warehouse_GUI.WarehouseService;


namespace Warehouse_GUI
{
    public partial class WarehouseGUI : Form
    {
        ShopServiceClient proxyShop;
        WarehouseServiceClient proxyWH;

        public WarehouseGUI()
        {
            InitializeComponent();

            proxyShop = new ShopServiceClient();
            proxyWH = new WarehouseServiceClient();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Dictionary<WarehouseService.Title, int> dic = proxyWH.getShopRequests();
          
        }
    }
}
