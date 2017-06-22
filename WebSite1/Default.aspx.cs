using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Value == "1")
        {
            Response.Redirect("MCQPage.aspx");
        }
        if (RadioButtonList1.SelectedItem.Value == "2")
        {
            Response.Redirect("FITBPage.aspx");
        }
    }
}