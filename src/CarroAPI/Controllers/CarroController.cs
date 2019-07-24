using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarroAPI.Domain;
using CarroAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarroAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarroController : Controller
    {

        private readonly CarroServices _carroServices;


        public CarroController()
        {
            _carroServices = new CarroServices();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Carro>> Get()
        {
            return _carroServices.List();
        }

        [HttpPost]
        public void Post([FromBody] Carro carro)
        {
            _carroServices.Add(carro);
        }

    }
}