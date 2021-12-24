using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using area51.Models;

namespace area51.Controllers
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

InscreverDB DB = new InscreverDB();
DB.TestarConexao();

            return View();
        }

 public IActionResult Quemsomos()
        {
            return View();
        }

 public IActionResult Faleconosco()
        {
            return View();
        }

public IActionResult Exercicios()
        {
            return View();
        }

 public IActionResult Modalidades()
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
