using Csv;
using System;
using System.IO;

namespace News_Magazine_Website.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginID2_ServerClick(object sender, EventArgs e)
        {
            if (codemeliID.Value == "" || passwordID.Value == "")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                    "swal('Error!', 'تمام مقادیر را تکمیل کنید!', 'error')", true);
                return;
            }

            //readcsv
            var Dir = AppContext.BaseDirectory;
            string csvv = default;
            try
            {
                csvv = File.ReadAllText(Dir + @"/Users.csv");
            }
            catch (System.IO.FileNotFoundException exception)
            {
                File.WriteAllText(Dir + @"/Users.csv", "");
                csvv = File.ReadAllText(Dir + @"/Users.csv");
            }

            foreach (var line in CsvReader.ReadFromText(csvv))
            {
                var codemeli = line[0];
                var pass = line[4];
                if (codemeliID.Value == codemeli && passwordID.Value == pass)
                {
                    Response.Redirect("Panel.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                        "swal('Error!', 'نام کاربری یا رمز عبور اشتباه میباشد!', 'error')", true);
                    return;
                }
            }

        }

        protected void btnCreataccID2_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Signup.aspx");
        }
    }
}