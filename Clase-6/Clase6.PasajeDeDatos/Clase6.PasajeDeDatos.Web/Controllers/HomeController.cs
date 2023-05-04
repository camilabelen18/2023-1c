﻿using System.Diagnostics;
using Clase6.PasajeDeDatos.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.PasajeDeDatos.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}