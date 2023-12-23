using Hospital.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Client.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
