using CarroAPI.Business;
using CarroAPI.Business.Interfaces;
using CarroAPI.Domain;
using CarroAPI.Repository;
using System;
using System.Collections.Generic;

namespace CarroAPI.Services
{
    public class CarroServices : ICarroServices
    {
        private readonly ICarroBusiness _carroBusiness;

        public CarroServices(ICarroBusiness carroBusiness)
        {
            _carroBusiness = carroBusiness;
        }

        public IEnumerable<Carro> ListAllCarros()
        {
            return _carroBusiness.ListAllCarros();
        }
    }
}
