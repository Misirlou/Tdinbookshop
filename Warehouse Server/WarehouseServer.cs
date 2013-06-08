using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Server
{
    public partial class WarehouseServer : Form
    {
        private ServiceHost SHost = null;
        private WarehouseService WHServ = null;

        public WarehouseServer()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (SHost == null)
            {
                WHServ = new WarehouseService();
                SHost = new ServiceHost(WHServ);
                SHost.Open();
                label1.Text = "Serviço Aberto";
                button1.Text = "Fechar Serviço";
            }
            else
            {
                SHost.Close();
                SHost = null;
                WHServ = null;
                label1.Text = "Serviço Fechado";
                button1.Text = "Abrir Serviço";
            }
        }

        private void ShopServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SHost != null)
            {
                SHost.Close();

                SHost = null;
                WHServ = null;
            }

        }
    }
}
