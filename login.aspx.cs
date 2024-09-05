using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2024_08_27
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName == "admin" && Login1.Password == "123123")
            {

                Session["Usuário"] = Login1.UserName.ToString();
                Session["Cidade"] = "Sumaré";

                e.Authenticated = true;
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Response.Redirect("~/index.aspx");
            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}
