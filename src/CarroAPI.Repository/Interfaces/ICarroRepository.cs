using System;
using System.Collections.Generic;
using CarroAPI.Domain;

namespace CarroAPI.Repository.Interfaces
{
    public interface ICarroRepository
    {
        List<Carro> ListAllCarros();
    }
}
