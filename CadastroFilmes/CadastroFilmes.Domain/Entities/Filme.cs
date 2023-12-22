namespace CadastroFilmes.Domain.Entities
{
    public class Filme
    {

        #region Propriedades
        public int FilmeId { get; set; }
        public int Duracao { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }

        #endregion

        public Filme()
        {
        }

        #region Construtores
        public Filme(int id, string nome, string genero, int Duracao)
        : this(nome, genero, Duracao)
        {

            this.FilmeId = id;
        }

        public Filme(string nome, string genero, int Duracao)
        {
            this.Nome = nome;
            this.Genero = genero;
            this.Duracao = Duracao;

        }

        #endregion


        #region Metodos
        public void ValidarPropriedade()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                throw new Exception("Campo obrigatorio!");
            }

            if (string.IsNullOrEmpty(this.Genero))
            {
                throw new Exception("Campo obrigatorio!");
            }

            if (this.Duracao <= 0)
            {
                throw new Exception("Campo obrigatorio!");
            }

        }
        #endregion
    }
}