
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TimePad.Models;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace TimePad
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
            if (Device.RuntimePlatform == Device.UWP)
            {
                //_client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
                //_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            }
           
        }

        public async Task<List<TimePadItem>> GetRepositoriesAsync(string uri)
        {
            List<TimePadItem> repositories = new List<TimePadItem>();

            try
            {
                //RnD
                _client.DefaultRequestHeaders.Add("cache-control", "no-cache");
                _client.DefaultRequestHeaders.Add("Accept", "application/json");

                _client.DefaultRequestHeaders.Add("Authorization", "Bearer b1d6474665c596700f288521758c76c23b106fd0");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[ex] Exception: " + ex.Message);
            }

            try
            {
                
                HttpResponseMessage response = await _client.GetAsync(uri);
                
                if (response.IsSuccessStatusCode)
                {
                    
                    string json = await response.Content.ReadAsStringAsync();

                    //repositories = JsonConvert.DeserializeObject<List<Repository>>(content);


                    //List<Repository> pocketItems = new List<Repository>();
                    //PocketItem RItem = new PocketItem();

                    //JsonDocument apiJsonDocument = JsonDocument.Parse(json);
                    JToken apiJsonDocument = JToken.Parse(json);

                    //JsonElement jsonElement;
                    JToken jsonElement;
                    string statusString = "";

                    //(apiJsonDocument.Root.GetProperty("status", out jsonElement))
                    jsonElement = apiJsonDocument.Root.SelectToken("total");

                    if (jsonElement != null)
                        statusString = jsonElement.ToString();

                    if (1 == 1)//(statusString == "1")
                    {
                        IJEnumerable<JToken> Llist = apiJsonDocument.Root.SelectToken("values").AsJEnumerable();

                        // RnD: JsonProperty
                        foreach (JToken pocketItemJsonProperty in Llist)
                        {
                                          
                            string s = pocketItemJsonProperty.ToString();
                            /*
                            int found = s.IndexOf(":");
                            s = s.Substring(found + 2);                    

                            //RnD
                            //found = s.LastIndexOf("}");                    
                            //s = s.Substring(0, s.Length - 2);           


                            PocketItem pocketItem = JsonConvert.DeserializeObject<PocketItem>(s);
                            */

                            //PocketItem pocketItem = Converters.PocketConverter.ConvertJsonToPocketItem(pocketItemJsonProperty);

                            //pocketItems.Add(pocketItem);

                            TimePadItem timepadItem = JsonConvert.DeserializeObject<TimePadItem>(s);

                            timepadItem.Name = timepadItem.Name.Trim();
                            timepadItem.Name = timepadItem.Name.Replace("&quot;", @"""");
                            timepadItem.Name = timepadItem.Name.Replace("&amp;quot;", @"""");

                            timepadItem.CategoriesPlain = "";

                            foreach (var c_item in timepadItem.Categories)
                            {
                                timepadItem.CategoriesPlain = timepadItem.CategoriesPlain 
                                    + " " 
                                    + c_item.ToString();
                            }
                            timepadItem.CategoriesPlain = timepadItem.CategoriesPlain.Trim();


                            timepadItem.LocationPlain = timepadItem.Location.Country
                                + ", " + timepadItem.Location.City
                                + ", " + timepadItem.Location.Address;

                            timepadItem.LocationPlain = timepadItem.LocationPlain.Replace("&quot;", @"""");
                            timepadItem.LocationPlain = timepadItem.LocationPlain.Replace("&amp;quot;", @"""");



                            repositories.Add(timepadItem);

                        }
                    }

                }


                Debug.WriteLine("\tStatusCode {0}", response.StatusCode);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return repositories;
        }
    }
}
