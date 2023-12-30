using Microsoft.AspNetCore.Mvc;

namespace Hospital.Client.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
