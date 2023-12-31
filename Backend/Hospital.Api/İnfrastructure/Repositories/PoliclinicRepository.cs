using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Context;

namespace Hospital.Api.İnfrastructure.Repositories
{
    public class PoliclinicRepository : GenericRepository<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(HospitalContext context) : base(context)
        {
        }
    }
}
