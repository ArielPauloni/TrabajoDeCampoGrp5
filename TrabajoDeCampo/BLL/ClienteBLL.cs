using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL
{
    public class ClienteBLL
    {
        public ClienteBE ObtenerCliente(ClienteBE cliente)
        {
            ClienteMapper m = new ClienteMapper();
            return m.ObtenerCliente(cliente);
        }
    }
}
