using CarroAPI.Domain;
using CarroAPI.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebStoreAPI.Repository;

namespace CarroAPI.Repository
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {

        private readonly List<Carro> _data;

        public CarroRepository(ILogger<Repository<Carro>> logger) : base(logger)
        {

        }

        public List<Carro> ListAllCarros()
        {
            var query = "select * from produto";
            return this.Query(query).ToList();
        }

    }
}
