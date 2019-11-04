using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculoPesoWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoPesoWebApi.Controllers
{
    public partial class CalculadorasController : ControllerBase
    {

        [HttpGet]
        [Route("/api/Calculadoras/Massa/")]
        public object Massa(Calculadora objeto)
        {
            objeto.Peso = objeto.Volume * objeto.Densidade * 9.807;
            return objeto;
        }
    }
}