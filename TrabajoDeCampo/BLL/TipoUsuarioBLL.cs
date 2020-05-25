using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class TipoUsuarioBLL
    {
        public List<TipoUsuarioBE> Listar()
        {
            TipoUsuarioMapper m = new TipoUsuarioMapper();
            return m.Listar();
        }
    }
}
