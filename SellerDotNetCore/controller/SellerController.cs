using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using SellerDotNetCore.model;
namespace SellerDotNetCore.controller
{
    public class SellerController : Controller
    {
      //  sellerdetails sdetails = new sellerdetails();
        Iseller sdetails;
        public  SellerController(Iseller s)
        {
            sdetails = s;
        }
        public IActionResult Search(int? id)
        {
         //   int Id = (int)((id== null) ? 1 : id);
            Seller em = sdetails.GetEmployee(2);
            //if (em != null)
            //{
            //    return Content(em.id + "\n " + em.name + "\n" + em.password + "\n " + em.email + "\n" + em.phno);
            //}
            //return Content("Employee Does Not Exist");
            ViewData["id"] = em.id;
            ViewData["name"] = em.name;
            ViewData["phno"] = em.phno;
            ViewData["pass"] = em.password;
            return View();
        }
        public IActionResult displaySel()
        {
            List<Seller> sse = sdetails.display();
            return View(sse);
        }
        public IActionResult viewModel()
        {
           // List<Seller> sl = sdetails.display();
            Seller se = sdetails.GetEmployee(2);
            ModelView mv = new ModelView();
            mv.seller = se;
            mv.projectname = "Something I Never Told U";
            return View(mv);
        }
        public string Index()
        {
            return "helloooo";
        }
    }
}