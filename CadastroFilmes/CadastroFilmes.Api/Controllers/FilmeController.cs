
using CadastroFilmes.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFilmes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private List<Filme> filmes = new List<Filme>();

        public FilmeController()
        {
            CarregarListas();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var filmesOrdenados  = filmes.OrderBy(x => x.Nome).ToList();
            //string mensagem = "boa";
            //return Ok(mensagem);

            return Ok(filmesOrdenados); 
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var filmePesquisado = filmes.FirstOrDefault(x => x.Id.Equals(id));

            if (filmePesquisado == null)
                return BadRequest($" o filme {id} nao foi localizado");
            
            return Ok(filmePesquisado);
        }



        [HttpPost]
        public ActionResult Cadastrar([FromBody] Filme filme)
        {
           int proximoId = filmes.Count();
            proximoId++;

            Filme objFilme = new Filme(proximoId, filme.Nome, filme.Genero);

            filmes.Add(objFilme);  

            return Ok($"cadastro do file {filme.Nome} efetuado");
        }

        private void CarregarListas()
        {
            Filme filme = new Filme(1, "filme1", "drama1");
            Filme filme1 = new Filme(2, "filme2", "drama2");
            Filme filme2 = new Filme(3, "filme3", "drama3");
            Filme filme3 = new Filme(4, "filme4", "drama4");

            filmes.Add(filme);
            filmes.Add(filme1);
            filmes.Add(filme2);
            filmes.Add(filme3);
        }
    }
}
