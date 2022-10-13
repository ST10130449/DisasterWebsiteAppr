using DisasterWebsiteAppr.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Controllers
{
    public class UserController : Controller
    {

        private readonly AlleviationContext context;

        public UserController(AlleviationContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
