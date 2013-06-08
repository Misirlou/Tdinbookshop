using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_GUI.ShopService;

namespace Shop_GUI
{
    public partial class ShopGUI : Form , IShopServiceCallback
    {
        ShopServiceClient proxy;
        public ShopGUI()
        {
            InitializeComponent();
            proxy = new ShopServiceClient(new InstanceContext(this));
            proxy.SetClientBaseAddress();
            proxy.Subscribe();
        }


        private void ShopGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Unsubscribe();
            proxy.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*List<Order> orders=proxy.getOrders();
            Orders.Items.Clear();
            foreach(Order order in orders)
            {
                Orders.Items.Add(order.id + " " + Enum.GetName(typeof(Title),order.title) + " " + order.quant );
            }

            Dictionary<Title,int> stocks=proxy.getStocks();
            Stock.Items.Clear();
            foreach (Title t in stocks.Keys)
            {
                Stock.Items.Add(Enum.GetName(typeof(Title),t)+" "+stocks[t]);
            }*/


            AddOrder add_form = new AddOrder();

            if (add_form.ShowDialog(this) == DialogResult.OK)
            {
                proxy.addOrder(add_form.client_name, add_form.client_add, add_form.email, add_form.quantity, add_form.book);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UpdateStock up_form = new UpdateStock();

            if (up_form.ShowDialog(this) == DialogResult.OK)
            {
                proxy.orderArrived(up_form.book, up_form.quantity);
            }

        }

        public void OrderUpdated(List<Order> orders, Dictionary<Title, int> stocks)
        {
            Orders.Items.Clear();
            foreach (Order order in orders)
            {
                Orders.Items.Add(order.id + " " + Enum.GetName(typeof(Title), order.title) + " " + order.quant);
            }

            Stock.Items.Clear();
            foreach (Title t in stocks.Keys)
            {
                Stock.Items.Add(Enum.GetName(typeof(Title), t) + " " + stocks[t]);
            }
        }

        public void OrderCompleted(Order o)
        {
            return;
        }
    }
}
