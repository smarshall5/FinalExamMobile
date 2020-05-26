using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FinalExamMobile.Models;
using RestSharp;

namespace FinalExamMobile.Data
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public List<Quote> Quotes { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Quote>> RefreshDataAsync()
        {
            Quotes = new List<Quote>();
           


 
            try
            {
          
                    var client = new RestClient("https://andruxnet-random-famous-quotes.p.rapidapi.com/?cat=famous&count=1");
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("x-rapidapi-host", "andruxnet-random-famous-quotes.p.rapidapi.com");
                    request.AddHeader("x-rapidapi-key", "fdacf77d6amsh53a7e7d443a0b8ap15562djsncf3ba9ec47f6");
                    IRestResponse response = client.Execute(request);
                    Debug.WriteLine("XXXX: " + response.ToString());
                   /* if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        // Debug.WriteLine(content);
                        Quote quote = JsonConvert.DeserializeObject<Quote>(content);
                        Debug.WriteLine(quote);
                        Quotes.Add(quote);
                    } */
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Quotes;
        }

        public Task SaveTodoCatFactAsync(Quote item, bool isNewItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCatFactAsync(string id)
        {
            throw new NotImplementedException();
        }




        //      Task<List<CatFact>> IRestService.RefreshDataAsync()
        //      {
        //          throw new NotImplementedException();
        //      }


    }
}
