﻿using Bik_app.Models;
using Bik_app.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Controllers
{
    public class HomeController : Controller
    {
        private AdventureWorks2017Context Context { get; }
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;
        //Dependency injection
        public HomeController(ILogger<HomeController> logger,IRepository repository, AdventureWorks2017Context _adventureWorks2017Context)
        {
            _logger = logger;
            _repository = repository;
            this.Context = _adventureWorks2017Context;
        }

        public async Task<IActionResult> Index()
        {
            var urunler = await _repository.GetProduct();

            return View(urunler);
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            this.Context.Add(product);
            this.Context.SaveChanges();
            return View(product);
        }

        public IActionResult EditProduct()
        {
            return View();
        }



        public IActionResult ProductDelete()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
