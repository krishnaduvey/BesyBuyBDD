using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BesyBuyBDD.Utility
{
    public class HttpConnectionController
    {
        public HttpClient _client;

        public void GetResourceName() {

        }

        public HttpConnectionController() {
            this._client = GetClientConnection();

        }
        public string Get(string uri) {
           var responseTask = _client.GetAsync(uri);
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();
                var resultFound = readTask.Result;
                return resultFound;
            }

            return string.Empty;
        }


        public void Post()
        {



        }

        public void Put()
        {

        }

        public void Delete()
        {

        }


        public void GetWithParameters()
        {

        }
        public void PostWithParameters()
        {

        }

        public void PutWithParameters()
        {

        }

        public void DeleteWithParameters()
        {

        }


        public  static HttpClient GetClientConnection() {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3030");
                return client;
            }
        }
    }
}
