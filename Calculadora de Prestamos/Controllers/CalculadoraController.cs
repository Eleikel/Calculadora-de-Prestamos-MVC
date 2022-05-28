using Calculadora_de_Prestamos.Models;
using Calculadora_de_Prestamos.Service;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_de_Prestamos.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly CalculadoraService _calculadoraService;

        public CalculadoraController()
        {
            _calculadoraService = new();
        }

        public IActionResult Index()
        {
            return View(new CalculadoraViewModel());
        }

        [HttpPost]
        public IActionResult NewAction(CalculadoraViewModel cvm)
        {
            _calculadoraService.Calcular(cvm);
            return View(cvm);
        }

       

    }
}
