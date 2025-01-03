﻿using HelperTag.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace HelperTag.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<Person> person = new List<Person>()
            {
                   new Person { Id = 1, Name = "Mohammadreza", Family = "Ahadian", Description = "Description...", Gender = true },
                   new Person { Id = 2, Name = "Ahmadreza", Family = "Jafari", Description = "Description....", Gender = true },
                   new Person { Id = 3, Name = "Alireza", Family = "Akbari", Description = "Description...", Gender = true },
                   new Person { Id = 4, Name = "Hoda", Family = "Mahmodi", Description = "Description...", Gender = false },
                   new Person { Id = 5, Name = "Tanaz", Family = "Rezaei", Description = "Description", Gender = false }
            };
            return View(person);
        }

        public IActionResult Info()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = " Prénom",
                Family = "nom",
                Gender = true,
                Description = "Description..."

            };
            return View(person);
        }
        [HttpPost]
        public IActionResult Info(Person person)
        {
            return View( );

        }
    }
}
