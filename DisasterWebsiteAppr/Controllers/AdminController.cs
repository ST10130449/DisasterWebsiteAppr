using DisasterWebsiteAppr.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
