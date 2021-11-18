using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3_test4.Models;

namespace Lab3_test4.Controllers
{
    public class ZadanieController : Controller
    {

        public IActionResult ImieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ImieForm(ZadanieModel model)
        {
            if (ModelState.IsValid && model.Ilosc_Powtorzen>=1 model.Ilosc_Powtorzen<=5)
            {
                return View("ShowImie", model);
            }
            return View(model);
        }
    }
}
