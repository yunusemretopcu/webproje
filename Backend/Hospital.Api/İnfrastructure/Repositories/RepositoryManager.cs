using Hospital.Api.Application.Repositories;
using Hospital.Api.İnfrastructure.Context;

namespace Hospital.Api.İnfrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly HospitalContext _context;

        private readonly IPatientRepository _patientRepository;

        public RepositoryManager(HospitalContext context, IPatientRepository patientRepository)
        {
            _context = context;
            _patientRepository = patientRepository;
        }

        public IPatientRepository PatientRepository => _patientRepository;

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
