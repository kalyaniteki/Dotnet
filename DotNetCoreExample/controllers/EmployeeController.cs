using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using DotNetCoreExample.models;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreExample.controllers
{
    public class EmployeeController : Controller
    {
        //IEmployeeRepositories empRepositories = new EmployeeRepositories();
        private readonly IEmployeeRepositories empRepositories;//dependency injected object
        public EmployeeController(IEmployeeRepositories emRepositories)
        {
            empRepositories = emRepositories;
        }

        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee em = empRepositories.GetEmployee(ID);
            //if (em != null)
            //{

            //    return Content(em.id + "\n" + em.name + "\n " + em.email + "\n " + em.dept);
            //}
            //else
            //    return Content("employee does not exist");

            //ViewData["id"]= em.id;
            //ViewData["name"]= em.name;
            //ViewData["email"]= em.email;
            //ViewData["dept"]= em.dept;
            // ViewData["employee"] = em;
            //ViewBag.id = em.id;
            //ViewBag.name = em.name;
            //ViewBag.email = em.email;
            //ViewBag.dept = em.dept;

            return View(em);


        }
        public IActionResult Index()
        {
            List<Employee> elist = empRepositories.Displaydetails();
            return View(elist);
        }


        //public string Index()
        //{
        //    return "hello from mvc index";
        //}
        //public JsonResult About()
        //{
        //    return Json("{id:2;name:hello}");
        //}
        public ViewResult AboutUs()
        {
            Employee emp = empRepositories.GetEmployee(2);
            //ViewBag.projectname = "BookHive";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectname = "BookHive";
            return View(ep);
        }
        //public IActionResult GetAllEmployees()
        //{
        //    List<Employee> elist = empRepositories.Displaydetails();
        //    return View("~/Views/Employee/index.cshtml",elist);
        //    //absolute reference to view
        //}
        //public IActionResult GetAllEmployees()
        //{
        //    List<Employee> elist = (empRepositories.Displaydetails()).Where(e=>e.dept=="aaa").ToList();
        //    return View("~/Views/Employee/index.cshtml", elist);
        //    //display all related items
        //}
        public IActionResult GetAllEmployees()
        {
            List<Employee> elist = (empRepositories.Displaydetails()).Where(e => e.dept == Dept.IT).ToList();
            return View("index", elist);//relative path to refer a view

        }
        [HttpGet]
        public IActionResult Create()
        {
            //Employee emp1 = empRepositories.GetEmployee(2);
            //return View(emp1);
           return  View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                empRepositories.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            //else
            //return View("Fail");
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> elist = (empRepositories.Displaydetails());
            return View(elist);
        }
        public IActionResult Register(Employee employee)
        {
            bool res = empRepositories.AddEmployee(employee);
            //return View();
            return RedirectToAction("Index");
        }
        public bool IsExist(string email)
        {
            var result = (empRepositories.Displaydetails()).Find(r => r.email == email);
            if (result == null) return true;
            else
                return false;
        }
        [AcceptVerbs("Get","Post")]
        //[AllowAnonymous]
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("email exist");
        }
        public IActionResult _mypartial()
        {
            return View();
        }
    }
}