using Microsoft.AspNetCore.Mvc;
using SmartFix.Data;
using SmartFix.Models;
using SmartFix.Repositorio;

namespace SmartFix.Controllers
{
    public class CadastroOrdemManutencaoController : Controller
    {   
        private readonly IOrdemManutencaoRepositorio _ordemManutencaoRepositorio;
        public CadastroOrdemManutencaoController(IOrdemManutencaoRepositorio ordemManutencaoRepositorio)
        {
            _ordemManutencaoRepositorio = ordemManutencaoRepositorio;
        }
        

        [HttpGet("/v1/cadastro-ordem-manutencao")]
        public IActionResult CadastroOrdemManutencaoView()
        {
            return View();
        }

        [HttpPost("/v1/cadastro-ordem-manutencao")]
        public IActionResult CadastroOrdemManutencaoView(OrdemManutencaoModel ordemManutencao)
        {

            _ordemManutencaoRepositorio.Adicionar(ordemManutencao);
            return RedirectToAction("CadastroOrdemManutencaoView");
        }

        [HttpGet]
        public IActionResult ListarMaquinas(MaquinaModel maquina)
        {
            List<MaquinaModel> listaMaquina = _ordemManutencaoRepositorio.BuscarMaquina();
            return View(listaMaquina);
        }
    }
}