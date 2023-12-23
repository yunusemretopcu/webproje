namespace Hospital.Api.Application.Repositories
{
    public interface IRepositoryManager
    {
        IPatientRepository PatientRepository { get; }

        void Save();
    }
}
