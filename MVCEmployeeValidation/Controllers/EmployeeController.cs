using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCEmployeeValidation.Models;
using MVCEmployeeValidation.Repositoreis;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCEmployeeValidation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.Designation = new SelectList(new string[] { "Developer", "Tester", "DataAnalyst" });
            ViewBag.Project = new SelectList(new string[] { "banking", "shopping", "govt" });
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee item)
        {
            EmployeeRepositories empres = new EmployeeRepositories();
            empres.Add(item);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int id,string pass)
        {
            EmployeeRepositories emr = new EmployeeRepositories();
            Employee emp = emr.Validate(id, pass);
            if(emp!=null)
            {
                return RedirectToAction("Details", emp);
            }
            else
            {
                ViewData["err"] = "Invalid credentials";
                return View();
            }
        }
        public IActionResult Details(Employee item)
        {
            return View(item);
        }
    }
}