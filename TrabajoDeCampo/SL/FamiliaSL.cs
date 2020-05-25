using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL
{
    public class FamiliaSL : PermisoCompositeSL
    {
        private IList<PermisoCompositeSL> _hijos;

        public FamiliaSL()
        {
            _hijos = new List<PermisoCompositeSL>();
        }

        public override IList<PermisoCompositeSL> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }
        }

        //public void VaciarHijos()
        //{
        //    _hijos = new List<PermisoCompositeSL>();
        //}
        public override void AgregarHijo(PermisoCompositeSL c)
        {
            _hijos.Add(c);
        }
    }
}
