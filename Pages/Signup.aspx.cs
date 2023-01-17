using Csv;
using System;
using System.IO;

namespace News_Magazine_Website.Pages
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreataccID_OnServerClick(object sender, EventArgs e)
        {
            try
            {
                if (NameID.Value == "" || CodemeliID.Value == "" || emailID.Value == "" || passwordID.Value == "" ||
            confirm_passwordID.Value == "")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                        "swal('Error!', 'تمام مقادیر را تکمیل کنید!', 'error')", true);
                    return;
                }

                var columnNames = new[] { "nationalCode ", "Name", "Email", "DateTime", "password" };
                var rows = new[]
                {
                new[] { CodemeliID.Value, NameID.Value, emailID.Value, DateTime.Now.ToString("g"), passwordID.Value }
            };
                //callcodemeli
                var res = Codemeli(CodemeliID.Value);

                if (res == "کد ملی صحیح نیست")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                        "swal('Error!', 'کد ملی صحیح نیست!', 'error')", true);
                    return;
                }
                var Dir = AppContext.BaseDirectory;
                string csvv = default;
                //readcsv
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
                    if (CodemeliID.Value == codemeli)
                    {

                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                            "swal('Error!', 'این نام کاربری در سامانه موجود میباشد!', 'error')", true);
                        return;
                    }
                }



                //write
                var csv = CsvWriter.WriteToText(columnNames, rows, ',');
                File.AppendAllText(Dir + @"/Users.csv", csv);



                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                    $"swal('نتایج', 'خوش آمدید {NameID.Value}', 'success')", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                    $"swal('Error!', 'خطای داخلی رخ داده!\n\n{ex.Message}', 'error')", true);
                return;
            }

        }

        protected void btnLoginAccountID_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Login.aspx");
        }

        public string Codemeli(string textbox1)
        {
            try
            {

                char[] chArray = textbox1.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }

                int num2 = numArray[9];
                switch (textbox1)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        return "کد ملی صحیح نیست";

                }

                int num3 =
                    ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) +
                        (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) +
                    (numArray[8] * 2);
                int num4 = num3 - ((num3 / 11) * 11);
                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) ||
                    ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {
                    return "کد ملی صحیح میباشد";

                }
                else
                {
                    return "کد ملی صحیح نیست";

                }
            }
            catch (Exception)
            {
                return "کد ملی صحیح نیست";
            }
        }
    }
}
