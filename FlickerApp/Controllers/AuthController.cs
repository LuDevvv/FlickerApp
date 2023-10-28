using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlickerApp.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
<<<<<<< HEAD
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string password)
        {
=======
            bool isUserAuthenticated = false; 

            if (!isUserAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }

>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
            return View();
        }

        public ActionResult Singup()
        {
            return View();
        }
<<<<<<< HEAD

        public ActionResult Restorepassword() 
        {
            return View();  
        }

        //public ActionResult Logout() { }
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
