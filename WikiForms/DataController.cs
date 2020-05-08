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
            JArray titles, contents;
            string titleURL = "https://en.wikipedia.org/w/api.php?action=opensearch&search=" + searchTerm;
       

            using (WebClient wc = new WebClient())
            {
                var titlesJson = wc.DownloadString(titleURL);

                titles = (JArray)JsonConvert.DeserializeObject(json);
            }
            
            for (int i = 0; i < result[1].Count(); i++)
            {
                Dictionary<string, string> value = new Dictionary<string, string>();
                using (WebClient wc = new WebClient())
                {

                    var contentsJson = wc.DownloadString("https://en.wikipedia.org/w/api.php?action=parse&page=" + titles[1][i] + "&prop=wikitext&formatversion=2");

                    contents = (JArray)JsonConvert.DeserializeObject(json);
                }
                value.Add(result[1][i].ToString(), contents[1][i]);
                list.AddLast(value);
                Console.WriteLine("Added");
            }
        }
    }
}
