using Hospital.Api.Domain.Entities.Common;

namespace Hospital.Api.Domain.Entities
{
    public class Policlinic : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
