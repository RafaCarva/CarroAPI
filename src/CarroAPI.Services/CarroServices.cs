using CarroAPI.Domain;
using CarroAPI.Repository;
using System;
using System.Collections.Generic;

namespace CarroAPI.Services
{
    public class CarroServices
    {
        public List<Carro> List()
        {
            return CarroRepository.Data;
        }

        public void Add(Carro carro)
        {
            CarroRepository.Data.Add(carro);
        }
    }
}
