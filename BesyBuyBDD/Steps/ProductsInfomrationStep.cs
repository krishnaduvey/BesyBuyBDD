using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using BesyBuyBDD.Utility;
using System.Net;
using BesyBuyBDD.Models;
using NUnit.Framework;

namespace BesyBuyBDD.Steps
{
    [Binding]
    class ProductsInfomrationStep
    {
        private HttpClient _client=null;
        private Task<HttpResponseMessage> response = null;


        [Given(@"I have connected with the BestBuy API client '(.*)'")]
        public void GivenIHaveConnectedWithTheBestBuyAPIClient(string p0)
        {
            HttpConnectionController clientController = new HttpConnectionController();
            _client = clientController._client;
            _client.BaseAddress = new Uri(p0);
        }

        [When(@"User has access to Product '(.*)'")]
        public void WhenUserHasAccessToProduct(string p0)
        {
            response = this._client.GetAsync(p0);
        }

        [Then(@"Status is '(.*)'")]
        public void ThenStatusIs(string p0)
        {
            HttpStatusCode statucCode = HttpConnectionController.GetReponseStatusCode(response);
            StatusCode.GetStatus(int.Parse(statucCode.ToString()));
            Assert.AreEqual(p0, StatusCode.GetStatus(int.Parse(statucCode.ToString())));
        }

        [Then(@"Product information fetched")]
        public void ThenProductInformationFetched()
        {
            HttpConnectionController.GetContent(response);
          
        }


    }
}



