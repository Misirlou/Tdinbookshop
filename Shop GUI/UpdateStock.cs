using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_GUI
{
    public partial class UpdateStock : Form
    {
        public ShopService.Title book;
        public int quantity;

        public UpdateStock()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(ShopService.Title));
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                quantity = Convert.ToInt32(textBox1.Text);

                DialogResult = DialogResult.OK;
            }

        }
    }
}
