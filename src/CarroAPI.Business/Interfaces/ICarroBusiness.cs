using CarroAPI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarroAPI.Business.Interfaces
{
    public interface ICarroBusiness
    {
        List<Carro> ListAllCarros();
    }
}
