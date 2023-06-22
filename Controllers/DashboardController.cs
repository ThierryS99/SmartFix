using Microsoft.AspNetCore.Mvc;
using SmartFix.Data;
using SmartFix.Models;
using SmartFix.Repositorio;

namespace SmartFix.Controllers
{
    public class DashboardController : Controller
    {   
        private readonly IOrdemManutencaoRepositorio _ordemManutencaoRepositorio;
        public DashboardController(IOrdemManutencaoRepositorio ordemManutencaoRepositorio)
        {
            _ordemManutencaoRepositorio = ordemManutencaoRepositorio;
        }

        [HttpGet]
        public IActionResult DashboardView()
        {
            List<OrdemManutencaoModel> ordemManutencao = _ordemManutencaoRepositorio.BuscarOrdens();
            return View(ordemManutencao);
        }
    }
}