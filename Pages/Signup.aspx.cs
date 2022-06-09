using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News_Magazine_Website.Pages
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


    

        protected void btnCreataccID_OnServerClick(object sender, EventArgs e)
        { if (nameID.Value==""||emailID.Value==""||passwordID.Value==""||confirm_passwordID.Value=="")
            {
                  ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                "swal('Error!', 'تمام مقادیر را تکمیل کنید!', 'error')", true);
            }
        }

        protected void btnLoginAccountID_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Login.aspx");
        }
        
    }
}