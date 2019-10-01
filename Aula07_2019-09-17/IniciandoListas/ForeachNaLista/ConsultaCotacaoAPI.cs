using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
namespace ForeachNaLista
{


    public class ConsultaCotacaoAPI
    {
        public string URL = string.Empty;
        private static string urlParameters = "";

        public double GetCotacao(string moedaAlvo)
        {
            Console.WriteLine("Consultando a cotação atual. . . Aguarde!");
            URL = $"http://economia.awesomeapi.com.br/jsonp/{moedaAlvo}/1";
            
            CotacaoApi cotacaoApi = new CotacaoApi();
            string json = JsonConvert.SerializeObject(cotacaoApi);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                //Parse the response body.
                var dataObjects = JsonConvert.DeserializeObject<List<CotacaoApi>>(response.Content.ReadAsStringAsync().Result); //response.Content.ReadAsStringAsync().Result;                
                CotacaoApi deserializedCotacaoApi = JsonConvert.DeserializeObject<CotacaoApi>(json);
                
                return deserializedCotacaoApi.high;
            }
            else
            {
                Console.Write("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return 0;
            }
        }
    }
}

