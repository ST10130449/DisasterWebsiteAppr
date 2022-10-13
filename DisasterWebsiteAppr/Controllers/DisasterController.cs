using DisasterWebsiteAppr.Data;
using DisasterWebsiteAppr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            var disasters = context.Disasters.Include(d => d.Category);
            return View(disasters.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(context.Categories, "CId", "CName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Disaster model)
        {
            if (ModelState.IsValid)
            {
                var data = new Disaster()
                {
                    DName = model.DName,
                    Location = model.Location,
                    Description = model.Description,
                    Started = model.Started,
                    Ended = model.Ended,
                    Allocation = model.Allocation,
                    CId = model.CId
                };

                context.Disasters.Add(data);
                context.SaveChanges();
                TempData["message"] = "Disaster Captured Saved!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["message"] = "Empty field can't be submited!";

            }
            ViewBag.CategoryId = new SelectList(context.Categories, "CId", "CName", model.CId);
            return View(model);
        }
    }
}
