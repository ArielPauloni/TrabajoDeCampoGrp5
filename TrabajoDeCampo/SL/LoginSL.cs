using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace SL
{
    public class LoginSL
    {
        public UsuarioBE ObtenerUsuarioAutenticado(UsuarioBE usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            try { return m.ObtenerUsuarioLogin(usuario); }
            catch (DAL.UsuarioModificadoException ex) { throw new SL.UsuarioModificadoException(ex.Message); }
        }

    }
}
