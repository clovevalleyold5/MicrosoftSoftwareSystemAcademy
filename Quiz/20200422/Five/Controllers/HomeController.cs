using Microsoft.AspNetCore.Mvc;
using Five.Models;
using System.Linq;

namespace Five.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
        [HttpGet]
        public ViewResult JoinOasis()
        {
            return View();
        }
        [HttpPost]
        public ViewResult JoinOasis(Spartan spartan)
        {
            if (ModelState.IsValid)
            {
            Repository.AddSpartan(spartan);
            return View("Thanks", spartan);
            }
            else
            {
                return View();
            }
        }
        public ActionResult Roster(string searchby, string search)
        {
            if (searchby == "Name")
            {
                return View(Repository.Spartans.Where(p => p.Name == search || search == null));
            }
            else if (searchby == "Height")
            {
                return View(Repository.Spartans.Where(p => p.Height == search || search == null));
            }
            else if (searchby == "Weight")
            {
                return View(Repository.Spartans.Where(p => p.Weight == search || search == null));
            }
            else
            {
                return View(Repository.Spartans.Where(p => p.Gender == search || search == null));
            }
        }
    }
}