using System;
using System.Collections.Generic;
using System.Text;

namespace SNOW.API.Core.Model
{
    public interface IEntity<T>
    {
        int Id { get; set; }
    }
}
