using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BesyBuyBDD.Utility
{
    public class HttpConnectionController
    {
        public HttpClient _client=null;
        public static string _baseAddress = "http://localhost:3030";


        public HttpConnectionController() {
            this._client.BaseAddress = new Uri(_baseAddress);
            this._client.DefaultRequestHeaders.Accept.Clear();
            this._client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static void GetContent(Task<HttpResponseMessage> response) {
            HttpResponseMessage message = response.Result;      
            Task<string> data=message.Content.ReadAsStringAsync();
            data.Wait();
            var result=data.Result;
            JsonParserUtility.JSONDataHandler(result);
        }

        public static  HttpStatusCode GetReponseStatusCode(Task<HttpResponseMessage> response)
        {

            HttpResponseMessage message = response.Result;
            //Task<string> data = message.
            //data.Wait();
            if (message.IsSuccessStatusCode)
                {
               
                Console.WriteLine(message.StatusCode.ToString());
                return message.StatusCode;
                }
                else
                {
                    // problems handling here
                    Console.WriteLine(
                        "Error occurred, the status code is: {0}",
                        message.StatusCode
                    );

                
                }

            return message.StatusCode;
        }





        public void GetResourceName() {

         
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


        public  static void GetClientConnection() {

       
           




        }
    }
}
