using CarroAPI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarroAPI.Services
{
    public interface ICarroServices
    {
        IEnumerable<Carro> ListAllCarros();
    }
}
