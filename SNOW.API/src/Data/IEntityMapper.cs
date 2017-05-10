using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SNOW.API.Core.Data
{
    public interface IEntityMapper
    {
        IEnumerable<IEntityMap> Mappings { get; }

        void MapEntities(ModelBuilder modelBuilder);
    }
}
