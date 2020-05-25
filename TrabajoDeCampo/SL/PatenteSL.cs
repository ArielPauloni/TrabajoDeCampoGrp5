using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL
{
    public class PatenteSL : PermisoCompositeSL
    {        
        public override IList<PermisoCompositeSL> Hijos
        {
            get
            {
                return new List<PermisoCompositeSL>();
            }
        }

        public override void AgregarHijo(PermisoCompositeSL c)
        {
        }
    }
}
