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

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var data = context.Users.Where(e => e.Email == model.Email).SingleOrDefault();
                if (data != null)
                {
                    bool isValid = (data.Email == model.Email && data.Password == model.Password);
                    if (isValid)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Email) },
                            CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("Email", model.Email);
                        return RedirectToAction("Index", "Area");
                    }
                    else
                    {
                        TempData["errorPassword"] = "Invalid Password!";
                        return View(model);
                    }

                }
                else
                {
                    TempData["errorEmail"] = "Email does not exist!";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Register()
        {
            return View();
        }     

        [HttpPost]
        public IActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    Email = model.Email,
                    Password = model.Password 
                };

                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "Registration Succesful";
                return RedirectToAction("Login");
            }
            else
            {
                TempData["errorMessage"] = "Error, Fill in the form";
                return View(model);
            }

        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}
