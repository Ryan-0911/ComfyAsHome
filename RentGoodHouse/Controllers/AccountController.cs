using Microsoft.AspNetCore.Mvc;

namespace ComfyAsHome.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
