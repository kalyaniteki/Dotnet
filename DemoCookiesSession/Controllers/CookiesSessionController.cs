using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCookiesSession.Models;


namespace DemoCookiesSession.Controllers
{
    [Route("[Controller]/[action]")]
    //[Route("[action]")]
    public class CookiesSessionController : Controller
    {
        public readonly UserAccContext _context;
        public CookiesSessionController(UserAccContext context)
        {
            this._context = context;
        }

        // GET: CookiesSession
        [Route("")]
        
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.Username + " has got suucessfully register";
                return RedirectToAction("Login");
                
            }
            catch
            {
                ViewBag.message = uc.Username + " registration failed";
                return View();
            }
            
        }
      // [Route("CookiesSession")]
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(UserAccount uc)
        {
            var loguser = _context.UserAccount.Where(e => e.Username == uc.Username && e.Password == uc.Password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.Message = "not valid user";
                return View();
            }
            else
            {
                //to store session values
                HttpContext.Session.SetString("Uname", uc.Username);
                //Response.Cookies[]
               HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());

                return RedirectToAction("CreateDashBoard");
            }

        }
        public ActionResult CreateDashBoard()
        {

            if (HttpContext.Session.GetString("Uname") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("Uname").ToString();
                ViewBag.loglast = HttpContext.Session.GetString("lastLogin").ToString();
                if (Request.Cookies["lastLogin"] != null)

                    ViewBag.loglast = Request.Cookies["lastlogin"].ToString();
            }
            return View();
        }
        public ActionResult Logout()
        {
            Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

            // GET: CookiesSession/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: CookiesSession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookiesSession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookiesSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookiesSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookiesSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookiesSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}