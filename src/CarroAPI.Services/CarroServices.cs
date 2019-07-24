using CarroAPI.Business;
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

        public List<Carro> List()
        {
            return _carroBusiness.List();
        }

        public void Add(Carro carro)
        {
            _carroBusiness.Add(carro);
        }

        public Carro FindByKey(Guid key)
        {
            return _carroBusiness.FindByKey(key);
        }
    }
}
