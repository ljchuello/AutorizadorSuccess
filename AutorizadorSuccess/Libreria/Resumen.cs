using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace AutorizadorSuccess.Libreria
{
    public class Resumen
    {
        public string Clave { set; get; } = string.Empty;
        public string Valor { set; get; } = string.Empty;

        public async Task<List<Resumen>> Get_Async(string url)
        {
            return await Task.Run(() =>
            {
                List<Resumen> list = new List<Resumen>();
                try
                {
                    RestClient restClient = new RestClient($"{url}api/resumen");
                    var request = new RestRequest(Method.GET);
                    IRestResponse response = restClient.Execute(request);
                    list = JsonConvert.DeserializeObject<List<Resumen>>(response.Content) ?? new List<Resumen>();
                }
                catch (Exception ex)
                {
                    list.Add(new Resumen { Clave = "Ah ocurrido un error", Valor = $"{ex.Message}" });
                }

                return list;
            });
        }
    }
}
