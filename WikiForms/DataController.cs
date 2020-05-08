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
    public class DataController
    {
        public LinkedList<Dictionary<String, String>> list = new LinkedList<Dictionary<string, string>>();

        public DataController(string searchTerm)
        {
            JArray titles;
            JObject contentObject;
            WebClient wc = new WebClient();

            string titleURL = "https://en.wikipedia.org/w/api.php?action=opensearch&search=" + searchTerm;
       
            var titlesJson = wc.DownloadString(titleURL);

            titles = (JArray)JsonConvert.DeserializeObject(titlesJson);
            
            for (int i = 0; i < titles[1].Count(); i++)
            {
                Dictionary<string, string> value = new Dictionary<string, string>();
                var contentsJson = wc.DownloadString("https://en.wikipedia.org/w/api.php?action=parse&page="+ titles[1][i] +"&prop=wikitext&formatversion=2&format=json");

                contentObject = (JObject)JsonConvert.DeserializeObject(contentsJson);

                value.Add(titles[1][i].ToString(), contentObject["parse"]["wikitext"].ToString());
                list.AddLast(value);
                Console.WriteLine("Added");
            }
        }
    }
}
