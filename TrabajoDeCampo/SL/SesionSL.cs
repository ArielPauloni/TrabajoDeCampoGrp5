using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace SL
{
    public class SesionSL
    {
        private static SesionSL _instance = null;
        private UsuarioBE usuario;

        private SesionSL() { }

        public static SesionSL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SesionSL();
                }
                return _instance;
            }
        }

        public void Login(UsuarioBE usuario)
        {
            this.usuario = usuario;
        }

        public void Logout()
        {
            this.usuario = null;
        }

        public bool VerificarLogueado(UsuarioBE usuario)
        {
            return (this.usuario == usuario);
        }
    }
}
