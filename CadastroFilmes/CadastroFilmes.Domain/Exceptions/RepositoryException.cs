using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmes.Domain.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException()
        {

        }

        public RepositoryException(string message)
            : base(message) 
        {

        }

        public RepositoryException(string message , Exception innerExcption )
            : base(message, innerExcption)
        {

        }
    }
}
