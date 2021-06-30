using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace AutorizadorSuccess.Libreria
{
    public class Autorizacion
    {
        public DateTime DateAt { set; get; } = new DateTime(1900, 01, 01);
        public string Descripcion { set; get; } = string.Empty;

        public async Task<List<Autorizacion>> Enviar_Async(string url, List<Autorizacion> list)
        {
            return await Task.Run(() =>
            {
                try
                {
                    // Hacemos la petición
                    RestClient restClient = new RestClient($"{url}api/v2/enviar/");
                    //restClient.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    IRestResponse response = restClient.Execute(request);
                    Resultado resultado = JsonConvert.DeserializeObject<Resultado>(response.Content) ?? new Resultado();

                    // Set
                    list.Add(new Autorizacion {DateAt = DateTime.Now, Descripcion = resultado.Messages});

                    // Sólo lo indicado
                    list = list.OrderByDescending(x => x.DateAt).Take(Configuracion.CantList).ToList();

                    // Esperamos
                    Thread.Sleep(resultado.IdleTime*1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                return list;
            });
        }

        public async Task<List<Autorizacion>> Recibir_Async(string url, List<Autorizacion> list)
        {
            return await Task.Run(() =>
            {
                try
                {
                    // Hacemos la petición
                    RestClient restClient = new RestClient($"{url}api/v2/recibir/");
                    //restClient.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    IRestResponse response = restClient.Execute(request);
                    Resultado resultado = JsonConvert.DeserializeObject<Resultado>(response.Content) ?? new Resultado();

                    // Set
                    list.Add(new Autorizacion { DateAt = DateTime.Now, Descripcion = resultado.Messages });

                    // Sólo lo indicado
                    list = list.OrderByDescending(x => x.DateAt).Take(Configuracion.CantList).ToList();

                    // Esperamos
                    Thread.Sleep(resultado.IdleTime * 1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                return list;
            });
        }
    }
}
