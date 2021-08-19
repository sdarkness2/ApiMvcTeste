using System.Collections.Generic;
using System.Linq;
using TesteMVCApi.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TesteMVCApi.Services
{
    public class ClienteService
    {
        private  IEnumerable<Cliente> clientes;

        public ClienteService()
        {
            this.clientes = new List<Cliente>();
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            IEnumerable<Cliente> clientes = await this.GetAllClientes();
            return clientes.ToList();
        }

        private async Task<IEnumerable<Cliente>> GetAllClientes()
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
                        clientes =  JsonConvert.DeserializeObject<IEnumerable<Cliente>>(strJson).ToList();

                        return clientes;
                    }

                    return null;
                }
            }

            
        }

    }
}
