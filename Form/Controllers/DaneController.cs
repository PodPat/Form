﻿using Microsoft.AspNetCore.Mvc;
using Form.Models;
namespace Form.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();

        }
        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
