using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using BesyBuyBDD.Utility;


namespace BesyBuyBDD.Steps
{
    [Binding]
    class ProductsInfomrationStep
    {
        private HttpClient _client=null;


       [Given(@"I have connected with the BestBuy API client")]
        public void GivenIHaveConnectedWithTheBestBuyAPIClient()
        {
            HttpConnectionController clientController = new HttpConnectionController();
            _client = clientController._client;
            
        }

    }
}
