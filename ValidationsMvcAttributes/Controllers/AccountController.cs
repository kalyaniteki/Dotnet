using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationsMvcAttributes.Models;
namespace ValidationsMvcAttributes.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(Login item)
        {
            if (ModelState.IsValid)
            {
                //add model data to db table
                return RedirectToAction("Index");
            }//Modelstate validates Model
            else
            {
                return View();
            }
            // return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }//Modelstate validates Model
            else
            {
                return View();
            }
         

        }

    }
}