using Microsoft.AspNetCore.Mvc;
using RealPromoApiWeb.Models;
using System.Diagnostics;

namespace RealPromoApiWeb.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Promocao()
        {
            return View();
        }
        public IActionResult CadastrarPromocao()
        {
            return View();
        }

    }
}