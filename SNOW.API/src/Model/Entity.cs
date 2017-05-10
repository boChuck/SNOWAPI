using System;
using System.Collections.Generic;
using System.Text;

namespace SNOW.API.Core.Model
{
    public abstract class BaseEntity
    {

    }
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual int Id { get; set; }
    }
}
