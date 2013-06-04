using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;

namespace Shop_Server
{
    public partial class ShopServer : Form
    {
        private ServiceHost SHost = null;
        private ShopService SServ = null;

        public ShopServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SHost == null)
            {
                SServ = new ShopService();
                SServ.mail = tbMail.Text;
                SServ.pass = tbPass.Text;
                SHost = new ServiceHost(SServ);
                SHost.Open();
                label1.Text = "Serviço Aberto";
                button1.Text = "Fechar Serviço";
            }
            else
            {
                SHost.Close();
                SHost = null;
                SServ = null;
                label1.Text = "Serviço Fechado";
                button1.Text = "Abrir Serviço";
            }
        }

        private void ShopServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SHost != null)
                SHost.Close();
        }

    }


}
