using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlickerApp.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            return View();
        }

        public ActionResult Singup()
        {
            return View();
        }

        public ActionResult Restorepassword() 
        {
            return View();  
        }

        //public ActionResult Logout() { }
    }
}
