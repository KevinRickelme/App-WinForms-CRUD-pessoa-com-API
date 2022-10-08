using API_consulta_Pessoa_Cadastrada.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testing_app.Model;

namespace API_consulta_Pessoa_Cadastrada.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        public ILogger<PessoaController> _logger;
        private readonly IPessoa _pessoaRepository;
        public PessoaController(ILogger<PessoaController> logger, IPessoa pessoaRepository) 
        {
            _logger = logger;
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        [Route("BuscarTodos")]
        public IActionResult Get()
        {

            return Json(_pessoaRepository.Get());
        }

        [HttpPost]
        [Route("CadastrarPessoa")]
        public bool CadastrarPessoa(Pessoa p)
        {
            return _pessoaRepository.Cadastrar(p);
        }
    }
}
