using DisasterWebsiteAppr.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Controllers
{
    //Caregory Controller
    public class CategoryController : Controller
    {

        private readonly AlleviationContext context;

        public CategoryController(AlleviationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Categories.ToList();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
