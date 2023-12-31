using Hospital.Api.Application.Repositories;
using Hospital.Api.Domain.Entities;
using Hospital.Api.İnfrastructure.Context;

namespace Hospital.Api.İnfrastructure.Repositories
{


    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalContext context) : base(context)
        {

        }
    }
}
