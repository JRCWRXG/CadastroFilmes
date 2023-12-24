using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Entities;
using CadastroFilmes.infrastructure.Repositories;
using CadastroFilmes.Services;

namespace CadastroFilmes.SimpleTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int op = 3;
            switch (op)
            {
                case 1:
                    ValidaObjetoFilme();
                    break;
                case 2:
                    ValidaCamadaRepositorio();
                    break;
                case 3:
                    ValidaCamadaServico();
                    break;
            }




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

            filmeRepository.Cadastrar(filme);
            filmeRepository.Cadastrar(filme1);

            List<Filme> filmes = filmeRepository.Listar();

            Filme filmePesquisado = filmeRepository.PesquisarPorId(filme.FilmeId);
        }


        static void ValidaCamadaServico()
        {
            IFilmeRepository filmeRepository = new FilmeRepository();
            IFilmeService filmeService = new FilmeService(filmeRepository);

            Filme filme = new Filme(1, "titanic", "drama", 125);
            Filme filme2 = new Filme(2, "batman1", "comedia1", 125);
            Filme filme3 = new Filme(3, "batman2", "comedia2", 125);
            Filme filme4 = new Filme(4, "batman3", "comedia3", 125);

            List<Filme> filmes = new List<Filme>() { filme, filme2, filme3, filme4 };

            foreach (var item in filmes)
            {
                filmeService.Cadastrar(item);
            }

            var ListaDeFilme = filmeService.Listar();
        }

    }
}