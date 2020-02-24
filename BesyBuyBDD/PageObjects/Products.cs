using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BesyBuyBDD.Models;
using BesyBuyBDD.Utility;

namespace BesyBuyBDD.PageObjects
{

    /// <summary>
    ///products - a subset of ~50,000 products available at Best Buy.
    ///Find, create, update and remove products
    /// </summary>
    class Products : HttpConnectionController
    {
        Products _product;
        HttpClient _client=null;

        Products() {
            
        }

        public void FindProduct(string resourceName) {
            var controller = new HttpConnectionController();
            _client = controller._client;
            var resouceData = _client.GetAsync(resourceName);
           
        }

        public static void CreateProduct()
        {

        }

        public static void UpdateProduct()
        {

        }

        public static void DeleteProduct()
        {

        }


        

    }
}


// Ploymorphism { Static (Method, Operator Overloading ) and Dynamic ( virtual overriding and method overring) }
