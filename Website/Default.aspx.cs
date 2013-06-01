using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Hashtable ht = GetEnumForBind(typeof(ShopService.Title));
        ddl1.DataSource = ht;
        ddl1.DataTextField = "value";
        ddl1.DataValueField = "key";
        ddl1.DataBind();
        ddl1.SelectedIndex = 0;
    }

    public Hashtable GetEnumForBind(Type enumeration)
    {
        string[] names = Enum.GetNames(enumeration);
        Array values = Enum.GetValues(enumeration);
        Hashtable ht = new Hashtable();
        for (int i = 0; i < names.Length; i++)
        {
            ht.Add(Convert.ToInt32(values.GetValue(i)).ToString(), names[i]);
        }
        return ht;
    }

    protected void btGo_Click(object sender, EventArgs e)
    {
        string email = tbEmail.Text, name = tbName.Text, morada = tbMorada.Text;
        int quant = int.Parse(tbQuant.Text);
        ShopService.Title title = (ShopService.Title)Enum.Parse(typeof(ShopService.Title), ddl1.SelectedValue);
        tbEmail.Text = "";
        tbMorada.Text = "";
        tbName.Text = "";
        tbQuant.Text = "";
        
        ShopService.ShopServiceClient proxy = new ShopService.ShopServiceClient();
      proxy.addOrder(name,morada,email,quant,title);
      proxy.Close();
    }
}