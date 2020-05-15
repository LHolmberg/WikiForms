using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace WikiForms
{
    public class DataController
    {
        public string[][] list = new string[10][];


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
                var contentsJson = wc.DownloadString("https://en.wikipedia.org/w/api.php?action=parse&page=" + titles[1][i] + "&prop=text&formatversion=2&format=json");

                contentObject = (JObject)JsonConvert.DeserializeObject(contentsJson);
                string[] val = new string[2] { titles[1][i].ToString(), Regex.Replace(contentObject["parse"]["text"].ToString(), @"<[^>]*>", String.Empty) };
                list[i] = val;
            }
        }
    }
}
