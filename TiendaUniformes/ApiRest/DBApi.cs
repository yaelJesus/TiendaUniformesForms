using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace TiendaUniformes.ApiRest
{
    public class DBApi
    {
        //private string _url = "http://192.168.1.193/api/";
        private string _url = "http://127.0.0.1:5191/api/";

        public dynamic Post(string controller, string method, string json, string autorizacion = null!)
        {
            try
            {
                string newUrl = _url + $"{controller}/{method}";
                var client = new RestClient(newUrl);
                var request = new RestRequest(newUrl, Method.Post);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }

                RestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content!)!;

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null!;
            }
        }


        public dynamic Get(string controller, string method)
        {
            try
            {
                string newUrl = _url + $"{controller}/{method}";
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(newUrl);
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
                //myWebRequest.CookieContainer = myCookie;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myHttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                //Leemos los datos
                string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

                dynamic data = JsonConvert.DeserializeObject(Datos)!;

                return data;
            }
            catch (Exception)
            {
                return null!;
            }
        }
    }
}
