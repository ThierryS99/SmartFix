﻿using Microsoft.AspNetCore.Mvc;
using SmartFix.Models;
using SmartFix.Repositorio;
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
        
        /*
        private readonly ISetorRepositorio _setorRepositorio;
        public CadastrosController(ISetorRepositorio setorRepositorio)
        {
            _setorRepositorio = setorRepositorio;
        }

        /*
        private readonly IMaquinaRepositorio _maquinaRepositorio;
        public CadastrosController(IMaquinaRepositorio maquinaRepositorio)
        {
            _maquinaRepositorio = maquinaRepositorio;
        } 
         
        private readonly IOrdemManutencaoRepositorio _ordemManutencaoRepositorio;
        public CadastrosController(IOrdemManutencaoRepositorio ordemManutencaoRepositorio)
        {
            _ordemManutencaoRepositorio = ordemManutencaoRepositorio;
        }
        */

        [HttpGet("/v1/cadastro-setor")]
        public IActionResult CadastroSetor()
        {
            return View();
        }

        [HttpPost("/v1/cadastro-setor")]
        public IActionResult CadastroSetorPost()
        {
            return View();
        }

        [HttpGet("/v1/cadastro-maquina")]
        public IActionResult CadastroMaquina()
        {
            return View();
        }

        [HttpPost("/v1/cadastro-maquina")]
        public IActionResult CadastroMaquinaPost()
        {
            return View();
        }


        [HttpGet("/v1/cadastro-ordem-manutencao")]
        public IActionResult CadastroOrdemManutencao()
        {
            return View();
        }


        [HttpPost("/v1/cadastro-ordem-manutencao")]
        public IActionResult CadastroOrdemManutencaoPost()
        {
            return View();
        }
    }
}