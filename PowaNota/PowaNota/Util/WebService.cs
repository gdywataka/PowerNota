using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using C = Nota1.Util.Constantes;

namespace Nota1.Util
{
    class WebService
    {
        static private WebClient webCliente = new WebClient();

        public static void uploadJson(string link,string json)
        {
            webCliente.Headers[HttpRequestHeader.ContentType] = "application/json";
            try
            {
                webCliente.UploadString(C.WS_HOST + link, json);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string downloadJson(string link)
        {
            try
            {
               return webCliente.DownloadString(C.WS_HOST + link);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
