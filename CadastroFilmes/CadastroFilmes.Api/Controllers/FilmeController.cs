using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFilmes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase, IGenericController<Filme, int>
    {
        private readonly IFilmeService _filmeService;

        public FilmeController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        public ActionResult Atualizar(Filme entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult Cadastrar(Filme entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult Excluir(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var result = _filmeService.Listar();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult PesquisarPorId(int id)
        {
            var result = _filmeService.PesquisarPorId(id);
            return Ok(result);
        }
    }
}
