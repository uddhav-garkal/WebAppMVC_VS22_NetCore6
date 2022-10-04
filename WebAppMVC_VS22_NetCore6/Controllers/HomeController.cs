using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_VS22_NetCore6.Models;
using WebAppMVC_VS22_NetCore6.Services;

namespace WebAppMVC_VS22_NetCore6.Controllers
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
            ProductService productService = new ProductService();
            IEnumerable<Product> model = productService.GetProducts();


            return View(model);
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