using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioBE
    {
        private int cod_Usuario;

        public int Cod_Usuario
        {
            get { return cod_Usuario; }
            set { cod_Usuario = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private TipoUsuarioBE tipoUsuario;

        public TipoUsuarioBE TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        private  List<PermisoBE> permisos;

        public List<PermisoBE> Permisos
        {
            get { return permisos; }
            set { permisos = value; }
        }

        public override string ToString()
        {
            return Nombre + " (" + Mail + ")" + "<" + TipoUsuario.ToString() + ">";
        }

    }
}
