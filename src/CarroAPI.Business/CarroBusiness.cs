using System;
using System.Collections.Generic;
using CarroAPI.Domain;
using CarroAPI.Repository;

namespace CarroAPI.Business
{
    public class CarroBusiness : ICarroBusiness
    {

        private readonly IRepository<Carro> _carroRepository;

        public CarroBusiness(IRepository<Carro> carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public void Add(Carro carro)
        {
            _carroRepository.Add(carro);
        }

        public Carro FindByKey(Guid key)
        {
            return _carroRepository.FindByKey(key);
        }

        public List<Carro> List()
        {
            return _carroRepository.List();
        }
    }
}
