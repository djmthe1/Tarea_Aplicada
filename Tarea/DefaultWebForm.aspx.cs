using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea
{
    public partial class DefaultWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Contacto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactoWebForm.aspx");
        }

        protected void JqueryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("JQueryWebForm.aspx");
        }
    }
}