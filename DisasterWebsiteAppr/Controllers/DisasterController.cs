using DisasterWebsiteAppr.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Controllers
{
    public class DisasterController : Controller
    {

        private readonly AlleviationContext context;

        public DisasterController(AlleviationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
