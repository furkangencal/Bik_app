using Bik_app.Data;
using Bik_app.Models;
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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var productCategory = new ProductCategory()
            {
                Name = "Elektronik"
            };

            var productSubcategory = new ProductSubcategory()
            {
                Name = "Telefon",
                ProductCategory = productCategory
            };

            using (var bik_AppContext = new Bik_appContext())
            {
                bik_AppContext.Add(productSubcategory);
                await bik_AppContext.SaveChangesAsync();

                return View();
            }
            
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
