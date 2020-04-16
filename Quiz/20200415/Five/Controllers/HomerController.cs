using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Five.Models;
using System.Linq;

namespace Five.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index() => View(SimpleRepository.SharedRepository.People);
        public ActionResult Index(string searchby, string search)
        {
            if (searchby == "Gender")
            {
                return View(SimpleRepository.SharedRepository.People.Where(p => p.Gender == search || search == null));
            }
            else if (searchby == "Name")
            {
                return View(SimpleRepository.SharedRepository.People.Where(p => p.Name==search || search == null));
            }
            else if (searchby == "Height")
            {
                return View(SimpleRepository.SharedRepository.People.Where(p => p.Height == search || search == null));
            }
            else
            {
                return View(SimpleRepository.SharedRepository.People.Where(p => p.Weight == search || search == null));
            }
        }
    }
}