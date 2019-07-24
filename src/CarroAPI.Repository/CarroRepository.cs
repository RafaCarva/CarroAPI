using CarroAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarroAPI.Repository
{
    public class CarroRepository : IRepository<Carro>
    {

        private readonly List<Carro> _data;

        public CarroRepository()
        {
            _data = new List<Carro>();
        }

        public void Add(Carro obj)
        {
            _data.Add(obj);
        }

        public Carro FindByKey(Guid key)
        {
            return _data.FirstOrDefault(w => w.key == key);
        }

        public List<Carro> List()
        {
            return _data;
        }
    }
}
