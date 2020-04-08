using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Five.Models;

namespace Five.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> me = new List<string>();
            foreach(Me f in Me.GetFive())
            {
                string name = f.Name;
                string height = f.Height;
                string weight = f.Weight;
                string gender = f.Gender;
                me.Add(string.Format("Name: {0}, Height: {1}, Weight: {2}, Gender: {3}.", name, height, weight, gender));
            }
            return View(me);
        }
    }
}