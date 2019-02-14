using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1>Welcome to my Real World!<h1>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool isAuth = false;

            if(userName_textBox.Text == "Anu" && password_textBox.Text == "1234")
            {
                Response.Write("Login Complete!");
                isAuth = true;
                form1.Style["background-color"] = "green";

                // string url = "view.aspx?usertName="+userName_textBox.Text;
                // Response.RedirectPermanent(url);

                // Create cookie object
                HttpCookie ckAuth = new HttpCookie("auth");
                ckAuth.Value = "Yes";

                Response.Cookies.Add(ckAuth);
                Response.RedirectPermanent("read.aspx");


            }
            else
            {
                for(int i = 0; i < 12; i++)
                {
                    Response.Write("Wrong User Name or Password!!!\n");
                    form1.Style["background-color"] = "red";
                }
                
            }
            
        }
    }
}