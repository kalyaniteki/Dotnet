using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCUsingModelValidation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCUsingModelValidation.Repositories;
namespace MVCUsingModelValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { "India", "USA", "UK" });
            return View();
        }
        [HttpPost]
        //not having any view templates
        public IActionResult Create(User item)
        {
            UserRepositories repository = new UserRepositories();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pass)
        {
            UserRepositories Rep = new UserRepositories();
            User user = Rep.Validate(uname, pass);
            if (user != null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid credentials";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name")] User item)
        {
            return View(item);
        }
        public IActionResult Register()
        {
            //ViewBag.Country = new SelectList(new string[] { " ","India", "USA", "UK" });
            return View();
        }
        [HttpPost]
        public IActionResult Register(User item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
    }
}