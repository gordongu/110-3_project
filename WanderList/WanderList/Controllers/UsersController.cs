using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WanderList.Models;

namespace WanderList.Controllers
{
    public class UsersController : Controller
    {
        private readonly WanderListContext _context;

        public UsersController(WanderListContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .SingleOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.SingleOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,Password")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .SingleOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.SingleOrDefaultAsync(m => m.UserId == id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserId == id);
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
                var obj = _context.User.Where(a => a.UserName.Equals(usr.UserName) && a.Password.Equals(usr.Password)).FirstOrDefault();
                if (obj != null)
                {
					HttpContext.Session.SetString("UserID", usr.UserId.ToString());
					HttpContext.Session.SetString("UserName", usr.UserName);
                    return RedirectToAction("Dashboard", new { id = obj.UserId });
                }
            }
            return View(usr);
        }

        public ActionResult Dashboard(int id)
        {
			if (HttpContext.Session.GetString("UserID") != null)
			{
				if (_context.SavedLocation.Count() >= 5)
				{
					return RedirectToAction("DashboardAlt");
				}
				else
				{
					User usr = _context.User.Where(x => x.UserId == id).FirstOrDefault();
					ViewData["UserObj"] = usr;

					var count = _context.Location.Count();
					var r = new Random();
					int rInt = r.Next(1, count + 1);

					Location loc = _context.Location.Where(x => x.LocationId == rInt).FirstOrDefault();
					ViewData["Location"] = loc;
				}
			}

            //google key AIzaSyDNbfgtL8yX8SQDMaL2GkV62Onl9b1vrF8 
            return View();
        }

		public ActionResult DashboardAlt()
		{
			if (HttpContext.Session.GetString("UserID") != null)
			{
				var savLocs = _context.SavedLocation.ToList();
				Location loc = _context.Location.Where(x => x.LocationId == savLocs[0].LocationId).FirstOrDefault();
				ViewData["Location1"] = loc;

				loc = _context.Location.Where(x => x.LocationId == savLocs[1].LocationId).FirstOrDefault();
				ViewData["Location2"] = loc;

				loc = _context.Location.Where(x => x.LocationId == savLocs[2].LocationId).FirstOrDefault();
				ViewData["Location3"] = loc;

				loc = _context.Location.Where(x => x.LocationId == savLocs[3].LocationId).FirstOrDefault();
				ViewData["Location4"] = loc;

				loc = _context.Location.Where(x => x.LocationId == savLocs[4].LocationId).FirstOrDefault();
				ViewData["Location5"] = loc;
			}

			return View();
		}

		public ActionResult Like(int locId)
		{
			if (ModelState.IsValid)
			{
				SavedLocation savLoc = new SavedLocation();
				savLoc.UserId = Int32.Parse(HttpContext.Session.GetString("UserID"));
				savLoc.LocationId = locId;
				_context.Add(savLoc);
				_context.SaveChanges(); // Comment out to not save changes to database

				ViewedLocation viewLoc = new ViewedLocation();
				viewLoc.UserId = Int32.Parse(HttpContext.Session.GetString("UserID"));
				viewLoc.LocationId = locId;
				_context.Add(viewLoc);
				//_context.SaveChanges();
			}

			return RedirectToAction("Dashboard");
		}

		public ActionResult Dislike(int locId)
		{
			if (ModelState.IsValid)
			{
				ViewedLocation viewLoc = new ViewedLocation();
				viewLoc.UserId = Int32.Parse(HttpContext.Session.GetString("UserID"));
				viewLoc.LocationId = locId;
				_context.Add(viewLoc);
				//_context.SaveChanges();
			}

			return RedirectToAction("Dashboard");
		}

		public void Confirm(int locId)
		{
			Location loc = _context.Location.Where(x => x.LocationId == locId).FirstOrDefault();
			string search = "https://www.google.com/search?q=" + loc.Name;

			Response.Redirect(search);
		}
	}
}
