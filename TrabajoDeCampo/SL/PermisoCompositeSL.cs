using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace SL
{
    public abstract class PermisoCompositeSL
    {
        public string Nombre { get; set; }
        public PermisoBE permiso;

        public abstract IList<PermisoCompositeSL> Hijos { get; }
        public abstract void AgregarHijo(PermisoCompositeSL c);
        //public Permisos Permiso { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
