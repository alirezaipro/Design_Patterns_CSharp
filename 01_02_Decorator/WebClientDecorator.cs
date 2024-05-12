using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Decorator
{
    public class WebClientDecorator : WebClient
    {
        private readonly WebClient _webClient;

        public WebClientDecorator(WebClient webClient)
        {
            _webClient = webClient;
        }

        public string DownloadString(string address)
        {
            if (address == null)
                return string.Empty;


            if (address.StartsWith("https://toplearn.com"))
                return _webClient.DownloadString(address);


            return string.Empty;
        }
    }
}
