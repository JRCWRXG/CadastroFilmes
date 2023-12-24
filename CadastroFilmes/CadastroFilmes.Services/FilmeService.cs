using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Entities;
using CadastroFilmes.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmes.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public void Atualizar(Filme entidade)
        {


            try
            {
                _filmeRepository.Atualizar(entidade);
            }

            catch(RepositoryException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {

                throw new ServiceException("Falha ao atualizar filme", ex);
            }
        }

        public void Cadastrar(Filme entidade)
        {
            
            try
            {
                _filmeRepository.Cadastrar(entidade);
            }

            catch (RepositoryException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {

                throw new ServiceException("Falha ao cadastrar filme", ex);
            }



        }

        public void Excluir(int id)
        {
            try
            {
                _filmeRepository.Excluir(id);
            }

            catch (RepositoryException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {

                throw new ServiceException("Falha ao excluir filme", ex);
            }


        }

        public List<Filme> Listar()
        {
            try
            {
                var result = _filmeRepository.Listar();
                // List<Filme> result = _filmeRepository.Listar();     mesma coisa
                return result;
            }

            catch (RepositoryException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {

                throw new ServiceException("Falha ao listar filme", ex);
            }


        }

        public Filme PesquisarPorId(int id)
        {
           
            try
            {
                var filme = PesquisarPorId(id);

                return filme;
            }

            catch (RepositoryException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {

                throw new ServiceException("Falha ao pesquisar filme", ex);
            }
        }
    }
}
