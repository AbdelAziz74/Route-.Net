using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MVC_03.PL.Controllers
{
    public class AccountController(UserManager<string> userManager) : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            userManager.CreateAsync();
            return View();
        }
    }
}
