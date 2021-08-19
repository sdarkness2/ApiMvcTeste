using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TesteMVCApi.Services;
using TesteMVCApi.Models;

namespace TesteMVCApi.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            ClienteService service = new ClienteService();
            List<Cliente> clientes = service.GetClientes();

            //foreach (var p in produtos)
            //{
            //    System.Console.WriteLine(p);
            //}

            return View();
        }
    }
}
