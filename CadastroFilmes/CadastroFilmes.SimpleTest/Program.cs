using CadastroFilmes.Domain.Entities;
using CadastroFilmes.infrastructure.Repositories;

namespace CadastroFilmes.SimpleTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ValidaObjetoFilme();
            ValidaCamadaRepositorio();
        }

        static void ValidaObjetoFilme()
        {
            Filme filme = new Filme(1, "titanic", "drama", 125);
            filme.ValidarPropriedade();

            Console.WriteLine($" filme {filme.Nome}");

            Filme filme1 = new Filme(2, "batman", "comedia", 125);
            filme1.Nome = "007";
            filme1.ValidarPropriedade();

            Console.WriteLine($" filme {filme1.Nome}");

        }

        static void ValidaCamadaRepositorio()
        {
            FilmeRepository filmeRepository = new FilmeRepository();

            Filme filme = new Filme(1, "titanic", "drama", 125);

            Filme filme1 = new Filme(2, "batman", "comedia", 125);
            filme1.Nome = "007";

            filmeRepository.Cadastrar(filme1);
            filmeRepository.Cadastrar(filme1);

            List<Filme> filmes = filmeRepository.Listar();

           Filme filmePesquisado =  filmeRepository.PesquisarPorId(filme.FilmeId);
        }
    }
}