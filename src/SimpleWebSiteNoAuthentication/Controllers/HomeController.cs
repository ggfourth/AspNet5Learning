using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SimpleWebSiteNoAuthentication.Models;

namespace SimpleWebSiteNoAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Proba(Person person)
        {
            ViewData["Message"] = "Tova e probnata stranica 4";

            return View(new Person
            {
                FirstName = "Georgi",
                LastName = "Georgiev",
                Birthday = new DateTime(1983, 9, 19)
            });
        }

        public IActionResult Proba()
        {
            ViewData["Message"] = "Tova e probnata stranica 4";

            return View(new Person
            {
                FirstName = "Georgi",
                LastName = "Georgiev",
                Birthday = new DateTime(1983, 9, 19)
            });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
