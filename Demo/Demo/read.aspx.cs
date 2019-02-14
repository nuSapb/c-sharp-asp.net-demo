using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ckAuth = Request.Cookies["auth"];
            if(ckAuth.Value != null)
            {
                auth_Label.Text = ckAuth.Value;
            }
            
        }
    }

}