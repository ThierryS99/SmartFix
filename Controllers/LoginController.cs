using Microsoft.AspNetCore.Mvc;
using SmartFix.Data;
using SmartFix.Models;
using SmartFix.Repositorio;

namespace SmartFix.Controllers
{
    public class LoginController : Controller
    {   
        private readonly IOrdemManutencaoRepositorio _ordemManutencaoRepositorio;
        public LoginController(IOrdemManutencaoRepositorio ordemManutencaoRepositorio)
        {
            _ordemManutencaoRepositorio = ordemManutencaoRepositorio;
        }

        [HttpGet("/v1/login-usuario")]
        public IActionResult LoginView()
        {
            List<OrdemManutencaoModel> ordemManutencao = _ordemManutencaoRepositorio.BuscarOrdens();
            return View(ordemManutencao);
        }
    }
}