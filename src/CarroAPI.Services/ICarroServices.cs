using CarroAPI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarroAPI.Services
{
    public interface ICarroServices
    {
        Carro FindByKey(Guid key);

        List<Carro> List();

        void Add(Carro carro);
    }
}
