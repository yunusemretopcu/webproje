using Hospital.Api.Domain.Entities.Common;

namespace Hospital.Api.Domain.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
        public ICollection<Appointment> Appointments { get; set; }     
    }
}
