using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Persistence.Context;

namespace Hospital.Api.İnfrastructure.Persistence.Repositories
{


    public class AppointmentRepository :GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalContext context) : base(context)
        {

        }
    }
}
