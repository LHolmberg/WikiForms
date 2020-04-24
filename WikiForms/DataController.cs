using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WikiForms
{
    class DataController
    {
        LinkedList<Dictionary<String, String>> list = new LinkedList<Dictionary<string, string>>();

        public DataController(string searchTerm)
        {
            JArray result;
            string URL = "https://en.wikipedia.org/w/api.php?action=opensearch&search=" + searchTerm;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(URL);

                result = (JArray)JsonConvert.DeserializeObject(json);
            }
            for (int i = 0; i < result[1].Count(); i++)
            {
                Dictionary<string, string> value = new Dictionary<string, string>();
                value.Add(result[1][i].ToString(), result[3][i].ToString());
                list.AddLast(value);
                Console.WriteLine("Added");
            }
        }
    }
}
