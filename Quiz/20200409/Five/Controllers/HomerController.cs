using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Five.Models;

namespace Five.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.People);
        //public ViewResult Index()
        //{
        //    List<string> me = new List<string>();
        //    foreach(Person f in Person.GetFive())
        //    {
        //        string name = f.Name;
        //        string height = f.Height;
        //        string weight = f.Weight;
        //        string gender = f.Gender;
        //        me.Add(string.Format("Name: {0}, Height: {1}, Weight: {2}, Gender: {3}.", name, height, weight, gender));
        //    }
        //    return View(me);
        //}
    }
}