using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "cangeles86@hotmail.com" && txtPass.Text == "123456")
            {
                Response.Redirect("~/Index.aspx");
            }
        }
    }
}