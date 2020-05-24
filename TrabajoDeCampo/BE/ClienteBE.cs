using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ClienteBE : UsuarioBE
    {
        private int cod_Cliente;

        public int Cod_Cliente
        {
            get { return cod_Cliente; }
            set { cod_Cliente = value; }
        }

        private short cod_tipoCliente;

        public short Cod_TipoCliente
        {
            get { return cod_tipoCliente; }
            set { cod_tipoCliente = value; }
        }

        private string tipoCliente;

        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        public override string ToString()
        {
            return Nombre + " (" + Mail + ")" + "<" + TipoUsuario + "/" + TipoCliente + ">";
        }
    }
}
