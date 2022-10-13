using DisasterWebsiteAppr.Data;
using DisasterWebsiteAppr.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Controllers
{
    public class AdminController : Controller
    {
        private readonly AlleviationContext context;

        public AdminController(AlleviationContext context)
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


        
    }
}
