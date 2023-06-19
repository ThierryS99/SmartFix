using Microsoft.AspNetCore.Mvc;
using SmartFix.Models;
using SmartFix.Repositorio;

namespace SmartFix.Controllers
{
    public class CadastroMaquinaController : Controller
    {
        private readonly IMaquinaRepositorio _maquinaRepositorio;

        public CadastroMaquinaController(IMaquinaRepositorio maquinaRepositorio)
        {
            _maquinaRepositorio = maquinaRepositorio;
        } 
        

        [HttpGet("/v1/cadastro-maquina")]
        public IActionResult CadastroMaquinaView()
        {
            return View();
        }

        [HttpPost("/v1/cadastro-maquina")]
        public IActionResult CadastroMaquinaView(MaquinaModel maquina)
        {
            _maquinaRepositorio.Adicionar(maquina);
            return RedirectToAction("CadastroMaquinaView");
        }
    }
}
        