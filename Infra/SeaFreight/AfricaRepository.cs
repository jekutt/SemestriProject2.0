using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.SeaFreight
{
    public class AfricaRepository : UniqueEntityRepository<Africa, AfricaData>, IAfricaRepository
    {
        public AfricaRepository(SeaFreightDbContext c) : base(c, c.Africa) { }

        protected internal override Africa toDomainObjects(AfricaData d) => new Africa(d);

    }
}
