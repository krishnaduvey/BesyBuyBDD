using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesyBuyBDD.Models
{
    class StatusCode
    {

        public static string GetStatus(int statusCode) {
            switch (statusCode) {
                case 200:
                    return "ok";

                default:
                    return "Not ok";
            }
        
        }
    }
}
