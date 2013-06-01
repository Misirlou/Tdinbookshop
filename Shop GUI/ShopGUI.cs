using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_GUI.ShopService;

namespace Shop_GUI
{
    public partial class ShopGUI : Form
    {
        ShopServiceClient proxy;
        public ShopGUI()
        {
            InitializeComponent();
            proxy = new ShopServiceClient();
        }


        private void ShopGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Close();

        }
    }
}
