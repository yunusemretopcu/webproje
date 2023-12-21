using Hospital.Api.Application.Repositories;
using Hospital.Api.İnfrastructure.Persistence.Context;
using Hospital.Api.İnfrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Hospital.Api.İnfrastructure.Persistence.Extensions
{
    public static class ServiceRegisteration//servis kayıtları burada
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<HospitalContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Singleton);
            services.AddScoped<IPatientRepository, PatientRepository>();
        }
    }
}
