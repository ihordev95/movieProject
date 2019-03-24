using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace Team3_Project.Helpers
{
    public class ODBAPI
    {

        public String GetAPIinfo(String apiString)
        {
            System.String urlAddress = "http://www.omdbapi.com/?apikey=61c1a60f&" + apiString + "&plot=full";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = response.CharacterSet == null ? new StreamReader(receiveStream)
					: new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

				System.String data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
                return data;
            }
            return null;
        }

        public void ParseSearch(List<Helpers.Watchable> list, String response)
        {
            System.Boolean inResults = false;
            System.String item = "";
            foreach(System.Char c in response)
            {
                if (c.Equals('['))
                {
                    inResults = true;
                    continue;
                }
                if (c.Equals(']')) {
                    inResults = false;
                }
                if(inResults)
                {
                    if (!(c.Equals(',') && item.Equals("")))
                    {
                        item = item + c;
                        if (c.Equals('}'))
                        {
                            list.Add(JsonConvert.DeserializeObject<Helpers.Watchable>(item));
                            item = "";
                        }
                    }
                }

                
            }

        }
    }
}