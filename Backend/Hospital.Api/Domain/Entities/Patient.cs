using Hospital.Api.Domain.Entities.Common;

namespace Hospital.Api.Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public  ICollection<Appointment> Appointments { get; set; }
        public string Email { get; set; }
    }
}
