﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ddl1.Items.Count==0)
        {
            Hashtable ht = GetEnumForBind(typeof(WebService.Title));
            ddl1.DataSource = ht;
            ddl1.DataTextField = "value";
            ddl1.DataValueField = "key";
            ddl1.DataBind();
            ddl1.SelectedIndex = 0;
        }
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
        WebService.Title title = (WebService.Title)Enum.Parse(typeof(WebService.Title), ddl1.SelectedValue);
        tbEmail.Text = "";
        tbMorada.Text = "";
        tbName.Text = "";
        tbQuant.Text = "";
        
        WebService.WebServiceClient proxy = new WebService.WebServiceClient();

      proxy.addOrder(name,morada,email,quant,title);    
      proxy.Close();
    }


}