using System;
using System.Collections.Generic;
using System.Text;
using CarroAPI.Domain;

namespace CarroAPI.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        Carro FindByKey(Guid key);

        List<T> List();

        void Add(T obj);
    }
}
