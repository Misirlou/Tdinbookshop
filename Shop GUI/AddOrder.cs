using System;
using System.Collections;
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
    public partial class AddOrder : Form
    {

        public String client_name;
        public String client_add;
        public String email;
        public ShopService.Title book;
        public int quantity;

        public AddOrder()
        {
            InitializeComponent();


            comboBox1.DataSource = Enum.GetValues(typeof(ShopService.Title));
            comboBox1.SelectedIndex = 0;
           
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                client_name = textBox1.Text;
                client_add = textBox2.Text;
                email = textBox3.Text;
                book = (ShopService.Title)comboBox1.SelectedValue;
                quantity = Convert.ToInt32(textBox4.Text);

                DialogResult = DialogResult.OK;
            }
        }



    }
}
