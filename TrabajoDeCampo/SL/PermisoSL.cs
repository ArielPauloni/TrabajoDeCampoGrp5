using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace SL
{
    public class PermisoSL
    {
        private PermisoMapper PermisoMapper = new PermisoMapper();

        public List<PermisoBE> ListarPermisos()
        {
            PermisoMapper m = new PermisoMapper();
            return m.ListarPermisos();
        }

        public int InsertarPermiso(PermisoBE permiso)
        {
            PermisoMapper m = new PermisoMapper();
            return m.InsertarPermiso(permiso);
        }
    }
}
