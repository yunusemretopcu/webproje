using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Persistence.Context;

namespace Hospital.Api.İnfrastructure.Persistence.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalContext context) : base(context)
        {
        }
    }
}
