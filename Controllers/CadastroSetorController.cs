using Microsoft.AspNetCore.Mvc;
using SmartFix.Models;
using SmartFix.Repositorio;
using SmartFix.Views;
using System.Windows.Markup;

namespace SmartFix.Controllers
{
    public class CadastroSetorController : Controller
    {   
        private readonly ISetorRepositorio _setorRepositorio;
        public CadastroSetorController(ISetorRepositorio setorRepositorio)
        {
            _setorRepositorio = setorRepositorio;
        }
        

        [HttpGet]
        [Route("/v1/cadastro-setor")]
        public IActionResult CadastroSetorView()
        {
            return View();
        }

        [HttpPost]
        [Route("/v1/cadastro-setor")]
        
        public IActionResult CadastroSetorView(SetorModel setor)
        {
            try
            {
                _setorRepositorio.Adicionar(setor);
                return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }
            
        }
    }
}