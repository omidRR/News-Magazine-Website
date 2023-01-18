using System;
using System.Data;
using System.IO;

namespace News_Magazine_Website.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var Dir = AppContext.BaseDirectory;
                string[] str = default;
                //readcsv
                try
                {
                    str = File.ReadAllLines((Dir + @"/Users.csv"));
                    if (str.Length == 0)
                    {
                        File.WriteAllText(Dir + @"/Users.csv", "nationalCode ,Name,Email,DateTime,password\r\n1743043171,omid,omid.d@gmail.com,27/10/1401,omid\r\n");
                        str = File.ReadAllLines((Dir + @"/Users.csv"));

                    }
                }
                catch (System.IO.FileNotFoundException exception)
                {
                    File.WriteAllText(Dir + @"/Users.csv", "nationalCode ,Name,Email,DateTime,password\r\n1743043171,omid,omid.d@gmail.com,27/10/1401,omid\r\n");
                    str = File.ReadAllLines((Dir + @"/Users.csv"));
                }
                // create new datatable
                DataTable dt = new DataTable();
                string[] temp = str[0].Split(',');
                // creates columns
                foreach (string t in temp)
                {
                    dt.Columns.Add(t, typeof(string));
                }
                //creates rows
                for (int i = 1; i < str.Length; i++)
                {
                    string[] t = str[i].Split(',');
                    t[3] = t[3].Replace("/", "");
                    dt.Rows.Add(t);

                }
                GridView1.DataSource = dt;
                //show
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                    $"swal('Error!', 'خطای داخلی رخ داده!\n\n{ex.Message}', 'error')", true);
                return;
            }

        }
    }
}