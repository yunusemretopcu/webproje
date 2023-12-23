using Hospital.Api.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IRepositoryManager _manager;

        public PatientController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetPatientById(string id)
        {
            var patient = _manager.PatientRepository.GetByIdAsync(id, false);
            return Ok(patient);
        }
        [HttpGet]
        public IActionResult GetPatients() 
        {
            var patients = _manager.PatientRepository.GetAll();
            return Ok(patients);
        }
    }
}
