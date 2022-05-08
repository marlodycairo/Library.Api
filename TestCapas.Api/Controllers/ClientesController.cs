using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCapas.Api.Application;
using TestCapas.Api.Infrastructure.Context;

namespace TestCapas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteApplication clienteApplication;

        public ClientesController(IClienteApplication clienteApplication)
        {
            this.clienteApplication = clienteApplication;
        }

        //[HttpPost]
        //public int Sumar(int a, int b)
        //{
        //    return clienteApplication.Sumar(a, b);
        //}

        //[HttpGet]
        //public IEnumerable<Clientes> GetAll()
        //{
        //    return clienteApplication.GetAll();
        //}
    }
}
