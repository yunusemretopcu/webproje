using Microsoft.AspNetCore.Identity;

namespace Hospital.Api.Application.Services
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles { get; }
        IEnumerable<IdentityUser> GetAllUsers();
    }
}
