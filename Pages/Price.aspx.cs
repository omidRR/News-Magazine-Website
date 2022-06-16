using Newtonsoft.Json;
using RestSharp;
using System;

namespace News_Magazine_Website.Pages
{
    public partial class Price : System.Web.UI.Page
    {
        public prices.Root myDeserializedClass;


        protected void Page_Load(object sender, EventArgs e)
        {

            RestClient client23 = new RestClient();
            client23.UserAgent =
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36";
            RestRequest request = new RestRequest(Method.GET);
            request.Timeout = 15000;
            client23 = new RestClient("http://shamimsoft.ir/mahdi/arz/arz.txt");
            IRestResponse response = client23.Execute(request);
            response.Content = response.Content.Replace("+", "🔺").Replace("-", "🔻");
            myDeserializedClass = JsonConvert.DeserializeObject<prices.Root>(response.Content);
            //Response.Write(myDeserializedClass.data.prices.USD.current);


        }
    }

    public class prices
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AED
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class AFN
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class AMD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class AUD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class AZN
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class BHD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class CAD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class CHF
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class CNY
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class Data
        {
            public string message { get; set; }
            public int status { get; set; }
            public Prices prices { get; set; }
        }

        public class DKK
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class EUR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class GBP
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class GEL
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class HKD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class INR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class IQD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class JPY
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class KWD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class MYR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class NOK
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class NZD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class OMR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class PKR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class Prices
        {
            public USD USD { get; set; }
            public EUR EUR { get; set; }
            public GBP GBP { get; set; }
            public AED AED { get; set; }
            public TRY TRY { get; set; }
            public CNY CNY { get; set; }
            public JPY JPY { get; set; }
            public CAD CAD { get; set; }
            public AUD AUD { get; set; }
            public NZD NZD { get; set; }
            public CHF CHF { get; set; }
            public AFN AFN { get; set; }
            public SEK SEK { get; set; }
            public DKK DKK { get; set; }
            public NOK NOK { get; set; }
            public KWD KWD { get; set; }
            public SAR SAR { get; set; }
            public QAR QAR { get; set; }
            public OMR OMR { get; set; }
            public IQD IQD { get; set; }
            public BHD BHD { get; set; }
            public SYP SYP { get; set; }
            public INR INR { get; set; }
            public PKR PKR { get; set; }
            public SGD SGD { get; set; }
            public HKD HKD { get; set; }
            public MYR MYR { get; set; }
            public THB THB { get; set; }
            public RUB RUB { get; set; }
            public AZN AZN { get; set; }
            public AMD AMD { get; set; }
            public GEL GEL { get; set; }
        }

        public class QAR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class Root
        {
            public Data data { get; set; }
        }

        public class RUB
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class SAR
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class SEK
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class SGD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class SYP
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class THB
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class TRY
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }

        public class USD
        {
            public string min { get; set; }
            public string max { get; set; }
            public string current { get; set; }
            public string changePercent { get; set; }
            public string changePrice { get; set; }
        }


    }
}