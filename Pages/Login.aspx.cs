using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News_Magazine_Website.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginID2_ServerClick(object sender, EventArgs e)
        {
            if (nameID.Value==""||passwordID.Value=="")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                    "swal('Error!', 'تمام مقادیر را تکمیل کنید!', 'error')", true);
            }
        }

        protected void btnCreataccID2_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Signup.aspx");
        }
    }
}