using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        
        public int Insertar(UsuarioBE Usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            return m.Insertar(Usuario);
        }

        public int Editar(UsuarioBE Usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            return m.Editar(Usuario);
        }

        public int Eliminar(UsuarioBE Usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            return m.Eliminar(Usuario);
        }

        public UsuarioBE ObtenerUsuarioLogin(UsuarioBE usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            try { return m.ObtenerUsuarioLogin(usuario); }
            catch (DAL.UsuarioModificadoException ex) { throw new BLL.UsuarioModificadoException(ex.Message); }
        }

        public UsuarioBE ObtenerUsuarioPorMail(UsuarioBE usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            try { return m.ObtenerUsuarioPorMail(usuario); }
            catch (DAL.UsuarioModificadoException ex) { throw new BLL.UsuarioModificadoException(ex.Message); }
        }

        public UsuarioBE ObtenerUsuarioPorCod(UsuarioBE usuario)
        {
            UsuarioMapper m = new UsuarioMapper();
            try { return m.ObtenerUsuarioPorCod(usuario); }
            catch (DAL.UsuarioModificadoException ex) { throw new BLL.UsuarioModificadoException(ex.Message); }
        }

        public List<UsuarioBE> Listar()
        {
            UsuarioMapper m = new UsuarioMapper();
            try { return m.Listar(); }
            catch (DAL.UsuarioModificadoException ex) { throw new BLL.UsuarioModificadoException(ex.Message); }
        }
    }
}
