using Microsoft.EntityFrameworkCore;

namespace SNOW.API.Core.Data
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
