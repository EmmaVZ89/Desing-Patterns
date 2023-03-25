using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RepositoryAsp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Beer> _repository;

        public HomeController(IRepository<Beer> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Beer> lst = _repository.Get();
            return View("Index", lst);
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
