using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlickerApp.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            bool isUserAuthenticated = false; 

            if (!isUserAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }

            return View();
        }

        public ActionResult Singup()
        {
            return View();
        }
    }
}
