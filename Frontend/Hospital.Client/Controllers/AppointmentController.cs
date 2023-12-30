using Microsoft.AspNetCore.Mvc;

namespace Hospital.Client.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
