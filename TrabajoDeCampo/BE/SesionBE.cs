using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SesionBE
    {
        private UsuarioBE usuario;

        public UsuarioBE Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private static SesionBE _instancia;
        public static Boolean Autenticado = false;

        protected SesionBE()
        {
            Autenticado = false;
        }

        public static SesionBE InstanciarEstado()
        {
            if (_instancia == null)
            {
                _instancia = new SesionBE();
            }
            return _instancia;
        }
    }
}
