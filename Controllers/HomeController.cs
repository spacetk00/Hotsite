using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            DatabaseContext db = new DatabaseContext();
            if(db.Database.EnsureCreated()){
                ViewBag.Falha = "Falha no cadastro, tente mais tarde";
                return View("Index");
            }
            else{
                dbs.CadastraInteresse(cad);
                ViewBag.Confirma = "Cadastro confimardo";
                return View("Index",cad);
            }
        }

    }
}
