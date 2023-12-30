using Microsoft.AspNetCore.Mvc;

namespace Hospital.Client.Controllers
{
    public class PoliclinicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
