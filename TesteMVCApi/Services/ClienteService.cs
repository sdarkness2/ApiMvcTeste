using System.Collections.Generic;
using System.Linq;
using TesteMVCApi.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace TesteMVCApi.Services
{
    public class ClienteService
    {
        private List<Cliente> clientes;

        public ClienteService()
        {
            this.clientes = new List<Cliente>();
        }

        public List<Cliente> GetClientes()
        {
            IAsyncEnumerable<Cliente> clientes = this.GetAllClientes();
            return clientes.ToListAsync().Result;
        }

        private async IAsyncEnumerable<Cliente> GetAllClientes()
        {
            // Consumo da API
            var uri = "http://localhost:17616/produtos";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var strJson = await response.Content.ReadAsStringAsync();
                        clientes = JsonConvert.DeserializeObject<IEnumerable<Cliente>>(strJson).ToList();
                        foreach (var p in clientes)
                        {
                            yield return p;
                        }
                    }
                }
            }
        }

    }
}
