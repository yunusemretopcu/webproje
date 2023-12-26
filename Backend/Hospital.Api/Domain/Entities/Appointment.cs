using Hospital.Api.Domain.Entities.Common;

namespace Hospital.Api.Domain.Entities
{
    public class Appointment :BaseEntity

    {
        public DateTime Day { get; set; }
        public Guid DoctorId  { get; set; }
        public Guid PatientId{ get; set; }
        
    }
}
