using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CTJ.Presentation.MVC.Models;
using BoletoNet;

namespace CTJ.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BoletoBancario b = new BoletoBancario();
            //ContaBancaria contaBancaria = new ContaBancaria();

            //b.CodigoBanco = 237;

            //Boleto boleto = new Boleto();


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
