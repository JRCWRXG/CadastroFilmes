using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Entities;
using CadastroFilmes.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmes.infrastructure.Repositories;

public class FilmeRepository : IFilmeRepository
{
    private List<Filme> _filmes = null;

    public FilmeRepository()
    {
        CarregarFilmes();
    }

    private void CarregarFilmes()
    {
        _filmes = new List<Filme>()
        {
            new Filme(1, "Titanic", "Drma", 90),
             new Filme(2, "Batman", "Drma", 90),
              new Filme(3, "007", "Drma", 90),
               new Filme(4, "Rambo", "Drma", 90),
                new Filme(5, "seila", "Drma", 90),
                 new Filme(6, "xxxx", "Drma", 90)
        };

    }

    public void Cadastrar(Filme filme)
    {
        try
        {
            _filmes.Add(filme);
        }
        catch (Exception ex)
        {

            //Console.WriteLine(ex.Message);
            var message = "falha ao cadastrar";    
            throw new RepositoryException(message, ex);   
        }
    }

    public void Atualizar(Filme filme)
    {  
        try
        {
            Filme fimepesquisado = PesquisarPorId(filme.FilmeId);

            if (fimepesquisado != null)
            {
                _filmes.Remove(fimepesquisado);
                _filmes.Add(filme);
            }
        }
        catch (Exception ex)
        {
            var message = "falha ao atualizar";
            throw new RepositoryException(message, ex);
        }
    }

    public void Excluir(int id)
    {
        try
        {
            Filme fimepesquisado = PesquisarPorId(id);

            if (fimepesquisado != null)
            {
                _filmes.Remove(fimepesquisado);
            }
        }
        catch (Exception ex)
        {
            var message = "falha ao pesquisar";
            throw new RepositoryException(message, ex);
        }

    }

    public Filme PesquisarPorId(int id)
    {
        try
        {
            Filme result = _filmes.FirstOrDefault(p => p.FilmeId == id);
            return result;
        }
        catch (Exception ex)
        {
            var message = "falha ao pesquisar";
            throw new RepositoryException(message, ex);
        }




    }

    public List<Filme> Listar()
    {
        try
        {
            return _filmes;
        }
        catch (Exception ex)
        {

            var message = "falha ao cadastrar";
            throw new RepositoryException(message, ex);
        }
    }
}
