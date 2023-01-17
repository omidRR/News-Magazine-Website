using System;

namespace News_Magazine_Website
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/MainPage.Master.aspx");

        }
    }
}