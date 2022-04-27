using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    lt.lb.www.ExchangeRates myWS2 = new lt.lb.www.ExchangeRates();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            XmlNode node = myWS2.getListOfCurrencies();

            XmlNodeList nodes = node.SelectNodes("//item");

            foreach (XmlNode nd in nodes)
            {
                lstCurFrom.Items.Add(nd["currency"].InnerText +
                    " " + nd["description"].InnerText);
                lstCurTo.Items.Add(nd["currency"].InnerText +
                    " " + nd["description"].InnerText);
            }
            lstCurFrom.SelectedIndex = 26;
            lstCurTo.SelectedIndex = 27;
        }
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        decimal f, rateFrom = 0, rateTo =0;
        string n1, n2;

        n1 = Convert.ToString(lstCurFrom.SelectedItem).Substring(0,3);
        n2 = Convert.ToString(lstCurTo.SelectedItem).Substring(0, 3);

        XmlNode node = myWS2.getExchangeRatesByDate("2014-12-31");
        XmlNodeList nodes = node.SelectNodes("//item");
        foreach (XmlNode nde in nodes)
        {
            if (nde["currency"].InnerText == n1 )
                rateFrom = Convert.ToDecimal(nde["rate"].InnerText) / 
                Convert.ToInt32(nde["quantity"].InnerText);

            if (nde["currency"].InnerText == n2)
                rateTo = Convert.ToDecimal(nde["rate"].InnerText) /
                Convert.ToInt32(nde["quantity"].InnerText);

        }
        f = Math.Round(Convert.ToDecimal(TextBox1.Text) * rateFrom / rateTo, 2);
        Label1.Text = Convert.ToString(f);
    }
}