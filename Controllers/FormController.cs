using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3_test4.Models;

namespace Lab3_test4.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Created", model);
            }
            return View(model);
        }
    }
}
