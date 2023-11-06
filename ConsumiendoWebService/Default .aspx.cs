using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumiendoWebService
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            NorthWS.ConsultaNorthwind obj = new NorthWS.ConsultaNorthwind();
            GridView1.DataSource = obj.GetData();
            GridView1.DataBind();
        }
    }
}