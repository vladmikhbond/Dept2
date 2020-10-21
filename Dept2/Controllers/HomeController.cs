using Dept2.Data;
using Dept2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dept2.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;
      readonly ApplicationDbContext _db;

      public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
      {
         _db = context;
         _logger = logger;
      }

      public IActionResult Index()
      {
         var news = _db.News.ToArray();
         return View(news);
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
