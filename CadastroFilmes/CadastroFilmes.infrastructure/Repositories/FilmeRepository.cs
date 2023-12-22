using CadastroFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmes.infrastructure.Repositories;

public class FilmeRepository
{
    private List<Filme> _filmes = new List<Filme>();

    public void Cadastrar(Filme filme)
    {
        _filmes.Add(filme);
    }

    public void Atualizar(Filme filme)
    {
        Filme fimepesquisado = PesquisarPorId(filme.FilmeId);
       
        if (fimepesquisado != null)
        {
            _filmes.Remove(fimepesquisado);
            _filmes.Add(filme); 
        }
    }

    public void Excluir(int id)
    {
        Filme fimepesquisado = PesquisarPorId(id);
        
        if(fimepesquisado!= null ) 
        {
        _filmes.Remove(fimepesquisado);
        }
    }

    public Filme PesquisarPorId(int id)
    {
        Filme result = _filmes.FirstOrDefault(p => p.FilmeId == id);
        return result;
    }

    public List<Filme> Listar()
    {
        return _filmes;
    }
}
