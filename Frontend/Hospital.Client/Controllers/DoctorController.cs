using Microsoft.AspNetCore.Mvc;

namespace Hospital.Client.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
