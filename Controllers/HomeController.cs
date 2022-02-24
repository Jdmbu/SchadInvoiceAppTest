using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchadInvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SchadInvoiceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Models.Test_InvoiceContext _context;

        public HomeController(ILogger<HomeController> logger, Models.Test_InvoiceContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var lst = _context.CustomerTypes.ToList();
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
