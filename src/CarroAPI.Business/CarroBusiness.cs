using System;
using System.Collections.Generic;
using CarroAPI.Business.Interfaces;
using CarroAPI.Domain;
using CarroAPI.Repository;
using CarroAPI.Repository.Interfaces;

namespace CarroAPI.Business
{
    public class CarroBusiness : ICarroBusiness
    {

        private readonly ICarroRepository _carroRepository;

        public CarroBusiness(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public List<Carro> ListAllCarros()
        {
            return _carroRepository.ListAllCarros();
        }
    }
}
