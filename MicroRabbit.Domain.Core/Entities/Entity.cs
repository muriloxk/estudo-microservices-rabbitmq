using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = new Guid();
        }
    }
}
