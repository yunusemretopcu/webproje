using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Context;

namespace Hospital.Api.İnfrastructure.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalContext context) : base(context)
        {
        }
    }
}
