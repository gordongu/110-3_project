using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WanderList.Models;

namespace WanderList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Discover()
        {
            ViewData["Message"] = "Find new locations!";

            return View();
        }

		public IActionResult Login()
		{
			return View();
		}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User usr)
        {
            if (ModelState.IsValid)
            {
                WanderListContext db = new WanderListContext(new Microsoft.EntityFrameworkCore.DbContextOptions<WanderListContext>());
                var obj = db.User.Where(a => a.UserName.Equals(usr.UserName) && a.Password.Equals(usr.Password)).FirstOrDefault();
                if (obj != null)
                {
                    HttpContext.Items["User"] = obj;
                    return RedirectToAction("DashBoard");
                }
            }
            return View(usr);
        }

        public ActionResult DashBoard()
        {
            if (HttpContext.Items["User"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult SignUp()
		{
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
