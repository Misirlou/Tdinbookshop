﻿using System;
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
            List<Order> orders=proxy.getOrders();
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
            }
        }

        public void OrderUpdated()
        {
            proxy.getStocks();
            proxy.getOrders();
        }

        public void OrderCompleted(Order o)
        {
            return;
        }
    }
}
