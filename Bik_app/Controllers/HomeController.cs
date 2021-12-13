using Bik_app.Data;
using Bik_app.Models;
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
        private readonly ILogger<HomeController> _logger;
        // private readonly Bik_appContext _dbContext;
        private readonly IRepository _repository;
        //Dependency injection
        public HomeController(ILogger<HomeController> logger, /*Bik_appContext context,*/ IRepository repository)
        {
            _logger = logger;
            //_dbContext = context;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            //var productCategory = new ProductCategory()
            //{
            //    Name = "Elektronik 3"
            //};

            //var productSubcategory = new ProductSubcategory()
            //{
            //    Name = "Telefon 3",
            //    ProductCategory = productCategory
            //};


            //int result = _repository.AddSubCategory(productSubcategory);

            var urunler = await _repository.GetProduct();


            return View(urunler);
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
