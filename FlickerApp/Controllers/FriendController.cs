﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlickerApp.Controllers
{
    public class FriendController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
