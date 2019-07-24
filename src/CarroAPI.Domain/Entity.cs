using System;
using System.Collections.Generic;
using System.Text;

namespace CarroAPI.Domain
{
    public abstract class Entity : IEntity
    {
        public Guid key { get; }

        protected Entity()
        {
            key = Guid.NewGuid();
        }
    }
}