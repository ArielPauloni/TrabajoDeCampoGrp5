using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioModificadoException : Exception
    {
        public UsuarioModificadoException()
        {
        }

        public UsuarioModificadoException(string message) : base(message)
        {
        }
    }

    public class MenuModificadoException : Exception
    {
        public MenuModificadoException()
        {
        }

        public MenuModificadoException(string message) : base(message)
        {
        }
    }
}
