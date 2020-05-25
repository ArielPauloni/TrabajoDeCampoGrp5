using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PermisoBE
    {
        public PermisoBE()
        { }

        public PermisoBE(string nombre)
        {
            descripcionPermiso = nombre;
        }

        private int codPermiso;

        public int CodPermiso
        {
            get { return codPermiso; }
            set { codPermiso = value; }
        }

        private string descripcionPermiso;

        public string DescripcionPermiso
        {
            get { return descripcionPermiso; }
            set { descripcionPermiso = value; }
        }

        public override string ToString()
        {
            return DescripcionPermiso;
        }

    }
}
