using Dept2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dept2.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext context)
        {
            _db = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
