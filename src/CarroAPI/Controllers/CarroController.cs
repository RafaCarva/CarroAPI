using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarroAPI.Domain;
using CarroAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarroAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarroController : Controller
    {

        private readonly ICarroServices _carroServices;
        private readonly ILogger<CarroController> _logger;

        public CarroController(ICarroServices carroServices, ILogger<CarroController> logger)
        {
            _carroServices = carroServices;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Carro>> Get()
        {
            try
            {
                _logger.LogInformation("Received get request");
                return Ok(_carroServices.List());
            }
            catch(Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{Key}")]
        public ActionResult<Carro> Get([FromRoute] Guid key)
        {
            try
            {
                _logger.LogInformation("Received get request");
                return Ok(_carroServices.FindByKey(key));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Carro carro)
        {
            try
            {
                _logger.LogInformation("Received post request");
                if (ModelState.IsValid)
                {
                    _carroServices.Add(carro);
                    return Ok("success");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}