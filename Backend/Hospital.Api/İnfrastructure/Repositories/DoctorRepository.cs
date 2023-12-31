using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Context;

namespace Hospital.Api.İnfrastructure.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HospitalContext context) : base(context)
        {
        }
    }
}
