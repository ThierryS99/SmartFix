using Microsoft.AspNetCore.Mvc;
using SmartFix.Data;
using SmartFix.Models;
using SmartFix.Repositorio;

namespace SmartFix.Controllers
{
    public class ConsultaOrdemManutencaoController : Controller
    {   
        private readonly IOrdemManutencaoRepositorio _ordemManutencaoRepositorio;
        public ConsultaOrdemManutencaoController(IOrdemManutencaoRepositorio ordemManutencaoRepositorio)
        {
            _ordemManutencaoRepositorio = ordemManutencaoRepositorio;
        }

        [HttpGet("/v1/consulta-ordem-manutencao")]
        public IActionResult ConsultaOrdemManutencaoView()
        {
            List<OrdemManutencaoModel> ordemManutencao = _ordemManutencaoRepositorio.BuscarOrdens();
            return View(ordemManutencao);
        }
    }
}