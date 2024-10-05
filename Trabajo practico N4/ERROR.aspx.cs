using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_practico_N4
{
    public partial class ERROR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonError_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}