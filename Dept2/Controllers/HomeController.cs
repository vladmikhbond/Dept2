using Dept2.Data;
using Dept2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // GET: Home
        public async Task<IActionResult> Index()
        {
            var news = await _db.News
                .OrderByDescending(n => n.Date)
                .ToListAsync();

            return View(news);
        }

        // GET: Home/Staff
        public IActionResult Staff()
        {
            Dictionary<int, List<Person> >  persons = 
                _db.Persons
                .AsEnumerable()
                .GroupBy(p => (int)p.Rank)
                .ToDictionary(g => g.Key, g => g.OrderBy(g => g.Name_uk).ToList());              
            return View(persons);
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
