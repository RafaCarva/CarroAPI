using System;
using System.Collections.Generic;
using System.Text;
using CarroAPI.Domain;

namespace CarroAPI.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> Query(string query);
        /*
        Carro FindByKey(Guid key);

        List<T> List();

        void Add(T obj);
        */
    }
}
