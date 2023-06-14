using Microsoft.AspNetCore.Mvc;
using SmartFix.Models;
using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace SmartFix.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly ILogger<CadastrosController> _logger;

        public CadastrosController(ILogger<CadastrosController> logger)
        {
            _logger = logger;
        }

        [Route("/v1/cadastro-maquina")]
        public IActionResult CadastroMaquina()
        {
            return View();
        }

        [Route("/v1/cadastro-setor")]
        public IActionResult CadastroSetor()
        {
            return View();
        }

        [Route("/v1/cadastro-ordem-manutencao")]
        public IActionResult CadastroOrdem()
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