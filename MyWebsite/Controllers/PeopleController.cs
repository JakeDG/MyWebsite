using MyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List <PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Jacob", LastName = "Gidley", Age = 24 });
            people.Add(new PersonModel { FirstName = "Bob", LastName = "Dylan", Age = 67 });
            people.Add(new PersonModel { FirstName = "Franco", LastName = "Livoti", Age = 29 });

            return View(people);
        }
    }
}