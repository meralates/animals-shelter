using Microsoft.AspNetCore.Mvc;
using MyDynamicWebsite.Models;
using System.Collections.Generic;

namespace MyDynamicWebsite.Controllers
{
    public class AnimalControllerv:Controller{
        public IActionResult Index(){
            var animals = new List<Animal>
            {
                new Animal{ Id=1,Name="Max",Species="Dog",Age=5},
                new Animal{ Id=2,Name="Whiskers",Species="cat",Age=2},
            };
            return View(animals);
        }

        //hayvan eklemek iççin
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if(ModelState.IsValid){
                return RedirectToAction("Index");
            }
            return View(animal);
        } 
    }
}