using Microsoft.AspNetCore.Mvc;
using SmartFix.Models;
using SmartFix.Repositorio;

namespace SmartFix.Controllers
{
    public class CadastroSetorController : Controller
    {   
        private readonly ISetorRepositorio _setorRepositorio;
        public CadastroSetorController(ISetorRepositorio setorRepositorio)
        {
            _setorRepositorio = setorRepositorio;
        }
        

        //[HttpGet("/v1/cadastro-setor")]
        public IActionResult CadastroSetorView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroSetorView(SetorModel setor)
        {
            _setorRepositorio.Adicionar(setor);
            return RedirectToAction("CadastroSetorView");
        }
    }
}