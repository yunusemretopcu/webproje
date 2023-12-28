using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Persistence.Context;

namespace Hospital.Api.İnfrastructure.Persistence.Repositories
{
    public class PoliclinicRepository : GenericRepository<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(HospitalContext context) : base(context)
        {
        }
    }
}
