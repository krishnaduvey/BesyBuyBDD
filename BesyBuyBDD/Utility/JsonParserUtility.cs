using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BesyBuyBDD.Utility
{
    class JsonParserUtility
    {

        public static void JSONDataHandler(string json) {

            JObject o = JObject.Parse(json);

            Console.WriteLine(o.ToString());

            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (var kv in dict)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }
        }


    }
}
